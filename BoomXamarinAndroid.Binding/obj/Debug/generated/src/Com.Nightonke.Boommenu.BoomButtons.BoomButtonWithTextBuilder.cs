using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.BoomButtons {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomButtons/BoomButtonWithTextBuilder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class BoomButtonWithTextBuilder : global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/BoomButtons/BoomButtonWithTextBuilder", typeof (BoomButtonWithTextBuilder));
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

		protected BoomButtonWithTextBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/constructor[@name='BoomButtonWithTextBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BoomButtonWithTextBuilder ()
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

		static Delegate cb_ellipsize_Landroid_text_TextUtils_TruncateAt_;
#pragma warning disable 0169
		static Delegate GetEllipsize_Landroid_text_TextUtils_TruncateAt_Handler ()
		{
			if (cb_ellipsize_Landroid_text_TextUtils_TruncateAt_ == null)
				cb_ellipsize_Landroid_text_TextUtils_TruncateAt_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Ellipsize_Landroid_text_TextUtils_TruncateAt_);
			return cb_ellipsize_Landroid_text_TextUtils_TruncateAt_;
		}

		static IntPtr n_Ellipsize_Landroid_text_TextUtils_TruncateAt_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ellipsize)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Text.TextUtils.TruncateAt ellipsize = global::Java.Lang.Object.GetObject<global::Android.Text.TextUtils.TruncateAt> (native_ellipsize, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Ellipsize (ellipsize));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='ellipsize' and count(parameter)=1 and parameter[1][@type='android.text.TextUtils.TruncateAt']]"
		[Register ("ellipsize", "(Landroid/text/TextUtils$TruncateAt;)Ljava/lang/Object;", "GetEllipsize_Landroid_text_TextUtils_TruncateAt_Handler")]
		public virtual unsafe global::Java.Lang.Object Ellipsize (global::Android.Text.TextUtils.TruncateAt ellipsize)
		{
			const string __id = "ellipsize.(Landroid/text/TextUtils$TruncateAt;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ellipsize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ellipsize).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_highlightedText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHighlightedText_Ljava_lang_String_Handler ()
		{
			if (cb_highlightedText_Ljava_lang_String_ == null)
				cb_highlightedText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_HighlightedText_Ljava_lang_String_);
			return cb_highlightedText_Ljava_lang_String_;
		}

		static IntPtr n_HighlightedText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_highlightedText)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string highlightedText = JNIEnv.GetString (native_highlightedText, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HighlightedText (highlightedText));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='highlightedText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("highlightedText", "(Ljava/lang/String;)Ljava/lang/Object;", "GetHighlightedText_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object HighlightedText (string highlightedText)
		{
			const string __id = "highlightedText.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_highlightedText = JNIEnv.NewString (highlightedText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_highlightedText);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_highlightedText);
			}
		}

		static Delegate cb_highlightedTextColor_I;
#pragma warning disable 0169
		static Delegate GetHighlightedTextColor_IHandler ()
		{
			if (cb_highlightedTextColor_I == null)
				cb_highlightedTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HighlightedTextColor_I);
			return cb_highlightedTextColor_I;
		}

		static IntPtr n_HighlightedTextColor_I (IntPtr jnienv, IntPtr native__this, int highlightedTextColor)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HighlightedTextColor (highlightedTextColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='highlightedTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("highlightedTextColor", "(I)Ljava/lang/Object;", "GetHighlightedTextColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object HighlightedTextColor (int highlightedTextColor)
		{
			const string __id = "highlightedTextColor.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (highlightedTextColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_highlightedTextColorRes_I;
#pragma warning disable 0169
		static Delegate GetHighlightedTextColorRes_IHandler ()
		{
			if (cb_highlightedTextColorRes_I == null)
				cb_highlightedTextColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HighlightedTextColorRes_I);
			return cb_highlightedTextColorRes_I;
		}

		static IntPtr n_HighlightedTextColorRes_I (IntPtr jnienv, IntPtr native__this, int highlightedTextColorRes)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HighlightedTextColorRes (highlightedTextColorRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='highlightedTextColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("highlightedTextColorRes", "(I)Ljava/lang/Object;", "GetHighlightedTextColorRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object HighlightedTextColorRes (int highlightedTextColorRes)
		{
			const string __id = "highlightedTextColorRes.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (highlightedTextColorRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_highlightedTextRes_I;
#pragma warning disable 0169
		static Delegate GetHighlightedTextRes_IHandler ()
		{
			if (cb_highlightedTextRes_I == null)
				cb_highlightedTextRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HighlightedTextRes_I);
			return cb_highlightedTextRes_I;
		}

		static IntPtr n_HighlightedTextRes_I (IntPtr jnienv, IntPtr native__this, int highlightedTextRes)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HighlightedTextRes (highlightedTextRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='highlightedTextRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("highlightedTextRes", "(I)Ljava/lang/Object;", "GetHighlightedTextRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object HighlightedTextRes (int highlightedTextRes)
		{
			const string __id = "highlightedTextRes.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (highlightedTextRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_maxLines_I;
#pragma warning disable 0169
		static Delegate GetMaxLines_IHandler ()
		{
			if (cb_maxLines_I == null)
				cb_maxLines_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_MaxLines_I);
			return cb_maxLines_I;
		}

		static IntPtr n_MaxLines_I (IntPtr jnienv, IntPtr native__this, int maxLines)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MaxLines (maxLines));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='maxLines' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maxLines", "(I)Ljava/lang/Object;", "GetMaxLines_IHandler")]
		public virtual unsafe global::Java.Lang.Object MaxLines (int maxLines)
		{
			const string __id = "maxLines.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxLines);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_normalText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNormalText_Ljava_lang_String_Handler ()
		{
			if (cb_normalText_Ljava_lang_String_ == null)
				cb_normalText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NormalText_Ljava_lang_String_);
			return cb_normalText_Ljava_lang_String_;
		}

		static IntPtr n_NormalText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_normalText)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string normalText = JNIEnv.GetString (native_normalText, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NormalText (normalText));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='normalText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("normalText", "(Ljava/lang/String;)Ljava/lang/Object;", "GetNormalText_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object NormalText (string normalText)
		{
			const string __id = "normalText.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_normalText = JNIEnv.NewString (normalText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_normalText);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_normalText);
			}
		}

		static Delegate cb_normalTextColor_I;
#pragma warning disable 0169
		static Delegate GetNormalTextColor_IHandler ()
		{
			if (cb_normalTextColor_I == null)
				cb_normalTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_NormalTextColor_I);
			return cb_normalTextColor_I;
		}

		static IntPtr n_NormalTextColor_I (IntPtr jnienv, IntPtr native__this, int normalTextColor)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NormalTextColor (normalTextColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='normalTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("normalTextColor", "(I)Ljava/lang/Object;", "GetNormalTextColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object NormalTextColor (int normalTextColor)
		{
			const string __id = "normalTextColor.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (normalTextColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_normalTextColorRes_I;
#pragma warning disable 0169
		static Delegate GetNormalTextColorRes_IHandler ()
		{
			if (cb_normalTextColorRes_I == null)
				cb_normalTextColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_NormalTextColorRes_I);
			return cb_normalTextColorRes_I;
		}

		static IntPtr n_NormalTextColorRes_I (IntPtr jnienv, IntPtr native__this, int normalTextColorRes)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NormalTextColorRes (normalTextColorRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='normalTextColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("normalTextColorRes", "(I)Ljava/lang/Object;", "GetNormalTextColorRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object NormalTextColorRes (int normalTextColorRes)
		{
			const string __id = "normalTextColorRes.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (normalTextColorRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_normalTextRes_I;
#pragma warning disable 0169
		static Delegate GetNormalTextRes_IHandler ()
		{
			if (cb_normalTextRes_I == null)
				cb_normalTextRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_NormalTextRes_I);
			return cb_normalTextRes_I;
		}

		static IntPtr n_NormalTextRes_I (IntPtr jnienv, IntPtr native__this, int normalTextRes)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NormalTextRes (normalTextRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='normalTextRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("normalTextRes", "(I)Ljava/lang/Object;", "GetNormalTextRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object NormalTextRes (int normalTextRes)
		{
			const string __id = "normalTextRes.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (normalTextRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_textGravity_I;
#pragma warning disable 0169
		static Delegate GetTextGravity_IHandler ()
		{
			if (cb_textGravity_I == null)
				cb_textGravity_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_TextGravity_I);
			return cb_textGravity_I;
		}

		static IntPtr n_TextGravity_I (IntPtr jnienv, IntPtr native__this, int gravity)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextGravity (gravity));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='textGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("textGravity", "(I)Ljava/lang/Object;", "GetTextGravity_IHandler")]
		public virtual unsafe global::Java.Lang.Object TextGravity (int gravity)
		{
			const string __id = "textGravity.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (gravity);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_textPadding_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetTextPadding_Landroid_graphics_Rect_Handler ()
		{
			if (cb_textPadding_Landroid_graphics_Rect_ == null)
				cb_textPadding_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TextPadding_Landroid_graphics_Rect_);
			return cb_textPadding_Landroid_graphics_Rect_;
		}

		static IntPtr n_TextPadding_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_textPadding)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect textPadding = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_textPadding, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TextPadding (textPadding));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='textPadding' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("textPadding", "(Landroid/graphics/Rect;)Ljava/lang/Object;", "GetTextPadding_Landroid_graphics_Rect_Handler")]
		public virtual unsafe global::Java.Lang.Object TextPadding (global::Android.Graphics.Rect textPadding)
		{
			const string __id = "textPadding.(Landroid/graphics/Rect;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((textPadding == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textPadding).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_textRect_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetTextRect_Landroid_graphics_Rect_Handler ()
		{
			if (cb_textRect_Landroid_graphics_Rect_ == null)
				cb_textRect_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TextRect_Landroid_graphics_Rect_);
			return cb_textRect_Landroid_graphics_Rect_;
		}

		static IntPtr n_TextRect_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_textRect)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect textRect = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_textRect, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TextRect (textRect));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='textRect' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("textRect", "(Landroid/graphics/Rect;)Ljava/lang/Object;", "GetTextRect_Landroid_graphics_Rect_Handler")]
		public virtual unsafe global::Java.Lang.Object TextRect (global::Android.Graphics.Rect textRect)
		{
			const string __id = "textRect.(Landroid/graphics/Rect;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((textRect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textRect).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_textSize_I;
#pragma warning disable 0169
		static Delegate GetTextSize_IHandler ()
		{
			if (cb_textSize_I == null)
				cb_textSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_TextSize_I);
			return cb_textSize_I;
		}

		static IntPtr n_TextSize_I (IntPtr jnienv, IntPtr native__this, int textSize)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextSize (textSize));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='textSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("textSize", "(I)Ljava/lang/Object;", "GetTextSize_IHandler")]
		public virtual unsafe global::Java.Lang.Object TextSize (int textSize)
		{
			const string __id = "textSize.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (textSize);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_typeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_typeface_Landroid_graphics_Typeface_ == null)
				cb_typeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Typeface_Landroid_graphics_Typeface_);
			return cb_typeface_Landroid_graphics_Typeface_;
		}

		static IntPtr n_Typeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_typeface)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface typeface = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_typeface, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Typeface (typeface));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='typeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("typeface", "(Landroid/graphics/Typeface;)Ljava/lang/Object;", "GetTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe global::Java.Lang.Object Typeface (global::Android.Graphics.Typeface typeface)
		{
			const string __id = "typeface.(Landroid/graphics/Typeface;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((typeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeface).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_unableText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnableText_Ljava_lang_String_Handler ()
		{
			if (cb_unableText_Ljava_lang_String_ == null)
				cb_unableText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnableText_Ljava_lang_String_);
			return cb_unableText_Ljava_lang_String_;
		}

		static IntPtr n_UnableText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unableText)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string unableText = JNIEnv.GetString (native_unableText, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UnableText (unableText));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='unableText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unableText", "(Ljava/lang/String;)Ljava/lang/Object;", "GetUnableText_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object UnableText (string unableText)
		{
			const string __id = "unableText.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_unableText = JNIEnv.NewString (unableText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_unableText);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_unableText);
			}
		}

		static Delegate cb_unableTextColor_I;
#pragma warning disable 0169
		static Delegate GetUnableTextColor_IHandler ()
		{
			if (cb_unableTextColor_I == null)
				cb_unableTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_UnableTextColor_I);
			return cb_unableTextColor_I;
		}

		static IntPtr n_UnableTextColor_I (IntPtr jnienv, IntPtr native__this, int unableTextColor)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnableTextColor (unableTextColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='unableTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("unableTextColor", "(I)Ljava/lang/Object;", "GetUnableTextColor_IHandler")]
		public virtual unsafe global::Java.Lang.Object UnableTextColor (int unableTextColor)
		{
			const string __id = "unableTextColor.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (unableTextColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_unableTextColorRes_I;
#pragma warning disable 0169
		static Delegate GetUnableTextColorRes_IHandler ()
		{
			if (cb_unableTextColorRes_I == null)
				cb_unableTextColorRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_UnableTextColorRes_I);
			return cb_unableTextColorRes_I;
		}

		static IntPtr n_UnableTextColorRes_I (IntPtr jnienv, IntPtr native__this, int unableTextColorRes)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnableTextColorRes (unableTextColorRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='unableTextColorRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("unableTextColorRes", "(I)Ljava/lang/Object;", "GetUnableTextColorRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object UnableTextColorRes (int unableTextColorRes)
		{
			const string __id = "unableTextColorRes.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (unableTextColorRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_unableTextRes_I;
#pragma warning disable 0169
		static Delegate GetUnableTextRes_IHandler ()
		{
			if (cb_unableTextRes_I == null)
				cb_unableTextRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_UnableTextRes_I);
			return cb_unableTextRes_I;
		}

		static IntPtr n_UnableTextRes_I (IntPtr jnienv, IntPtr native__this, int unableTextRes)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonWithTextBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnableTextRes (unableTextRes));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButtonWithTextBuilder']/method[@name='unableTextRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("unableTextRes", "(I)Ljava/lang/Object;", "GetUnableTextRes_IHandler")]
		public virtual unsafe global::Java.Lang.Object UnableTextRes (int unableTextRes)
		{
			const string __id = "unableTextRes.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (unableTextRes);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomButtons/BoomButtonWithTextBuilder", DoNotGenerateAcw=true)]
	internal partial class BoomButtonWithTextBuilderInvoker : BoomButtonWithTextBuilder {

		public BoomButtonWithTextBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/BoomButtons/BoomButtonWithTextBuilder", typeof (BoomButtonWithTextBuilderInvoker));

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
