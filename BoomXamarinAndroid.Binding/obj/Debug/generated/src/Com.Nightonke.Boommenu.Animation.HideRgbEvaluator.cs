using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='HideRgbEvaluator']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/Animation/HideRgbEvaluator", DoNotGenerateAcw=true)]
	public partial class HideRgbEvaluator : global::Java.Lang.Object, global::Android.Animation.ITypeEvaluator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/Animation/HideRgbEvaluator", typeof (HideRgbEvaluator));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected HideRgbEvaluator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='HideRgbEvaluator']/constructor[@name='HideRgbEvaluator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HideRgbEvaluator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe global::Com.Nightonke.Boommenu.Animation.HideRgbEvaluator Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='HideRgbEvaluator']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/nightonke/boommenu/Animation/HideRgbEvaluator;", "")]
			get {
				const string __id = "getInstance.()Lcom/nightonke/boommenu/Animation/HideRgbEvaluator;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.HideRgbEvaluator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_evaluate_FLjava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEvaluate_FLjava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_evaluate_FLjava_lang_Object_Ljava_lang_Object_ == null)
				cb_evaluate_FLjava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr, IntPtr, IntPtr>) n_Evaluate_FLjava_lang_Object_Ljava_lang_Object_);
			return cb_evaluate_FLjava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_Evaluate_FLjava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, float fraction, IntPtr native_startValue, IntPtr native_endValue)
		{
			global::Com.Nightonke.Boommenu.Animation.HideRgbEvaluator __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.HideRgbEvaluator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object startValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_startValue, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object endValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_endValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Evaluate (fraction, startValue, endValue));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='HideRgbEvaluator']/method[@name='evaluate' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.Object']]"
		[Register ("evaluate", "(FLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetEvaluate_FLjava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Evaluate (float fraction, global::Java.Lang.Object startValue, global::Java.Lang.Object endValue)
		{
			const string __id = "evaluate.(FLjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (fraction);
				__args [1] = new JniArgumentValue ((startValue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) startValue).Handle);
				__args [2] = new JniArgumentValue ((endValue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) endValue).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
