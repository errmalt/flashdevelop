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
    public partial interface IProgress {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)V")]
        void setProgress(int par0, int par1);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class IProgress_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::flash.tools.debugger.@__IProgress.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::flash.tools.debugger.IProgress), typeof(global::flash.tools.debugger.IProgress_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::flash.tools.debugger.IProgress), typeof(global::flash.tools.debugger.IProgress_))]
    internal sealed partial class @__IProgress : global::java.lang.Object, global::flash.tools.debugger.IProgress {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _setProgress0;
        
        private @__IProgress(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::flash.tools.debugger.@__IProgress.staticClass = @__class;
            global::flash.tools.debugger.@__IProgress._setProgress0 = @__env.GetMethodID(global::flash.tools.debugger.@__IProgress.staticClass, "setProgress", "(II)V");
        }
        
        public void setProgress(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::flash.tools.debugger.@__IProgress._setProgress0, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IProgress);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setProgress", "setProgress0", "(II)V"));
            return methods;
        }
        
        private static void setProgress0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, int par0, int par1) {
            // (II)V
            // (II)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::flash.tools.debugger.IProgress @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::flash.tools.debugger.IProgress>(@__env, @__obj);
            @__real.setProgress(par0, par1);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::flash.tools.debugger.@__IProgress(@__env);
            }
        }
    }
    #endregion
}