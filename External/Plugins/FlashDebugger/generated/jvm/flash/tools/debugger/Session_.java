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
public final class Session_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return flash.tools.debugger.Session_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        flash.tools.debugger.Session_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __Session extends system.Object implements flash.tools.debugger.Session {
    
    protected __Session(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(J)Lflash/tools/debugger/Value;")
    public native flash.tools.debugger.Value getValue(long par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void resume();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void suspend();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;I)V")
    public native void setPreference(java.lang.String par0, int par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;)I")
    public native int getPreference(java.lang.String par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getURI();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/Object;")
    public native java.lang.Process getLaunchProcess();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isConnected();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean bind();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void unbind();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void terminate();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isSuspended();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int suspendReason();
    
    @net.sf.jni4net.attributes.ClrMethod("()[Lflash/tools/debugger/Frame;")
    public native flash.tools.debugger.Frame[] getFrames();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void stepInto();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void stepOut();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void stepOver();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void stepContinue();
    
    @net.sf.jni4net.attributes.ClrMethod("()[Lflash/tools/debugger/SwfInfo;")
    public native flash.tools.debugger.SwfInfo[] getSwfs();
    
    @net.sf.jni4net.attributes.ClrMethod("()[Lflash/tools/debugger/Location;")
    public native flash.tools.debugger.Location[] getBreakpointList();
    
    @net.sf.jni4net.attributes.ClrMethod("(II)Lflash/tools/debugger/Location;")
    public native flash.tools.debugger.Location setBreakpoint(int par0, int par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/Location;)Lflash/tools/debugger/Location;")
    public native flash.tools.debugger.Location clearBreakpoint(flash.tools.debugger.Location par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()[Ljava/lang/Object;")
    public native flash.tools.debugger.Watch[] getWatchList();
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/Value;Ljava/lang/String;I)Ljava/lang/Object;")
    public native flash.tools.debugger.Watch setWatch(flash.tools.debugger.Value par0, java.lang.String par1, int par2);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Ljava/lang/Object;")
    public native flash.tools.debugger.Watch setWatch(flash.tools.debugger.Watch par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)Ljava/lang/Object;")
    public native flash.tools.debugger.Watch clearWatch(flash.tools.debugger.Watch par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()[Lflash/tools/debugger/Variable;")
    public native flash.tools.debugger.Variable[] getVariableList();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;)Lflash/tools/debugger/Value;")
    public native flash.tools.debugger.Value getGlobal(java.lang.String par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void waitForEvent();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getEventCount();
    
    @net.sf.jni4net.attributes.ClrMethod("()Lflash/tools/debugger/events/DebugEvent;")
    public native flash.tools.debugger.events.DebugEvent nextEvent();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/Object;")
    public native flash.tools.debugger.SourceLocator getSourceLocator();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)V")
    public native void setSourceLocator(flash.tools.debugger.SourceLocator par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;[Lflash/tools/debugger/Value;)Lflash/tools/debugger/Value;")
    public native flash.tools.debugger.Value callConstructor(java.lang.String par0, flash.tools.debugger.Value[] par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/Value;Ljava/lang/String;[Lflash/tools/debugger/Value;)Lflash/tools/debugger/Value;")
    public native flash.tools.debugger.Value callFunction(flash.tools.debugger.Value par0, java.lang.String par1, flash.tools.debugger.Value[] par2);
    
    @net.sf.jni4net.attributes.ClrMethod("(Z)V")
    public native void breakOnCaughtExceptions(boolean par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/Value;Ljava/lang/String;)Z")
    public native boolean evalIs(flash.tools.debugger.Value par0, java.lang.String par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/Value;Lflash/tools/debugger/Value;)Z")
    public native boolean evalIs(flash.tools.debugger.Value par0, flash.tools.debugger.Value par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/Value;Lflash/tools/debugger/Value;)Z")
    public native boolean evalInstanceof(flash.tools.debugger.Value par0, flash.tools.debugger.Value par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/Value;Ljava/lang/String;)Z")
    public native boolean evalInstanceof(flash.tools.debugger.Value par0, java.lang.String par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/Value;Lflash/tools/debugger/Value;)Z")
    public native boolean evalIn(flash.tools.debugger.Value par0, flash.tools.debugger.Value par1);
    
    @net.sf.jni4net.attributes.ClrMethod("(Lflash/tools/debugger/Value;Lflash/tools/debugger/Value;)Lflash/tools/debugger/Value;")
    public native flash.tools.debugger.Value evalAs(flash.tools.debugger.Value par0, flash.tools.debugger.Value par1);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean supportsWatchpoints();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/Exception;")
    public native java.lang.Exception getDisconnectCause();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;)Z")
    public native boolean setExceptionBreakpoint(java.lang.String par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/String;)Z")
    public native boolean clearExceptionBreakpoint(java.lang.String par0);
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean supportsConcurrency();
    
    @net.sf.jni4net.attributes.ClrMethod("()[Lflash/tools/debugger/Isolate;")
    public native flash.tools.debugger.Isolate[] getWorkers();
    
    @net.sf.jni4net.attributes.ClrMethod("()[Lflash/tools/debugger/Isolate;")
    public native flash.tools.debugger.Isolate[] refreshWorkers();
    
    @net.sf.jni4net.attributes.ClrMethod("(I)Lflash/tools/debugger/IsolateSession;")
    public native flash.tools.debugger.IsolateSession getWorkerSession(int par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)V")
    public native void setLauncher(flash.tools.debugger.ILauncher par0);
}
//</generated-proxy>