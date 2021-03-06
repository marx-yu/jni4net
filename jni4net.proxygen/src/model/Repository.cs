#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of tools for jni4net - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.InteropServices;
using java.io;
using java.lang;
using java.util.zip;
using net.sf.jni4net.adaptors;
using net.sf.jni4net.jni;
using net.sf.jni4net.proxygen.config;
using Exception = java.lang.Exception;
using File=System.IO.File;
using String=java.lang.String;

namespace net.sf.jni4net.proxygen.model
{
    internal partial class Repository
    {
        private static readonly List<GType> all = new List<GType>();
        private static readonly Dictionary<Class, GType> knownClasses = new Dictionary<Class, GType>();
        private static readonly Dictionary<string, GType> knownNames = new Dictionary<string, GType>();
        private static readonly Dictionary<Type, GType> knownTypes = new Dictionary<Type, GType>();
        public static ToolConfig config;
        private static List<Assembly> knownAssemblies = new List<Assembly>();

        private static List<Assembly> generateAssemblies = new List<Assembly>();
        private static List<string> generateCp = new List<string>();

        public static IList<Assembly> KnownAssemblies
        {
            get
            {
                Assembly[] res = new Assembly[knownAssemblies.Count];
                knownAssemblies.CopyTo(res, 0);
                return res;
            }
        }

        public static void Analyze()
        {
            systemObject.Interfaces.Clear();
            javaLangObject.Interfaces.Clear();
            jvmProxy.Interfaces.Clear();
            clrProxy.Interfaces.Clear();
            javaLangThrowable.Interfaces.Clear();
            systemException.Interfaces.Clear();

            foreach (GType type in new List<GType>(all))
            {
                FlagLoadMethods(type, false, false);
            }
            foreach (GType type in new List<GType>(all))
            {
                PreLoadMethods(type);
            }
            foreach (GType type in new List<GType>(all))
            {
                type.Resolve();
            }
            foreach (GType type in new List<GType>(all))
            {
                type.UpdateNames();
            }
            foreach (GType type in new List<GType>(all))
            {
                LoadMethods(type);
            }
            foreach (GType type in new List<GType>(all))
            {
                type.UpdateMethods();
            }
            if (config.Verbose)
            {
                foreach (GType type in all)
                {
                    if (!type.IsJVMGenerate && !type.IsCLRGenerate)
                    {
                        if (type.CLRSubst != null)
                        {
                            Console.WriteLine(type + " ->ToCLR-> " + type.CLRResolved);
                        }
                        else if (type.JVMSubst != null)
                        {
                            Console.WriteLine(type + " ->ToJVM-> " + type.JVMResolved);
                        }
                        else
                        {
                            Console.WriteLine(type);
                        }
                    }
                }
                Console.WriteLine();
            }
            foreach (GType type in all)
            {
                if (type.IsJVMGenerate)
                {
                    Console.WriteLine("will generate JVM " + type);
                }
                else if (type.IsCLRGenerate)
                {
                    Console.WriteLine("will generate CLR " + type);
                }
            }
        }

        public static List<GType> GetGenInterfaces()
        {
            var res = new List<GType>();
            foreach (GType type in all)
            {
                if ((type.IsJVMGenerate || type.IsCLRGenerate) && type.IsInterface)
                {
                    res.Add(type);
                }
            }
            return res;
        }

        private static void Register(GType type)
        {
            bool known = false;
            if (type.CLRType != null)
            {
                if (!knownTypes.ContainsKey(type.CLRType))
                {
                    knownTypes.Add(type.CLRType, type);
                }
                else
                {
                    known = true;
                }
            }
            if (type.JVMType != null)
            {
                if (!knownClasses.ContainsKey(type.JVMType))
                {
                    knownClasses.Add(type.JVMType, type);
                }
                else
                {
                    known = true;
                }
            }
            if (!knownNames.ContainsKey(type.LowerName))
            {
                knownNames.Add(type.LowerName, type);
            }
            if (!known)
            {
                all.Add(type);
            }
        }

        public static void Register()
        {
            if (config.Verbose)
            {
                Console.WriteLine("clr.version         :" + RuntimeEnvironment.GetSystemVersion());
                Console.WriteLine("clr.arch            :" + ((IntPtr.Size == 8) ? "64bit" : "32bit"));
            }
            LoadClasspath();
            if (config.Verbose)
            {
                Console.WriteLine("java.home           :" + Bridge.Setup.JavaHome);
                Console.WriteLine("java.version        :" + java.lang.System.getProperty("java.version"));
                Console.WriteLine("sun.arch.data.model :" + java.lang.System.getProperty("sun.arch.data.model"));
                Console.WriteLine("");
            }

            LoadAssemblies();

            RegisterAssemblies();

            if (config.JavaClass != null)
            {
                RegisterClasses();
            }
            if (config.ClrType != null)
            {
                RegisterTypes();
            }

            foreach (Assembly assembly in generateAssemblies)
            {
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.IsPublic)
                    {
                        TypeRegistration registration=new TypeRegistration();
                        registration.TypeName = type.FullName;
                        GType reg = RegisterType(type, registration);
                        reg.IsJVMGenerate = true;
                        reg.IsSkipCLRInterface = !registration.SyncInterface;
                        reg.MergeJavaSource = registration.MergeJavaSource;
                    }
                }
            }

            foreach (string classPath in generateCp)
            {
                if (Directory.Exists(classPath))
                {
                    string path = Path.GetFullPath(classPath);
                    foreach (string classFile in Directory.GetFiles(path, "*.class", SearchOption.AllDirectories))
                    {
                        if (!classFile.Contains("$"))
                        {
                            string name = classFile.Substring(path.Length+1);
                            string clazzName = name.Substring(0, name.Length - (".class".Length)).Replace('\\', '/');
                            RegisterClass(clazzName);
                        }
                    }
                }
                else if (File.Exists(classPath) && Path.GetExtension(classPath)==".jar")
                {
                    using (var fis = Adapt.Disposable(new FileInputStream(classPath)))
                    {
                        using (var zis = Adapt.Disposable(new ZipInputStream(fis.Real)))
                        {
                            ZipEntry entry = zis.Real.getNextEntry();
                            while (entry!=null)
                            {
                                string name = entry.getName();
                                if (!entry.isDirectory() && name.EndsWith(".class") && !name.Contains("$"))
                                {
                                    string clazzName = name.Substring(0, name.Length - (".class".Length));
                                    RegisterClass(clazzName);
                                }
                                entry = zis.Real.getNextEntry();
                            }
                        }
                    }
                }
            }
        }

        private static void RegisterAssemblies()
        {
            BindKnownTypesPre();
            foreach (Assembly assembly in knownAssemblies)
            {
                foreach (Type type in assembly.GetTypes())
                {
                    object javaInterfaceA = HasAttribute(type, javaInterfaceAttr);
                    object clrWrapperA = HasAttribute(type, clrWrapperAttr);
                    object javaClassA = HasAttribute(type, javaClassAttr);
                    if ((jvmProxyType.IsAssignableFrom(type) && javaClassA != null) ||
                        (type.IsInterface && javaInterfaceA != null))
                    {
                        string clazzName = GetInterfaceName(type);
                        Class clazz = loadClass(clazzName, false);
                        if (clazz != null)
                        {
                            RegisterClass(clazz);
                        }
                        RegisterType(type);
                    }
                    else if (clrWrapperA != null && type.IsSealed && type.Name.StartsWith("__"))
                    {
                        var realType =
                            clrWrapperA.GetType().GetProperty("InterfaceType").GetValue(clrWrapperA, null) as Type;
                        if (realType != null)
                        {
                            string clazzName = GetInterfaceName(type);
                            Class clazz = loadClass(clazzName, false);
                            if (clazz != null)
                            {
                                RegisterClass(clazz);
                            }
                            RegisterType(realType);
                        }
                    }
                }
            }
            BindKnownTypesPost();
        }

        static ClassLoader systemClassLoader;
        private static Class loadClass(string clazzName, bool logDetails)
        {
            Class clazz = JNIEnv.ThreadEnv.FindClassNoThrow(clazzName);
            if (clazz == null && systemClassLoader!=null)
            {
                try
                {
                    string replace = clazzName.Replace('/','.');
                    clazz = systemClassLoader.loadClass(replace);
                }
                catch(Throwable ex)
                {
                    Console.Error.WriteLine("Can't load class " + clazzName);
                    if (config.Verbose)
                    {
                        Console.Error.WriteLine(ex.ToString());
                    }
                    clazz = null;
                }
            }
            return clazz;
        }

        private static void RegisterClasses()
        {
            foreach (TypeRegistration registration in config.JavaClass)
            {
                string name = registration.TypeName.Replace(".", "/");
                Class clazz = loadClass(name, true);
                if (clazz != null)
                {
                    GType reg = RegisterClass(clazz, registration);
                    reg.IsCLRGenerate = registration.Generate;
                    reg.IsSkipJVMInterface = !registration.SyncInterface;
                    reg.MergeJavaSource = registration.MergeJavaSource;
                }
            }
        }

        private static void RegisterTypes()
        {
            foreach (TypeRegistration registration in config.ClrType)
            {
                Type type = null;
                foreach (Assembly a in knownAssemblies)
                {
                    type = a.GetType(registration.TypeName);
                    if (type != null)
                    {
                        break;
                    }
                }

                if (type == null)
                {
                    Console.Error.WriteLine("Can't load type" + registration.TypeName);
                    throw new JNIException("Can't load type" + registration.TypeName);
                }
                GType reg = RegisterType(type, registration);
                reg.IsJVMGenerate = registration.Generate;
                reg.IsSkipCLRInterface = !registration.SyncInterface;
                reg.MergeJavaSource = registration.MergeJavaSource;
            }
        }
    }
}