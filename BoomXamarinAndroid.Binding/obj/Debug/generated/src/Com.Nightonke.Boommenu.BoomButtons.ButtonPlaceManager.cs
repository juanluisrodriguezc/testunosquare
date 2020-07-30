using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.BoomButtons {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='ButtonPlaceManager']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomButtons/ButtonPlaceManager", DoNotGenerateAcw=true)]
	public partial class ButtonPlaceManager : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/BoomButtons/ButtonPlaceManager", typeof (ButtonPlaceManager));
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

		protected ButtonPlaceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='ButtonPlaceManager']/constructor[@name='ButtonPlaceManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ButtonPlaceManager ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='ButtonPlaceManager']/method[@name='getPositions' and count(parameter)=5 and parameter[1][@type='android.graphics.Point'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='com.nightonke.boommenu.BoomMenuButton']]"
		[Register ("getPositions", "(Landroid/graphics/Point;FFILcom/nightonke/boommenu/BoomMenuButton;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Android.Graphics.PointF> GetPositions (global::Android.Graphics.Point parentSize, float w, float h, int buttonNumber, global::Com.Nightonke.Boommenu.BoomMenuButton bmb)
		{
			const string __id = "getPositions.(Landroid/graphics/Point;FFILcom/nightonke/boommenu/BoomMenuButton;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((parentSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parentSize).Handle);
				__args [1] = new JniArgumentValue (w);
				__args [2] = new JniArgumentValue (h);
				__args [3] = new JniArgumentValue (buttonNumber);
				__args [4] = new JniArgumentValue ((bmb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bmb).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='ButtonPlaceManager']/method[@name='getPositions' and count(parameter)=4 and parameter[1][@type='android.graphics.Point'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='com.nightonke.boommenu.BoomMenuButton']]"
		[Register ("getPositions", "(Landroid/graphics/Point;FILcom/nightonke/boommenu/BoomMenuButton;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Android.Graphics.PointF> GetPositions (global::Android.Graphics.Point parentSize, float r, int buttonNumber, global::Com.Nightonke.Boommenu.BoomMenuButton bmb)
		{
			const string __id = "getPositions.(Landroid/graphics/Point;FILcom/nightonke/boommenu/BoomMenuButton;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((parentSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parentSize).Handle);
				__args [1] = new JniArgumentValue (r);
				__args [2] = new JniArgumentValue (buttonNumber);
				__args [3] = new JniArgumentValue ((bmb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bmb).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
