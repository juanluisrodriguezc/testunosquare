using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.Piece {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.Piece']/class[@name='BoomPiece']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/Piece/BoomPiece", DoNotGenerateAcw=true)]
	public abstract partial class BoomPiece : global::Android.Views.View {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/Piece/BoomPiece", typeof (BoomPiece));
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

		protected BoomPiece (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu.Piece']/class[@name='BoomPiece']/constructor[@name='BoomPiece' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BoomPiece (global::Android.Content.Context context)
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

		static Delegate cb_init_IF;
#pragma warning disable 0169
		static Delegate GetInit_IFHandler ()
		{
			if (cb_init_IF == null)
				cb_init_IF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float>) n_Init_IF);
			return cb_init_IF;
		}

		static void n_Init_IF (IntPtr jnienv, IntPtr native__this, int p0, float p1)
		{
			global::Com.Nightonke.Boommenu.Piece.BoomPiece __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Piece.BoomPiece> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Piece']/class[@name='BoomPiece']/method[@name='init' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("init", "(IF)V", "GetInit_IFHandler")]
		public abstract void Init (int p0, float p1);

		static Delegate cb_place_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetPlace_Landroid_graphics_RectF_Handler ()
		{
			if (cb_place_Landroid_graphics_RectF_ == null)
				cb_place_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Place_Landroid_graphics_RectF_);
			return cb_place_Landroid_graphics_RectF_;
		}

		static void n_Place_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rectF)
		{
			global::Com.Nightonke.Boommenu.Piece.BoomPiece __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Piece.BoomPiece> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF rectF = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_rectF, JniHandleOwnership.DoNotTransfer);
			__this.Place (rectF);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Piece']/class[@name='BoomPiece']/method[@name='place' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF']]"
		[Register ("place", "(Landroid/graphics/RectF;)V", "GetPlace_Landroid_graphics_RectF_Handler")]
		public virtual unsafe void Place (global::Android.Graphics.RectF rectF)
		{
			const string __id = "place.(Landroid/graphics/RectF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rectF == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rectF).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nightonke.Boommenu.Piece.BoomPiece __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Piece.BoomPiece> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColor (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Piece']/class[@name='BoomPiece']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
		public abstract void SetColor (int p0);

		static Delegate cb_setColorRes_I;
#pragma warning disable 0169
		static Delegate GetSetColorRes_IHandler ()
		{
			if (cb_setColorRes_I == null)
				cb_setColorRes_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColorRes_I);
			return cb_setColorRes_I;
		}

		static void n_SetColorRes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nightonke.Boommenu.Piece.BoomPiece __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Piece.BoomPiece> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColorRes (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Piece']/class[@name='BoomPiece']/method[@name='setColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColorRes", "(I)V", "GetSetColorRes_IHandler")]
		public abstract void SetColorRes (int p0);

	}

	[global::Android.Runtime.Register ("com/nightonke/boommenu/Piece/BoomPiece", DoNotGenerateAcw=true)]
	internal partial class BoomPieceInvoker : BoomPiece {

		public BoomPieceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/Piece/BoomPiece", typeof (BoomPieceInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Piece']/class[@name='BoomPiece']/method[@name='init' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("init", "(IF)V", "GetInit_IFHandler")]
		public override unsafe void Init (int p0, float p1)
		{
			const string __id = "init.(IF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Piece']/class[@name='BoomPiece']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
		public override unsafe void SetColor (int p0)
		{
			const string __id = "setColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Piece']/class[@name='BoomPiece']/method[@name='setColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColorRes", "(I)V", "GetSetColorRes_IHandler")]
		public override unsafe void SetColorRes (int p0)
		{
			const string __id = "setColorRes.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
