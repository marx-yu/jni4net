#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as 
published by the Free Software Foundation, either version 3 
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace java.lang
{
    //TODO sealed
    public partial class String
    {
        public static implicit operator String(string str)
        {
            return JNIEnv.ThreadEnv.NewString(str);
        }

        public static implicit operator string(String str)
        {
            if (str == (String) null)
            {
                return null;
            }
            JNIEnv env = JNIEnv.ThreadEnv;
            return env.ConvertToString(str.jvmHandle);
        }

        public override bool Equals(object obj)
        {
            if (obj is string)
            {
                return obj.Equals((string) this);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return ((string) this).GetHashCode();
        }

        public override string ToString()
        {
            return this;
        }

        public static bool operator ==(String x, String y)
        {
            if ((object) x == null && (object) y == null)
                return true;
            if ((object) x == null || (object) y == null)
                return false;

            return x.equals(y);
        }

        public static bool operator !=(String x, String y)
        {
            if ((object) x == null && (object) y == null)
                return false;
            if ((object) x == null || (object) y == null)
                return true;
            return !x.equals(y);
        }

        public static bool operator ==(String x, string y)
        {
            if ((object) x == null && (object) y == null)
                return true;
            if ((object) x == null || (object) y == null)
                return false;
            return y.Equals(x);
        }

        public static bool operator !=(String x, string y)
        {
            if ((object) x == null && (object) y == null)
                return false;
            if ((object) x == null || (object) y == null)
                return true;
            return !y.Equals(x);
        }

        public static bool operator ==(string x, String y)
        {
            if ((object) x == null && (object) y == null)
                return true;
            if ((object) x == null || (object) y == null)
                return false;
            return x.Equals(y);
        }

        public static bool operator !=(string x, String y)
        {
            if ((object) x == null && (object) y == null)
                return false;
            if ((object) x == null || (object) y == null)
                return true;
            return !x.Equals(y);
        }

        internal static String CreateProxy(JNIEnv env, JniLocalHandle obj)
        {
            var proxy = new String(env);
            ((IJvmProxy) proxy).Init(env, obj);
            return proxy;
        }
    }
}