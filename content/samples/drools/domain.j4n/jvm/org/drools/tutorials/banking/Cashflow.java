// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package org.drools.tutorials.banking;

@net.sf.jni4net.attributes.ClrType
public class Cashflow extends system.Object {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected Cashflow(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("()V")
    public Cashflow() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        org.drools.tutorials.banking.Cashflow.__ctorCashflow0(this);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/String;D)V")
    public Cashflow(java.lang.String date, double amount) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        org.drools.tutorials.banking.Cashflow.__ctorCashflow1(this, date, amount);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(LSystem/DateTime;D)V")
    public Cashflow(system.DateTime date, double amount) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        org.drools.tutorials.banking.Cashflow.__ctorCashflow2(this, date, amount);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    private native static void __ctorCashflow0(net.sf.jni4net.inj.IClrProxy thiz);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;D)V")
    private native static void __ctorCashflow1(net.sf.jni4net.inj.IClrProxy thiz, java.lang.String date, double amount);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lsystem/DateTime;D)V")
    private native static void __ctorCashflow2(net.sf.jni4net.inj.IClrProxy thiz, system.DateTime date, double amount);
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/DateTime;")
    public native system.DateTime getDate();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/DateTime;)V")
    public native void setDate(system.DateTime value);
    
    @net.sf.jni4net.attributes.ClrMethod("()D")
    public native double getAmount();
    
    @net.sf.jni4net.attributes.ClrMethod("(D)V")
    public native void setAmount(double value);
    
    public static system.Type typeof() {
        return org.drools.tutorials.banking.Cashflow.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        org.drools.tutorials.banking.Cashflow.staticType = staticType;
    }
    //</generated-proxy>
}
