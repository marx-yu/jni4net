// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package org.drools.runtime.rule;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class RuleContext_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return org.drools.runtime.rule.RuleContext_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        org.drools.runtime.rule.RuleContext_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __RuleContext extends system.Object implements org.drools.runtime.rule.RuleContext {
    
    protected __RuleContext(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()Lorg/drools/runtime/KnowledgeRuntime;")
    public native org.drools.runtime.KnowledgeRuntime getKnowledgeRuntime();
    
    @net.sf.jni4net.attributes.ClrMethod("()Lorg/drools/definition/rule/Rule;")
    public native org.drools.definition.rule.Rule getRule();
    
    @net.sf.jni4net.attributes.ClrMethod("()Lorg/drools/runtime/rule/Activation;")
    public native org.drools.runtime.rule.Activation getActivation();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)V")
    public native void insertLogical(java.lang.Object par0);
}
//</generated-proxy>
