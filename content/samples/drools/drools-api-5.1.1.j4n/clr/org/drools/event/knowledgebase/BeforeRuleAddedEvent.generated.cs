//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.@event.knowledgebase {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface BeforeRuleAddedEvent : global::org.drools.@event.knowledgebase.KnowledgeBaseEvent {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/drools/definition/rule/Rule;")]
        global::org.drools.definition.rule.Rule getRule();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class BeforeRuleAddedEvent_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.@event.knowledgebase.@__BeforeRuleAddedEvent.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.@event.knowledgebase.BeforeRuleAddedEvent), typeof(global::org.drools.@event.knowledgebase.BeforeRuleAddedEvent_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.@event.knowledgebase.BeforeRuleAddedEvent), typeof(global::org.drools.@event.knowledgebase.BeforeRuleAddedEvent_))]
    internal sealed partial class @__BeforeRuleAddedEvent : global::java.lang.Object, global::org.drools.@event.knowledgebase.BeforeRuleAddedEvent {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getKnowledgeBase0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getRule1;
        
        private @__BeforeRuleAddedEvent(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.@event.knowledgebase.@__BeforeRuleAddedEvent.staticClass = @__class;
            global::org.drools.@event.knowledgebase.@__BeforeRuleAddedEvent._getKnowledgeBase0 = @__env.GetMethodID(global::org.drools.@event.knowledgebase.@__BeforeRuleAddedEvent.staticClass, "getKnowledgeBase", "()Lorg/drools/KnowledgeBase;");
            global::org.drools.@event.knowledgebase.@__BeforeRuleAddedEvent._getRule1 = @__env.GetMethodID(global::org.drools.@event.knowledgebase.@__BeforeRuleAddedEvent.staticClass, "getRule", "()Lorg/drools/definition/rule/Rule;");
        }
        
        public global::org.drools.KnowledgeBase getKnowledgeBase() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.KnowledgeBase>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.knowledgebase.@__BeforeRuleAddedEvent._getKnowledgeBase0));
            }
        }
        
        public global::org.drools.definition.rule.Rule getRule() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.definition.rule.Rule>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.knowledgebase.@__BeforeRuleAddedEvent._getRule1));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__BeforeRuleAddedEvent);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getKnowledgeBase", "getKnowledgeBase0", "()Lorg/drools/KnowledgeBase;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getRule", "getRule1", "()Lorg/drools/definition/rule/Rule;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getKnowledgeBase0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/KnowledgeBase;
            // ()Lorg/drools/KnowledgeBase;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.knowledgebase.BeforeRuleAddedEvent @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.knowledgebase.BeforeRuleAddedEvent>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.KnowledgeBase>(@__env, ((global::org.drools.@event.knowledgebase.KnowledgeBaseEvent)(@__real)).getKnowledgeBase());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getRule1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/definition/rule/Rule;
            // ()Lorg/drools/definition/rule/Rule;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.knowledgebase.BeforeRuleAddedEvent @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.knowledgebase.BeforeRuleAddedEvent>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.definition.rule.Rule>(@__env, @__real.getRule());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.@event.knowledgebase.@__BeforeRuleAddedEvent(@__env);
            }
        }
    }
    #endregion
}
