//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.builder {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface KnowledgeBuilderConfiguration : global::org.drools.PropertiesConfiguration, global::org.drools.builder.conf.KnowledgeBuilderOptionsConfiguration {
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class KnowledgeBuilderConfiguration_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.builder.@__KnowledgeBuilderConfiguration.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.builder.KnowledgeBuilderConfiguration), typeof(global::org.drools.builder.KnowledgeBuilderConfiguration_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.builder.KnowledgeBuilderConfiguration), typeof(global::org.drools.builder.KnowledgeBuilderConfiguration_))]
    internal sealed partial class @__KnowledgeBuilderConfiguration : global::java.lang.Object, global::org.drools.builder.KnowledgeBuilderConfiguration {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _setProperty0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getProperty1;
        
        internal static global::net.sf.jni4net.jni.MethodId _setOption2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getOption3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getOption4;
        
        private @__KnowledgeBuilderConfiguration(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.builder.@__KnowledgeBuilderConfiguration.staticClass = @__class;
            global::org.drools.builder.@__KnowledgeBuilderConfiguration._setProperty0 = @__env.GetMethodID(global::org.drools.builder.@__KnowledgeBuilderConfiguration.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
            global::org.drools.builder.@__KnowledgeBuilderConfiguration._getProperty1 = @__env.GetMethodID(global::org.drools.builder.@__KnowledgeBuilderConfiguration.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
            global::org.drools.builder.@__KnowledgeBuilderConfiguration._setOption2 = @__env.GetMethodID(global::org.drools.builder.@__KnowledgeBuilderConfiguration.staticClass, "setOption", "(Lorg/drools/builder/conf/KnowledgeBuilderOption;)V");
            global::org.drools.builder.@__KnowledgeBuilderConfiguration._getOption3 = @__env.GetMethodID(global::org.drools.builder.@__KnowledgeBuilderConfiguration.staticClass, "getOption", "(Ljava/lang/Class;Ljava/lang/String;)Lorg/drools/builder/conf/MultiValueKnowledge" +
                    "BuilderOption;");
            global::org.drools.builder.@__KnowledgeBuilderConfiguration._getOption4 = @__env.GetMethodID(global::org.drools.builder.@__KnowledgeBuilderConfiguration.staticClass, "getOption", "(Ljava/lang/Class;)Lorg/drools/builder/conf/SingleValueKnowledgeBuilderOption;");
        }
        
        public void setProperty(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::org.drools.builder.@__KnowledgeBuilderConfiguration._setProperty0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
            }
        }
        
        public global::java.lang.String getProperty(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.builder.@__KnowledgeBuilderConfiguration._getProperty1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        public void setOption(global::org.drools.builder.conf.KnowledgeBuilderOption par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.builder.@__KnowledgeBuilderConfiguration._setOption2, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.builder.conf.KnowledgeBuilderOption>(@__env, par0));
            }
        }
        
        public global::org.drools.builder.conf.MultiValueKnowledgeBuilderOption getOption(global::java.lang.Class par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.conf.MultiValueKnowledgeBuilderOption>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.builder.@__KnowledgeBuilderConfiguration._getOption3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1)));
            }
        }
        
        public global::org.drools.builder.conf.SingleValueKnowledgeBuilderOption getOption(global::java.lang.Class par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.conf.SingleValueKnowledgeBuilderOption>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.builder.@__KnowledgeBuilderConfiguration._getOption4, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__KnowledgeBuilderConfiguration);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setProperty", "setProperty0", "(Ljava/lang/String;Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getProperty", "getProperty1", "(Ljava/lang/String;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setOption", "setOption2", "(Lorg/drools/builder/conf/KnowledgeBuilderOption;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getOption", "getOption3", "(Ljava/lang/Class;Ljava/lang/String;)Lorg/drools/builder/conf/MultiValueKnowledge" +
                        "BuilderOption;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getOption", "getOption4", "(Ljava/lang/Class;)Lorg/drools/builder/conf/SingleValueKnowledgeBuilderOption;"));
            return methods;
        }
        
        private static void setProperty0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (Ljava/lang/String;Ljava/lang/String;)V
            // (Ljava/lang/String;Ljava/lang/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.builder.KnowledgeBuilderConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.KnowledgeBuilderConfiguration>(@__env, @__obj);
            ((global::org.drools.PropertiesConfiguration)(@__real)).setProperty(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0), global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par1));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getProperty1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/String;)Ljava/lang/String;
            // (Ljava/lang/String;)Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.builder.KnowledgeBuilderConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.KnowledgeBuilderConfiguration>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(((global::org.drools.PropertiesConfiguration)(@__real)).getProperty(global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void setOption2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/builder/conf/KnowledgeBuilderOption;)V
            // (Lorg/drools/builder/conf/KnowledgeBuilderOption;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.builder.KnowledgeBuilderConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.KnowledgeBuilderConfiguration>(@__env, @__obj);
            ((global::org.drools.builder.conf.KnowledgeBuilderOptionsConfiguration)(@__real)).setOption(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.conf.KnowledgeBuilderOption>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getOption3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (Ljava/lang/Class;Ljava/lang/String;)Lorg/drools/builder/conf/MultiValueKnowledgeBuilderOption;
            // (Ljava/lang/Class;Ljava/lang/String;)Lorg/drools/builder/conf/MultiValueKnowledgeBuilderOption;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.builder.KnowledgeBuilderConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.KnowledgeBuilderConfiguration>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.builder.conf.MultiValueKnowledgeBuilderOption>(@__env, ((global::org.drools.builder.conf.KnowledgeBuilderOptionsConfiguration)(@__real)).getOption(global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, par0), global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par1)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getOption4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Class;)Lorg/drools/builder/conf/SingleValueKnowledgeBuilderOption;
            // (Ljava/lang/Class;)Lorg/drools/builder/conf/SingleValueKnowledgeBuilderOption;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.builder.KnowledgeBuilderConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.builder.KnowledgeBuilderConfiguration>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.builder.conf.SingleValueKnowledgeBuilderOption>(@__env, ((global::org.drools.builder.conf.KnowledgeBuilderOptionsConfiguration)(@__real)).getOption(global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.builder.@__KnowledgeBuilderConfiguration(@__env);
            }
        }
    }
    #endregion
}