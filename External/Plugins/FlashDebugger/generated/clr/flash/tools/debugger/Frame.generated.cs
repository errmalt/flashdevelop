//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5472
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace flash.tools.debugger {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Frame {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lflash/tools/debugger/Location;")]
        global::flash.tools.debugger.Location getLocation();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int getIsolateId();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lflash/tools/debugger/Session;)Lflash/tools/debugger/Variable;")]
        global::flash.tools.debugger.Variable getThis(global::flash.tools.debugger.Session par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;")]
        flash.tools.debugger.Variable[] getArguments(global::flash.tools.debugger.Session par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;")]
        flash.tools.debugger.Variable[] getLocals(global::flash.tools.debugger.Session par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getCallSignature();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;")]
        flash.tools.debugger.Variable[] getScopeChain(global::flash.tools.debugger.Session par0);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Frame_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::flash.tools.debugger.@__Frame.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::flash.tools.debugger.Frame), typeof(global::flash.tools.debugger.Frame_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::flash.tools.debugger.Frame), typeof(global::flash.tools.debugger.Frame_))]
    internal sealed partial class @__Frame : global::java.lang.Object, global::flash.tools.debugger.Frame {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLocation0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getIsolateId1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getThis2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getArguments3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLocals4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCallSignature5;
        
        internal static global::net.sf.jni4net.jni.MethodId _getScopeChain6;
        
        private @__Frame(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::flash.tools.debugger.@__Frame.staticClass = @__class;
            global::flash.tools.debugger.@__Frame._getLocation0 = @__env.GetMethodID(global::flash.tools.debugger.@__Frame.staticClass, "getLocation", "()Lflash/tools/debugger/Location;");
            global::flash.tools.debugger.@__Frame._getIsolateId1 = @__env.GetMethodID(global::flash.tools.debugger.@__Frame.staticClass, "getIsolateId", "()I");
            global::flash.tools.debugger.@__Frame._getThis2 = @__env.GetMethodID(global::flash.tools.debugger.@__Frame.staticClass, "getThis", "(Lflash/tools/debugger/Session;)Lflash/tools/debugger/Variable;");
            global::flash.tools.debugger.@__Frame._getArguments3 = @__env.GetMethodID(global::flash.tools.debugger.@__Frame.staticClass, "getArguments", "(Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;");
            global::flash.tools.debugger.@__Frame._getLocals4 = @__env.GetMethodID(global::flash.tools.debugger.@__Frame.staticClass, "getLocals", "(Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;");
            global::flash.tools.debugger.@__Frame._getCallSignature5 = @__env.GetMethodID(global::flash.tools.debugger.@__Frame.staticClass, "getCallSignature", "()Ljava/lang/String;");
            global::flash.tools.debugger.@__Frame._getScopeChain6 = @__env.GetMethodID(global::flash.tools.debugger.@__Frame.staticClass, "getScopeChain", "(Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;");
        }
        
        public global::flash.tools.debugger.Location getLocation() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::flash.tools.debugger.Location>(@__env, @__env.CallObjectMethodPtr(this, global::flash.tools.debugger.@__Frame._getLocation0));
            }
        }
        
        public int getIsolateId() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::flash.tools.debugger.@__Frame._getIsolateId1)));
            }
        }
        
        public global::flash.tools.debugger.Variable getThis(global::flash.tools.debugger.Session par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::flash.tools.debugger.Variable>(@__env, @__env.CallObjectMethodPtr(this, global::flash.tools.debugger.@__Frame._getThis2, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::flash.tools.debugger.Session>(@__env, par0)));
            }
        }
        
        public flash.tools.debugger.Variable[] getArguments(global::flash.tools.debugger.Session par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<flash.tools.debugger.Variable[], global::flash.tools.debugger.Variable>(@__env, @__env.CallObjectMethodPtr(this, global::flash.tools.debugger.@__Frame._getArguments3, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::flash.tools.debugger.Session>(@__env, par0)));
            }
        }
        
        public flash.tools.debugger.Variable[] getLocals(global::flash.tools.debugger.Session par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<flash.tools.debugger.Variable[], global::flash.tools.debugger.Variable>(@__env, @__env.CallObjectMethodPtr(this, global::flash.tools.debugger.@__Frame._getLocals4, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::flash.tools.debugger.Session>(@__env, par0)));
            }
        }
        
        public global::java.lang.String getCallSignature() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::flash.tools.debugger.@__Frame._getCallSignature5));
            }
        }
        
        public flash.tools.debugger.Variable[] getScopeChain(global::flash.tools.debugger.Session par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<flash.tools.debugger.Variable[], global::flash.tools.debugger.Variable>(@__env, @__env.CallObjectMethodPtr(this, global::flash.tools.debugger.@__Frame._getScopeChain6, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::flash.tools.debugger.Session>(@__env, par0)));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Frame);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getLocation", "getLocation0", "()Lflash/tools/debugger/Location;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getIsolateId", "getIsolateId1", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getThis", "getThis2", "(Lflash/tools/debugger/Session;)Lflash/tools/debugger/Variable;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getArguments", "getArguments3", "(Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getLocals", "getLocals4", "(Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCallSignature", "getCallSignature5", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getScopeChain", "getScopeChain6", "(Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getLocation0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lflash/tools/debugger/Location;
            // ()Lflash/tools/debugger/Location;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::flash.tools.debugger.Frame @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::flash.tools.debugger.Frame>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::flash.tools.debugger.Location>(@__env, @__real.getLocation());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static int getIsolateId1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            int @__return = default(int);
            try {
            global::flash.tools.debugger.Frame @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::flash.tools.debugger.Frame>(@__env, @__obj);
            @__return = ((int)(@__real.getIsolateId()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getThis2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lflash/tools/debugger/Session;)Lflash/tools/debugger/Variable;
            // (Lflash/tools/debugger/Session;)Lflash/tools/debugger/Variable;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::flash.tools.debugger.Frame @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::flash.tools.debugger.Frame>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::flash.tools.debugger.Variable>(@__env, @__real.getThis(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::flash.tools.debugger.Session>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getArguments3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;
            // (Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::flash.tools.debugger.Frame @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::flash.tools.debugger.Frame>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<flash.tools.debugger.Variable[], global::flash.tools.debugger.Variable>(@__env, @__real.getArguments(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::flash.tools.debugger.Session>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getLocals4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;
            // (Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::flash.tools.debugger.Frame @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::flash.tools.debugger.Frame>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<flash.tools.debugger.Variable[], global::flash.tools.debugger.Variable>(@__env, @__real.getLocals(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::flash.tools.debugger.Session>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getCallSignature5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::flash.tools.debugger.Frame @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::flash.tools.debugger.Frame>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getCallSignature());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getScopeChain6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;
            // (Lflash/tools/debugger/Session;)[Lflash/tools/debugger/Variable;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::flash.tools.debugger.Frame @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::flash.tools.debugger.Frame>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<flash.tools.debugger.Variable[], global::flash.tools.debugger.Variable>(@__env, @__real.getScopeChain(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::flash.tools.debugger.Session>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::flash.tools.debugger.@__Frame(@__env);
            }
        }
    }
    #endregion
}