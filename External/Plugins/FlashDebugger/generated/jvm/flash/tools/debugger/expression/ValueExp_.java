// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package flash.tools.debugger.expression;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class ValueExp_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return flash.tools.debugger.expression.ValueExp_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        flash.tools.debugger.expression.ValueExp_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __ValueExp extends system.Object implements flash.tools.debugger.expression.ValueExp {
    
    protected __ValueExp(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/expression/Context;)Ljava/lang/Object;")
    public native java.lang.Object evaluate(flash.tools.debugger.expression.Context par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean containsAssignment();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isLookupMembers();
}
//</generated-proxy>