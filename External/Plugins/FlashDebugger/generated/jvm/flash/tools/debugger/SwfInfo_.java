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
public final class SwfInfo_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return flash.tools.debugger.SwfInfo_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        flash.tools.debugger.SwfInfo_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __SwfInfo extends system.Object implements flash.tools.debugger.SwfInfo {
    
    protected __SwfInfo(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getPath();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getUrl();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getSwfSize();
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/Session;)I")
    public native int getSwdSize(flash.tools.debugger.Session par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isUnloaded();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isProcessingComplete();
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/Session;)I")
    public native int getSourceCount(flash.tools.debugger.Session par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/Session;)[Lflash/tools/debugger/SourceFile;")
    public native flash.tools.debugger.SourceFile[] getSourceList(flash.tools.debugger.Session par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/SourceFile;)Z")
    public native boolean containsSource(flash.tools.debugger.SourceFile par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getIsolateId();
}
//</generated-proxy>