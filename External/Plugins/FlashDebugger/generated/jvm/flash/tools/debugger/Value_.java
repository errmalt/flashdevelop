// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package flash.tools.debugger;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class Value_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return flash.tools.debugger.Value_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        flash.tools.debugger.Value_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __Value extends system.Object implements flash.tools.debugger.Value {
    
    protected __Value(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()J")
    public native long getId();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getType();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getTypeName();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getClassName();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getAttributes();
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/Session;)I")
    public native int getMemberCount(flash.tools.debugger.Session par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getIsolateId();
    
    @net.sf.jni4net.attributes.ClrMethod("(I)Z")
    public native boolean isAttributeSet(int par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/Object;")
    public native java.lang.Object getValueAsObject();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getValueAsString();
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;")
    public native flash.tools.debugger.Variable[] getMembers(flash.tools.debugger.Session par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/Session;Ljava/lang/String;)Lflash/tools/debugger/Variable;")
    public native flash.tools.debugger.Variable getMemberNamed(flash.tools.debugger.Session par0, java.lang.String par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)[Ljava/lang/String;")
    public native java.lang.String[] getClassHierarchy(boolean par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()[Lflash/tools/debugger/Variable;")
    public native flash.tools.debugger.Variable[] getPrivateInheritedMembers();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;)[Lflash/tools/debugger/Variable;")
    public native flash.tools.debugger.Variable[] getPrivateInheritedMemberNamed(java.lang.String par0);
}
//</generated-proxy>