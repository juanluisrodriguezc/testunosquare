using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.BoomButtons {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomButtons/BoomButtonBuilder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class BoomButtonBuilder : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/BoomButtons/BoomButtonBuilder", typeof (BoomButtonBuilder));
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

		protected BoomButtonBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/constructor[@name='BoomButtonBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BoomButtonBuilder ()
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

		static Delegate cb_build_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetBuild_Landroid_content_Context_Handler ()
		{
			if (cb_build_Landroid_content_Context_ == null)
				cb_build_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Build_Landroid_content_Context_);
			return cb_build_Landroid_content_Context_;
		}

		static IntPtr n_Build_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='build' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("build", "(Landroid/content/Context;)Lcom/nightonke/boommenu/BoomButtons/BoomButton;", "GetBuild_Landroid_content_Context_Handler")]
		public abstract global::Com.Nightonke.Boommenu.BoomButtons.BoomButton Build (global::Android.Content.Context p0);

		static Delegate cb_button;
#pragma warning disable 0169
		static Delegate GetButtonHandler ()
		{
			if (cb_button == null)
				cb_button = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Button);
			return cb_button;
		}

		static IntPtr n_Button (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Button ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='button' and count(parameter)=0]"
		[Register ("button", "()Lcom/nightonke/boommenu/BoomButtons/BoomButton;", "GetButtonHandler")]
		public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.BoomButton Button ()
		{
			const string __id = "button.()Lcom/nightonke/boommenu/BoomButtons/BoomButton;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_highlightedColor_I;
#pragma warning disable 0169
		static Delegate GetHighlightedColor_IHandler ()
		{
			if (cb_highlightedColor_I == null)
				cb_highlightedColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HighlightedColor_I);
			return cb_highlightedColor_I;
		}

		static IntPtr n_HighlightedColor_I (IntPtr jnienv, IntPtr native__this, int highlightedColor)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HighlightedColor (highlightedColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='highlightedColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("highlightedColor", "(I)Ljava/lang/Object;", "GetHighlightedColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object HighlightedColor (int highlightedColor)
		{
			const string __id = "highlightedColor.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (highlightedColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_highlightedColorRes_I;
#pragma warning disable 0169
		static Delegate GetHighlightedColorRes_IHandler ()
		{
			if (cb_highlightedColorRes_I == null)
				cb_highlightedColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HighlightedColorRes_I);
			return cb_highlightedColorRes_I;
		}

		static IntPtr n_HighlightedColorRes_I (IntPtr jnienv, IntPtr native__this, int highlightedColorRes)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HighlightedColorRes (highlightedColorRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='highlightedColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("highlightedColorRes", "(I)Ljava/lang/Object;", "GetHighlightedColorRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object HighlightedColorRes (int highlightedColorRes)
		{
			const string __id = "highlightedColorRes.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (highlightedColorRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_highlightedImageDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetHighlightedImageDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_highlightedImageDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_highlightedImageDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_HighlightedImageDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_highlightedImageDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_HighlightedImageDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_highlightedImageDrawable)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable highlightedImageDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_highlightedImageDrawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HighlightedImageDrawable (highlightedImageDrawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='highlightedImageDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("highlightedImageDrawable", "(Landroid/graphics/drawable/Drawable;)Ljava/lang/Object;", "GetHighlightedImageDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Java.Lang.Object HighlightedImageDrawable (global::Android.Graphics.Drawables.Drawable highlightedImageDrawable)
		{
			const string __id = "highlightedImageDrawable.(Landroid/graphics/drawable/Drawable;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((highlightedImageDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) highlightedImageDrawable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_highlightedImageRes_I;
#pragma warning disable 0169
		static Delegate GetHighlightedImageRes_IHandler ()
		{
			if (cb_highlightedImageRes_I == null)
				cb_highlightedImageRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HighlightedImageRes_I);
			return cb_highlightedImageRes_I;
		}

		static IntPtr n_HighlightedImageRes_I (IntPtr jnienv, IntPtr native__this, int highlightedImageRes)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HighlightedImageRes (highlightedImageRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='highlightedImageRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("highlightedImageRes", "(I)Ljava/lang/Object;", "GetHighlightedImageRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object HighlightedImageRes (int highlightedImageRes)
		{
			const string __id = "highlightedImageRes.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (highlightedImageRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_imagePadding_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetImagePadding_Landroid_graphics_Rect_Handler ()
		{
			if (cb_imagePadding_Landroid_graphics_Rect_ == null)
				cb_imagePadding_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ImagePadding_Landroid_graphics_Rect_);
			return cb_imagePadding_Landroid_graphics_Rect_;
		}

		static IntPtr n_ImagePadding_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imagePadding)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect imagePadding = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_imagePadding, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ImagePadding (imagePadding));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='imagePadding' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("imagePadding", "(Landroid/graphics/Rect;)Ljava/lang/Object;", "GetImagePadding_Landroid_graphics_Rect_Handler")]
		public virtual unsafe global::Java.Lang.Object ImagePadding (global::Android.Graphics.Rect imagePadding)
		{
			const string __id = "imagePadding.(Landroid/graphics/Rect;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((imagePadding == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imagePadding).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_imageRect_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetImageRect_Landroid_graphics_Rect_Handler ()
		{
			if (cb_imageRect_Landroid_graphics_Rect_ == null)
				cb_imageRect_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ImageRect_Landroid_graphics_Rect_);
			return cb_imageRect_Landroid_graphics_Rect_;
		}

		static IntPtr n_ImageRect_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageRect)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect imageRect = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_imageRect, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ImageRect (imageRect));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='imageRect' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("imageRect", "(Landroid/graphics/Rect;)Ljava/lang/Object;", "GetImageRect_Landroid_graphics_Rect_Handler")]
		public virtual unsafe global::Java.Lang.Object ImageRect (global::Android.Graphics.Rect imageRect)
		{
			const string __id = "imageRect.(Landroid/graphics/Rect;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((imageRect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageRect).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_index_I;
#pragma warning disable 0169
		static Delegate GetIndex_IHandler ()
		{
			if (cb_index_I == null)
				cb_index_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Index_I);
			return cb_index_I;
		}

		static IntPtr n_Index_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Index (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='index' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("index", "(I)Lcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;", "GetIndex_IHandler")]
		public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder Index (int index)
		{
			const string __id = "index.(I)Lcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_innerListener_Lcom_nightonke_boommenu_BoomButtons_InnerOnBoomButtonClickListener_;
#pragma warning disable 0169
		static Delegate GetInnerListener_Lcom_nightonke_boommenu_BoomButtons_InnerOnBoomButtonClickListener_Handler ()
		{
			if (cb_innerListener_Lcom_nightonke_boommenu_BoomButtons_InnerOnBoomButtonClickListener_ == null)
				cb_innerListener_Lcom_nightonke_boommenu_BoomButtons_InnerOnBoomButtonClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InnerListener_Lcom_nightonke_boommenu_BoomButtons_InnerOnBoomButtonClickListener_);
			return cb_innerListener_Lcom_nightonke_boommenu_BoomButtons_InnerOnBoomButtonClickListener_;
		}

		static IntPtr n_InnerListener_Lcom_nightonke_boommenu_BoomButtons_InnerOnBoomButtonClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.BoomButtons.IInnerOnBoomButtonClickListener listener = (global::Com.Nightonke.Boommenu.BoomButtons.IInnerOnBoomButtonClickListener)global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.IInnerOnBoomButtonClickListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InnerListener (listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='innerListener' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.BoomButtons.InnerOnBoomButtonClickListener']]"
		[Register ("innerListener", "(Lcom/nightonke/boommenu/BoomButtons/InnerOnBoomButtonClickListener;)Lcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;", "GetInnerListener_Lcom_nightonke_boommenu_BoomButtons_InnerOnBoomButtonClickListener_Handler")]
		public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder InnerListener (global::Com.Nightonke.Boommenu.BoomButtons.IInnerOnBoomButtonClickListener listener)
		{
			const string __id = "innerListener.(Lcom/nightonke/boommenu/BoomButtons/InnerOnBoomButtonClickListener;)Lcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_listener_Lcom_nightonke_boommenu_BoomButtons_OnBMClickListener_;
#pragma warning disable 0169
		static Delegate GetListener_Lcom_nightonke_boommenu_BoomButtons_OnBMClickListener_Handler ()
		{
			if (cb_listener_Lcom_nightonke_boommenu_BoomButtons_OnBMClickListener_ == null)
				cb_listener_Lcom_nightonke_boommenu_BoomButtons_OnBMClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Listener_Lcom_nightonke_boommenu_BoomButtons_OnBMClickListener_);
			return cb_listener_Lcom_nightonke_boommenu_BoomButtons_OnBMClickListener_;
		}

		static IntPtr n_Listener_Lcom_nightonke_boommenu_BoomButtons_OnBMClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onBMClickListener)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.BoomButtons.IOnBMClickListener onBMClickListener = (global::Com.Nightonke.Boommenu.BoomButtons.IOnBMClickListener)global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.IOnBMClickListener> (native_onBMClickListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Listener (onBMClickListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='listener' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.BoomButtons.OnBMClickListener']]"
		[Register ("listener", "(Lcom/nightonke/boommenu/BoomButtons/OnBMClickListener;)Ljava/lang/Object;", "GetListener_Lcom_nightonke_boommenu_BoomButtons_OnBMClickListener_Handler")]
		public virtual unsafe global::Java.Lang.Object Listener (global::Com.Nightonke.Boommenu.BoomButtons.IOnBMClickListener onBMClickListener)
		{
			const string __id = "listener.(Lcom/nightonke/boommenu/BoomButtons/OnBMClickListener;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onBMClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onBMClickListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_normalColor_I;
#pragma warning disable 0169
		static Delegate GetNormalColor_IHandler ()
		{
			if (cb_normalColor_I == null)
				cb_normalColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_NormalColor_I);
			return cb_normalColor_I;
		}

		static IntPtr n_NormalColor_I (IntPtr jnienv, IntPtr native__this, int normalColor)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NormalColor (normalColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='normalColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("normalColor", "(I)Ljava/lang/Object;", "GetNormalColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object NormalColor (int normalColor)
		{
			const string __id = "normalColor.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (normalColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_normalColorRes_I;
#pragma warning disable 0169
		static Delegate GetNormalColorRes_IHandler ()
		{
			if (cb_normalColorRes_I == null)
				cb_normalColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_NormalColorRes_I);
			return cb_normalColorRes_I;
		}

		static IntPtr n_NormalColorRes_I (IntPtr jnienv, IntPtr native__this, int normalColorRes)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NormalColorRes (normalColorRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='normalColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("normalColorRes", "(I)Ljava/lang/Object;", "GetNormalColorRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object NormalColorRes (int normalColorRes)
		{
			const string __id = "normalColorRes.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (normalColorRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_normalImageDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetNormalImageDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_normalImageDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_normalImageDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NormalImageDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_normalImageDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_NormalImageDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_normalImageDrawable)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable normalImageDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_normalImageDrawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NormalImageDrawable (normalImageDrawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='normalImageDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("normalImageDrawable", "(Landroid/graphics/drawable/Drawable;)Ljava/lang/Object;", "GetNormalImageDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Java.Lang.Object NormalImageDrawable (global::Android.Graphics.Drawables.Drawable normalImageDrawable)
		{
			const string __id = "normalImageDrawable.(Landroid/graphics/drawable/Drawable;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((normalImageDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) normalImageDrawable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_normalImageRes_I;
#pragma warning disable 0169
		static Delegate GetNormalImageRes_IHandler ()
		{
			if (cb_normalImageRes_I == null)
				cb_normalImageRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_NormalImageRes_I);
			return cb_normalImageRes_I;
		}

		static IntPtr n_NormalImageRes_I (IntPtr jnienv, IntPtr native__this, int normalImageRes)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NormalImageRes (normalImageRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='normalImageRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("normalImageRes", "(I)Ljava/lang/Object;", "GetNormalImageRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object NormalImageRes (int normalImageRes)
		{
			const string __id = "normalImageRes.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (normalImageRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_piece_Lcom_nightonke_boommenu_Piece_BoomPiece_;
#pragma warning disable 0169
		static Delegate GetPiece_Lcom_nightonke_boommenu_Piece_BoomPiece_Handler ()
		{
			if (cb_piece_Lcom_nightonke_boommenu_Piece_BoomPiece_ == null)
				cb_piece_Lcom_nightonke_boommenu_Piece_BoomPiece_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Piece_Lcom_nightonke_boommenu_Piece_BoomPiece_);
			return cb_piece_Lcom_nightonke_boommenu_Piece_BoomPiece_;
		}

		static void n_Piece_Lcom_nightonke_boommenu_Piece_BoomPiece_ (IntPtr jnienv, IntPtr native__this, IntPtr native_piece)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.Piece.BoomPiece piece = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Piece.BoomPiece> (native_piece, JniHandleOwnership.DoNotTransfer);
			__this.Piece (piece);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='piece' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.Piece.BoomPiece']]"
		[Register ("piece", "(Lcom/nightonke/boommenu/Piece/BoomPiece;)V", "GetPiece_Lcom_nightonke_boommenu_Piece_BoomPiece_Handler")]
		public virtual unsafe void Piece (global::Com.Nightonke.Boommenu.Piece.BoomPiece piece)
		{
			const string __id = "piece.(Lcom/nightonke/boommenu/Piece/BoomPiece;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((piece == null) ? IntPtr.Zero : ((global::Java.Lang.Object) piece).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_pieceColor_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetPieceColor_Landroid_content_Context_Handler ()
		{
			if (cb_pieceColor_Landroid_content_Context_ == null)
				cb_pieceColor_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_PieceColor_Landroid_content_Context_);
			return cb_pieceColor_Landroid_content_Context_;
		}

		static int n_PieceColor_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PieceColor (context);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='pieceColor' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("pieceColor", "(Landroid/content/Context;)I", "GetPieceColor_Landroid_content_Context_Handler")]
		public virtual unsafe int PieceColor (global::Android.Content.Context context)
		{
			const string __id = "pieceColor.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_pieceColor_I;
#pragma warning disable 0169
		static Delegate GetPieceColor_IHandler ()
		{
			if (cb_pieceColor_I == null)
				cb_pieceColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_PieceColor_I);
			return cb_pieceColor_I;
		}

		static IntPtr n_PieceColor_I (IntPtr jnienv, IntPtr native__this, int pieceColor)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PieceColor (pieceColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='pieceColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pieceColor", "(I)Ljava/lang/Object;", "GetPieceColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object PieceColor (int pieceColor)
		{
			const string __id = "pieceColor.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pieceColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pieceColorRes_I;
#pragma warning disable 0169
		static Delegate GetPieceColorRes_IHandler ()
		{
			if (cb_pieceColorRes_I == null)
				cb_pieceColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_PieceColorRes_I);
			return cb_pieceColorRes_I;
		}

		static IntPtr n_PieceColorRes_I (IntPtr jnienv, IntPtr native__this, int pieceColorRes)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PieceColorRes (pieceColorRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='pieceColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pieceColorRes", "(I)Ljava/lang/Object;", "GetPieceColorRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object PieceColorRes (int pieceColorRes)
		{
			const string __id = "pieceColorRes.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pieceColorRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_rippleEffect_Z;
#pragma warning disable 0169
		static Delegate GetRippleEffect_ZHandler ()
		{
			if (cb_rippleEffect_Z == null)
				cb_rippleEffect_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_RippleEffect_Z);
			return cb_rippleEffect_Z;
		}

		static IntPtr n_RippleEffect_Z (IntPtr jnienv, IntPtr native__this, bool rippleEffect)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RippleEffect (rippleEffect));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='rippleEffect' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("rippleEffect", "(Z)Ljava/lang/Object;", "GetRippleEffect_ZHandler")]
		public virtual unsafe global::Java.Lang.Object RippleEffect (bool rippleEffect)
		{
			const string __id = "rippleEffect.(Z)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rippleEffect);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_rotateImage_Z;
#pragma warning disable 0169
		static Delegate GetRotateImage_ZHandler ()
		{
			if (cb_rotateImage_Z == null)
				cb_rotateImage_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_RotateImage_Z);
			return cb_rotateImage_Z;
		}

		static IntPtr n_RotateImage_Z (IntPtr jnienv, IntPtr native__this, bool rotateImage)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RotateImage (rotateImage));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='rotateImage' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("rotateImage", "(Z)Ljava/lang/Object;", "GetRotateImage_ZHandler")]
		public virtual unsafe global::Java.Lang.Object RotateImage (bool rotateImage)
		{
			const string __id = "rotateImage.(Z)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rotateImage);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setUnable_Z;
#pragma warning disable 0169
		static Delegate GetSetUnable_ZHandler ()
		{
			if (cb_setUnable_Z == null)
				cb_setUnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUnable_Z);
			return cb_setUnable_Z;
		}

		static void n_SetUnable_Z (IntPtr jnienv, IntPtr native__this, bool unable)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUnable (unable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='setUnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUnable", "(Z)V", "GetSetUnable_ZHandler")]
		public virtual unsafe void SetUnable (bool unable)
		{
			const string __id = "setUnable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (unable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_shadowColor_I;
#pragma warning disable 0169
		static Delegate GetShadowColor_IHandler ()
		{
			if (cb_shadowColor_I == null)
				cb_shadowColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ShadowColor_I);
			return cb_shadowColor_I;
		}

		static IntPtr n_ShadowColor_I (IntPtr jnienv, IntPtr native__this, int shadowColor)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShadowColor (shadowColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='shadowColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("shadowColor", "(I)Ljava/lang/Object;", "GetShadowColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object ShadowColor (int shadowColor)
		{
			const string __id = "shadowColor.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shadowColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_shadowCornerRadius_I;
#pragma warning disable 0169
		static Delegate GetShadowCornerRadius_IHandler ()
		{
			if (cb_shadowCornerRadius_I == null)
				cb_shadowCornerRadius_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ShadowCornerRadius_I);
			return cb_shadowCornerRadius_I;
		}

		static IntPtr n_ShadowCornerRadius_I (IntPtr jnienv, IntPtr native__this, int shadowCornerRadius)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShadowCornerRadius (shadowCornerRadius));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='shadowCornerRadius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("shadowCornerRadius", "(I)Ljava/lang/Object;", "GetShadowCornerRadius_IHandler")]
		public virtual unsafe global::Java.Lang.Object ShadowCornerRadius (int shadowCornerRadius)
		{
			const string __id = "shadowCornerRadius.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shadowCornerRadius);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_shadowEffect_Z;
#pragma warning disable 0169
		static Delegate GetShadowEffect_ZHandler ()
		{
			if (cb_shadowEffect_Z == null)
				cb_shadowEffect_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ShadowEffect_Z);
			return cb_shadowEffect_Z;
		}

		static IntPtr n_ShadowEffect_Z (IntPtr jnienv, IntPtr native__this, bool shadowEffect)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShadowEffect (shadowEffect));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='shadowEffect' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("shadowEffect", "(Z)Ljava/lang/Object;", "GetShadowEffect_ZHandler")]
		public virtual unsafe global::Java.Lang.Object ShadowEffect (bool shadowEffect)
		{
			const string __id = "shadowEffect.(Z)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shadowEffect);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_shadowOffsetX_I;
#pragma warning disable 0169
		static Delegate GetShadowOffsetX_IHandler ()
		{
			if (cb_shadowOffsetX_I == null)
				cb_shadowOffsetX_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ShadowOffsetX_I);
			return cb_shadowOffsetX_I;
		}

		static IntPtr n_ShadowOffsetX_I (IntPtr jnienv, IntPtr native__this, int shadowOffsetX)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShadowOffsetX (shadowOffsetX));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='shadowOffsetX' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("shadowOffsetX", "(I)Ljava/lang/Object;", "GetShadowOffsetX_IHandler")]
		public virtual unsafe global::Java.Lang.Object ShadowOffsetX (int shadowOffsetX)
		{
			const string __id = "shadowOffsetX.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shadowOffsetX);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_shadowOffsetY_I;
#pragma warning disable 0169
		static Delegate GetShadowOffsetY_IHandler ()
		{
			if (cb_shadowOffsetY_I == null)
				cb_shadowOffsetY_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ShadowOffsetY_I);
			return cb_shadowOffsetY_I;
		}

		static IntPtr n_ShadowOffsetY_I (IntPtr jnienv, IntPtr native__this, int shadowOffsetY)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShadowOffsetY (shadowOffsetY));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='shadowOffsetY' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("shadowOffsetY", "(I)Ljava/lang/Object;", "GetShadowOffsetY_IHandler")]
		public virtual unsafe global::Java.Lang.Object ShadowOffsetY (int shadowOffsetY)
		{
			const string __id = "shadowOffsetY.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shadowOffsetY);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_shadowRadius_I;
#pragma warning disable 0169
		static Delegate GetShadowRadius_IHandler ()
		{
			if (cb_shadowRadius_I == null)
				cb_shadowRadius_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ShadowRadius_I);
			return cb_shadowRadius_I;
		}

		static IntPtr n_ShadowRadius_I (IntPtr jnienv, IntPtr native__this, int shadowRadius)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShadowRadius (shadowRadius));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='shadowRadius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("shadowRadius", "(I)Ljava/lang/Object;", "GetShadowRadius_IHandler")]
		public virtual unsafe global::Java.Lang.Object ShadowRadius (int shadowRadius)
		{
			const string __id = "shadowRadius.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shadowRadius);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_unable_Z;
#pragma warning disable 0169
		static Delegate GetUnable_ZHandler ()
		{
			if (cb_unable_Z == null)
				cb_unable_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_Unable_Z);
			return cb_unable_Z;
		}

		static IntPtr n_Unable_Z (IntPtr jnienv, IntPtr native__this, bool unable)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Unable (unable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='unable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("unable", "(Z)Ljava/lang/Object;", "GetUnable_ZHandler")]
		public virtual unsafe global::Java.Lang.Object Unable (bool unable)
		{
			const string __id = "unable.(Z)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (unable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_unableColor_I;
#pragma warning disable 0169
		static Delegate GetUnableColor_IHandler ()
		{
			if (cb_unableColor_I == null)
				cb_unableColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_UnableColor_I);
			return cb_unableColor_I;
		}

		static IntPtr n_UnableColor_I (IntPtr jnienv, IntPtr native__this, int unableColor)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnableColor (unableColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='unableColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("unableColor", "(I)Ljava/lang/Object;", "GetUnableColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object UnableColor (int unableColor)
		{
			const string __id = "unableColor.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (unableColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_unableColorRes_I;
#pragma warning disable 0169
		static Delegate GetUnableColorRes_IHandler ()
		{
			if (cb_unableColorRes_I == null)
				cb_unableColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_UnableColorRes_I);
			return cb_unableColorRes_I;
		}

		static IntPtr n_UnableColorRes_I (IntPtr jnienv, IntPtr native__this, int unableColorRes)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnableColorRes (unableColorRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='unableColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("unableColorRes", "(I)Ljava/lang/Object;", "GetUnableColorRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object UnableColorRes (int unableColorRes)
		{
			const string __id = "unableColorRes.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (unableColorRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_unableImageDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetUnableImageDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_unableImageDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_unableImageDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnableImageDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_unableImageDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_UnableImageDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unableImageDrawable)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable unableImageDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_unableImageDrawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UnableImageDrawable (unableImageDrawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='unableImageDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("unableImageDrawable", "(Landroid/graphics/drawable/Drawable;)Ljava/lang/Object;", "GetUnableImageDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Java.Lang.Object UnableImageDrawable (global::Android.Graphics.Drawables.Drawable unableImageDrawable)
		{
			const string __id = "unableImageDrawable.(Landroid/graphics/drawable/Drawable;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((unableImageDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unableImageDrawable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_unableImageRes_I;
#pragma warning disable 0169
		static Delegate GetUnableImageRes_IHandler ()
		{
			if (cb_unableImageRes_I == null)
				cb_unableImageRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_UnableImageRes_I);
			return cb_unableImageRes_I;
		}

		static IntPtr n_UnableImageRes_I (IntPtr jnienv, IntPtr native__this, int unableImageRes)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnableImageRes (unableImageRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='unableImageRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("unableImageRes", "(I)Ljava/lang/Object;", "GetUnableImageRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object UnableImageRes (int unableImageRes)
		{
			const string __id = "unableImageRes.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (unableImageRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomButtons/BoomButtonBuilder", DoNotGenerateAcw=true)]
	internal partial class BoomButtonBuilderInvoker : BoomButtonBuilder {

		public BoomButtonBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/BoomButtons/BoomButtonBuilder", typeof (BoomButtonBuilderInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonBuilder']/method[@name='build' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("build", "(Landroid/content/Context;)Lcom/nightonke/boommenu/BoomButtons/BoomButton;", "GetBuild_Landroid_content_Context_Handler")]
		public override unsafe global::Com.Nightonke.Boommenu.BoomButtons.BoomButton Build (global::Android.Content.Context p0)
		{
			const string __id = "build.(Landroid/content/Context;)Lcom/nightonke/boommenu/BoomButtons/BoomButton;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
