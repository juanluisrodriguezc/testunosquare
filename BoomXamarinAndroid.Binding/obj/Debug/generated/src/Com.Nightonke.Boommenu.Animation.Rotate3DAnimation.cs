using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='Rotate3DAnimation']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/Animation/Rotate3DAnimation", DoNotGenerateAcw=true)]
	public partial class Rotate3DAnimation : global::Android.Views.Animations.Animation {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/Animation/Rotate3DAnimation", typeof (Rotate3DAnimation));
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

		protected Rotate3DAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='Rotate3DAnimation']/constructor[@name='Rotate3DAnimation' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Float&gt;'] and parameter[4][@type='java.util.ArrayList&lt;java.lang.Float&gt;']]"
		[Register (".ctor", "(FFLjava/util/ArrayList;Ljava/util/ArrayList;)V", "")]
		public unsafe Rotate3DAnimation (float centerX, float centerY, global::System.Collections.Generic.IList<global::Java.Lang.Float> xs, global::System.Collections.Generic.IList<global::Java.Lang.Float> ys)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFLjava/util/ArrayList;Ljava/util/ArrayList;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_xs = global::Android.Runtime.JavaList<global::Java.Lang.Float>.ToLocalJniHandle (xs);
			IntPtr native_ys = global::Android.Runtime.JavaList<global::Java.Lang.Float>.ToLocalJniHandle (ys);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (centerX);
				__args [1] = new JniArgumentValue (centerY);
				__args [2] = new JniArgumentValue (native_xs);
				__args [3] = new JniArgumentValue (native_ys);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_xs);
				JNIEnv.DeleteLocalRef (native_ys);
			}
		}

		static Delegate cb_set_Landroid_view_View_FF;
#pragma warning disable 0169
		static Delegate GetSet_Landroid_view_View_FFHandler ()
		{
			if (cb_set_Landroid_view_View_FF == null)
				cb_set_Landroid_view_View_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_Set_Landroid_view_View_FF);
			return cb_set_Landroid_view_View_FF;
		}

		static void n_Set_Landroid_view_View_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_view, float startX, float startY)
		{
			global::Com.Nightonke.Boommenu.Animation.Rotate3DAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.Rotate3DAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.Set (view, startX, startY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='Rotate3DAnimation']/method[@name='set' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("set", "(Landroid/view/View;FF)V", "GetSet_Landroid_view_View_FFHandler")]
		public virtual unsafe void Set (global::Android.Views.View view, float startX, float startY)
		{
			const string __id = "set.(Landroid/view/View;FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (startX);
				__args [2] = new JniArgumentValue (startY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
