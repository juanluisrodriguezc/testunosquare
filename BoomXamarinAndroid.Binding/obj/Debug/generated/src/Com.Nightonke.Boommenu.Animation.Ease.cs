using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='Ease']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/Animation/Ease", DoNotGenerateAcw=true)]
	public partial class Ease : global::Java.Lang.Object, global::Android.Animation.ITimeInterpolator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/Animation/Ease", typeof (Ease));
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

		protected Ease (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='Ease']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.Animation.EaseEnum']]"
		[Register ("getInstance", "(Lcom/nightonke/boommenu/Animation/EaseEnum;)Lcom/nightonke/boommenu/Animation/Ease;", "")]
		public static unsafe global::Com.Nightonke.Boommenu.Animation.Ease GetInstance (global::Com.Nightonke.Boommenu.Animation.EaseEnum easeEnum)
		{
			const string __id = "getInstance.(Lcom/nightonke/boommenu/Animation/EaseEnum;)Lcom/nightonke/boommenu/Animation/Ease;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((easeEnum == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easeEnum).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.Ease> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getInterpolation_F;
#pragma warning disable 0169
		static Delegate GetGetInterpolation_FHandler ()
		{
			if (cb_getInterpolation_F == null)
				cb_getInterpolation_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_GetInterpolation_F);
			return cb_getInterpolation_F;
		}

		static float n_GetInterpolation_F (IntPtr jnienv, IntPtr native__this, float offset)
		{
			global::Com.Nightonke.Boommenu.Animation.Ease __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.Ease> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetInterpolation (offset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='Ease']/method[@name='getInterpolation' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getInterpolation", "(F)F", "GetGetInterpolation_FHandler")]
		public virtual unsafe float GetInterpolation (float offset)
		{
			const string __id = "getInterpolation.(F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
