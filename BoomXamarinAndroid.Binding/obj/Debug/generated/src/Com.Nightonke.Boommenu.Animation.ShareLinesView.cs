using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='ShareLinesView']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/Animation/ShareLinesView", DoNotGenerateAcw=true)]
	public partial class ShareLinesView : global::Android.Views.View {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/Animation/ShareLinesView", typeof (ShareLinesView));
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

		protected ShareLinesView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='ShareLinesView']/constructor[@name='ShareLinesView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ShareLinesView (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_place_IIII;
#pragma warning disable 0169
		static Delegate GetPlace_IIIIHandler ()
		{
			if (cb_place_IIII == null)
				cb_place_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_Place_IIII);
			return cb_place_IIII;
		}

		static void n_Place_IIII (IntPtr jnienv, IntPtr native__this, int left, int top, int width, int height)
		{
			global::Com.Nightonke.Boommenu.Animation.ShareLinesView __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.ShareLinesView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Place (left, top, width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='ShareLinesView']/method[@name='place' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("place", "(IIII)V", "GetPlace_IIIIHandler")]
		public virtual unsafe void Place (int left, int top, int width, int height)
		{
			const string __id = "place.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (width);
				__args [3] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setData_Ljava_util_ArrayList_Lcom_nightonke_boommenu_BoomMenuButton_;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_util_ArrayList_Lcom_nightonke_boommenu_BoomMenuButton_Handler ()
		{
			if (cb_setData_Ljava_util_ArrayList_Lcom_nightonke_boommenu_BoomMenuButton_ == null)
				cb_setData_Ljava_util_ArrayList_Lcom_nightonke_boommenu_BoomMenuButton_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_util_ArrayList_Lcom_nightonke_boommenu_BoomMenuButton_);
			return cb_setData_Ljava_util_ArrayList_Lcom_nightonke_boommenu_BoomMenuButton_;
		}

		static void n_SetData_Ljava_util_ArrayList_Lcom_nightonke_boommenu_BoomMenuButton_ (IntPtr jnienv, IntPtr native__this, IntPtr native_piecePositions, IntPtr native_bmb)
		{
			global::Com.Nightonke.Boommenu.Animation.ShareLinesView __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.ShareLinesView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var piecePositions = global::Android.Runtime.JavaList<global::Android.Graphics.RectF>.FromJniHandle (native_piecePositions, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.BoomMenuButton bmb = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (native_bmb, JniHandleOwnership.DoNotTransfer);
			__this.SetData (piecePositions, bmb);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='ShareLinesView']/method[@name='setData' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList&lt;android.graphics.RectF&gt;'] and parameter[2][@type='com.nightonke.boommenu.BoomMenuButton']]"
		[Register ("setData", "(Ljava/util/ArrayList;Lcom/nightonke/boommenu/BoomMenuButton;)V", "GetSetData_Ljava_util_ArrayList_Lcom_nightonke_boommenu_BoomMenuButton_Handler")]
		public virtual unsafe void SetData (global::System.Collections.Generic.IList<global::Android.Graphics.RectF> piecePositions, global::Com.Nightonke.Boommenu.BoomMenuButton bmb)
		{
			const string __id = "setData.(Ljava/util/ArrayList;Lcom/nightonke/boommenu/BoomMenuButton;)V";
			IntPtr native_piecePositions = global::Android.Runtime.JavaList<global::Android.Graphics.RectF>.ToLocalJniHandle (piecePositions);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_piecePositions);
				__args [1] = new JniArgumentValue ((bmb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bmb).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_piecePositions);
			}
		}

		static Delegate cb_setLine1Color_I;
#pragma warning disable 0169
		static Delegate GetSetLine1Color_IHandler ()
		{
			if (cb_setLine1Color_I == null)
				cb_setLine1Color_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLine1Color_I);
			return cb_setLine1Color_I;
		}

		static void n_SetLine1Color_I (IntPtr jnienv, IntPtr native__this, int line1Color)
		{
			global::Com.Nightonke.Boommenu.Animation.ShareLinesView __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.ShareLinesView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLine1Color (line1Color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='ShareLinesView']/method[@name='setLine1Color' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLine1Color", "(I)V", "GetSetLine1Color_IHandler")]
		public virtual unsafe void SetLine1Color (int line1Color)
		{
			const string __id = "setLine1Color.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (line1Color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLine2Color_I;
#pragma warning disable 0169
		static Delegate GetSetLine2Color_IHandler ()
		{
			if (cb_setLine2Color_I == null)
				cb_setLine2Color_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLine2Color_I);
			return cb_setLine2Color_I;
		}

		static void n_SetLine2Color_I (IntPtr jnienv, IntPtr native__this, int line2Color)
		{
			global::Com.Nightonke.Boommenu.Animation.ShareLinesView __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.ShareLinesView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLine2Color (line2Color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='ShareLinesView']/method[@name='setLine2Color' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLine2Color", "(I)V", "GetSetLine2Color_IHandler")]
		public virtual unsafe void SetLine2Color (int line2Color)
		{
			const string __id = "setLine2Color.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (line2Color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetLineWidth_FHandler ()
		{
			if (cb_setLineWidth_F == null)
				cb_setLineWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLineWidth_F);
			return cb_setLineWidth_F;
		}

		static void n_SetLineWidth_F (IntPtr jnienv, IntPtr native__this, float lineWidth)
		{
			global::Com.Nightonke.Boommenu.Animation.ShareLinesView __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.ShareLinesView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLineWidth (lineWidth);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='ShareLinesView']/method[@name='setLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setLineWidth", "(F)V", "GetSetLineWidth_FHandler")]
		public virtual unsafe void SetLineWidth (float lineWidth)
		{
			const string __id = "setLineWidth.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (lineWidth);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
