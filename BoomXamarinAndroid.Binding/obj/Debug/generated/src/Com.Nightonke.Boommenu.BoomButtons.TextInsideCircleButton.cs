using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.BoomButtons {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextInsideCircleButton']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomButtons/TextInsideCircleButton", DoNotGenerateAcw=true)]
	public partial class TextInsideCircleButton : global::Com.Nightonke.Boommenu.BoomButtons.BoomButton {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextInsideCircleButton.Builder']"
		[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomButtons/TextInsideCircleButton$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/BoomButtons/TextInsideCircleButton$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/BoomButtons/TextInsideCircleButton", typeof (TextInsideCircleButton));
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

		protected TextInsideCircleButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_contentHeight;
#pragma warning disable 0169
		static Delegate GetContentHeightHandler ()
		{
			if (cb_contentHeight == null)
				cb_contentHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ContentHeight);
			return cb_contentHeight;
		}

		static int n_ContentHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentHeight ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextInsideCircleButton']/method[@name='contentHeight' and count(parameter)=0]"
		[Register ("contentHeight", "()I", "GetContentHeightHandler")]
		public override unsafe int ContentHeight ()
		{
			const string __id = "contentHeight.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_contentWidth;
#pragma warning disable 0169
		static Delegate GetContentWidthHandler ()
		{
			if (cb_contentWidth == null)
				cb_contentWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ContentWidth);
			return cb_contentWidth;
		}

		static int n_ContentWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentWidth ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextInsideCircleButton']/method[@name='contentWidth' and count(parameter)=0]"
		[Register ("contentWidth", "()I", "GetContentWidthHandler")]
		public override unsafe int ContentWidth ()
		{
			const string __id = "contentWidth.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_goneViews;
#pragma warning disable 0169
		static Delegate GetGoneViewsHandler ()
		{
			if (cb_goneViews == null)
				cb_goneViews = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GoneViews);
			return cb_goneViews;
		}

		static IntPtr n_GoneViews (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (__this.GoneViews ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextInsideCircleButton']/method[@name='goneViews' and count(parameter)=0]"
		[Register ("goneViews", "()Ljava/util/ArrayList;", "GetGoneViewsHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Android.Views.View> GoneViews ()
		{
			const string __id = "goneViews.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Android.Views.View>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_rotateViews;
#pragma warning disable 0169
		static Delegate GetRotateViewsHandler ()
		{
			if (cb_rotateViews == null)
				cb_rotateViews = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RotateViews);
			return cb_rotateViews;
		}

		static IntPtr n_RotateViews (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (__this.RotateViews ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextInsideCircleButton']/method[@name='rotateViews' and count(parameter)=0]"
		[Register ("rotateViews", "()Ljava/util/ArrayList;", "GetRotateViewsHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Android.Views.View> RotateViews ()
		{
			const string __id = "rotateViews.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Android.Views.View>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRotateAnchorPoints;
#pragma warning disable 0169
		static Delegate GetSetRotateAnchorPointsHandler ()
		{
			if (cb_setRotateAnchorPoints == null)
				cb_setRotateAnchorPoints = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetRotateAnchorPoints);
			return cb_setRotateAnchorPoints;
		}

		static void n_SetRotateAnchorPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotateAnchorPoints ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextInsideCircleButton']/method[@name='setRotateAnchorPoints' and count(parameter)=0]"
		[Register ("setRotateAnchorPoints", "()V", "GetSetRotateAnchorPointsHandler")]
		public override unsafe void SetRotateAnchorPoints ()
		{
			const string __id = "setRotateAnchorPoints.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setSelfScaleAnchorPoints;
#pragma warning disable 0169
		static Delegate GetSetSelfScaleAnchorPointsHandler ()
		{
			if (cb_setSelfScaleAnchorPoints == null)
				cb_setSelfScaleAnchorPoints = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetSelfScaleAnchorPoints);
			return cb_setSelfScaleAnchorPoints;
		}

		static void n_SetSelfScaleAnchorPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelfScaleAnchorPoints ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextInsideCircleButton']/method[@name='setSelfScaleAnchorPoints' and count(parameter)=0]"
		[Register ("setSelfScaleAnchorPoints", "()V", "GetSetSelfScaleAnchorPointsHandler")]
		public override unsafe void SetSelfScaleAnchorPoints ()
		{
			const string __id = "setSelfScaleAnchorPoints.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_toHighlighted;
#pragma warning disable 0169
		static Delegate GetToHighlightedHandler ()
		{
			if (cb_toHighlighted == null)
				cb_toHighlighted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ToHighlighted);
			return cb_toHighlighted;
		}

		static void n_ToHighlighted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToHighlighted ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextInsideCircleButton']/method[@name='toHighlighted' and count(parameter)=0]"
		[Register ("toHighlighted", "()V", "GetToHighlightedHandler")]
		protected override unsafe void ToHighlighted ()
		{
			const string __id = "toHighlighted.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_toNormal;
#pragma warning disable 0169
		static Delegate GetToNormalHandler ()
		{
			if (cb_toNormal == null)
				cb_toNormal = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ToNormal);
			return cb_toNormal;
		}

		static void n_ToNormal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToNormal ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextInsideCircleButton']/method[@name='toNormal' and count(parameter)=0]"
		[Register ("toNormal", "()V", "GetToNormalHandler")]
		protected override unsafe void ToNormal ()
		{
			const string __id = "toNormal.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_trueHeight;
#pragma warning disable 0169
		static Delegate GetTrueHeightHandler ()
		{
			if (cb_trueHeight == null)
				cb_trueHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_TrueHeight);
			return cb_trueHeight;
		}

		static int n_TrueHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrueHeight ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextInsideCircleButton']/method[@name='trueHeight' and count(parameter)=0]"
		[Register ("trueHeight", "()I", "GetTrueHeightHandler")]
		public override unsafe int TrueHeight ()
		{
			const string __id = "trueHeight.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_trueWidth;
#pragma warning disable 0169
		static Delegate GetTrueWidthHandler ()
		{
			if (cb_trueWidth == null)
				cb_trueWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_TrueWidth);
			return cb_trueWidth;
		}

		static int n_TrueWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrueWidth ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextInsideCircleButton']/method[@name='trueWidth' and count(parameter)=0]"
		[Register ("trueWidth", "()I", "GetTrueWidthHandler")]
		public override unsafe int TrueWidth ()
		{
			const string __id = "trueWidth.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_type;
#pragma warning disable 0169
		static Delegate GetTypeHandler ()
		{
			if (cb_type == null)
				cb_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Type);
			return cb_type;
		}

		static IntPtr n_Type (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.TextInsideCircleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='TextInsideCircleButton']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Lcom/nightonke/boommenu/ButtonEnum;", "GetTypeHandler")]
		public override unsafe global::Com.Nightonke.Boommenu.ButtonEnum Type ()
		{
			const string __id = "type.()Lcom/nightonke/boommenu/ButtonEnum;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.ButtonEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
