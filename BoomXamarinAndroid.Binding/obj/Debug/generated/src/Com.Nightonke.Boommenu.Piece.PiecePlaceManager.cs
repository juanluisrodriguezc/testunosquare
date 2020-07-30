using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.Piece {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.Piece']/class[@name='PiecePlaceManager']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/Piece/PiecePlaceManager", DoNotGenerateAcw=true)]
	public partial class PiecePlaceManager : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/Piece/PiecePlaceManager", typeof (PiecePlaceManager));
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

		protected PiecePlaceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu.Piece']/class[@name='PiecePlaceManager']/constructor[@name='PiecePlaceManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PiecePlaceManager ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Piece']/class[@name='PiecePlaceManager']/method[@name='createPiece' and count(parameter)=2 and parameter[1][@type='com.nightonke.boommenu.BoomMenuButton'] and parameter[2][@type='com.nightonke.boommenu.BoomButtons.BoomButtonBuilder']]"
		[Register ("createPiece", "(Lcom/nightonke/boommenu/BoomMenuButton;Lcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;)Lcom/nightonke/boommenu/Piece/BoomPiece;", "")]
		public static unsafe global::Com.Nightonke.Boommenu.Piece.BoomPiece CreatePiece (global::Com.Nightonke.Boommenu.BoomMenuButton bmb, global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder builder)
		{
			const string __id = "createPiece.(Lcom/nightonke/boommenu/BoomMenuButton;Lcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;)Lcom/nightonke/boommenu/Piece/BoomPiece;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bmb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bmb).Handle);
				__args [1] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Piece.BoomPiece> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Piece']/class[@name='PiecePlaceManager']/method[@name='getDotPositions' and count(parameter)=2 and parameter[1][@type='com.nightonke.boommenu.BoomMenuButton'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("getDotPositions", "(Lcom/nightonke/boommenu/BoomMenuButton;Landroid/graphics/Point;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Android.Graphics.RectF> GetDotPositions (global::Com.Nightonke.Boommenu.BoomMenuButton bmb, global::Android.Graphics.Point parentSize)
		{
			const string __id = "getDotPositions.(Lcom/nightonke/boommenu/BoomMenuButton;Landroid/graphics/Point;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bmb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bmb).Handle);
				__args [1] = new JniArgumentValue ((parentSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parentSize).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Android.Graphics.RectF>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Piece']/class[@name='PiecePlaceManager']/method[@name='getHamPositions' and count(parameter)=2 and parameter[1][@type='com.nightonke.boommenu.BoomMenuButton'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("getHamPositions", "(Lcom/nightonke/boommenu/BoomMenuButton;Landroid/graphics/Point;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Android.Graphics.RectF> GetHamPositions (global::Com.Nightonke.Boommenu.BoomMenuButton bmb, global::Android.Graphics.Point parentSize)
		{
			const string __id = "getHamPositions.(Lcom/nightonke/boommenu/BoomMenuButton;Landroid/graphics/Point;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bmb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bmb).Handle);
				__args [1] = new JniArgumentValue ((parentSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parentSize).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Android.Graphics.RectF>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Piece']/class[@name='PiecePlaceManager']/method[@name='getShareDotPositions' and count(parameter)=3 and parameter[1][@type='com.nightonke.boommenu.BoomMenuButton'] and parameter[2][@type='android.graphics.Point'] and parameter[3][@type='int']]"
		[Register ("getShareDotPositions", "(Lcom/nightonke/boommenu/BoomMenuButton;Landroid/graphics/Point;I)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Android.Graphics.RectF> GetShareDotPositions (global::Com.Nightonke.Boommenu.BoomMenuButton bmb, global::Android.Graphics.Point parentSize, int n)
		{
			const string __id = "getShareDotPositions.(Lcom/nightonke/boommenu/BoomMenuButton;Landroid/graphics/Point;I)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((bmb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bmb).Handle);
				__args [1] = new JniArgumentValue ((parentSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parentSize).Handle);
				__args [2] = new JniArgumentValue (n);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Android.Graphics.RectF>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
