using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.BoomButtons {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomButtons/BoomButton", DoNotGenerateAcw=true)]
	public abstract partial class BoomButton : global::Android.Widget.FrameLayout {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='ableToHighlight']"
		[Register ("ableToHighlight")]
		protected bool AbleToHighlight {
			get {
				const string __id = "ableToHighlight.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "ableToHighlight.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='buttonCornerRadius']"
		[Register ("buttonCornerRadius")]
		protected int ButtonCornerRadius {
			get {
				const string __id = "buttonCornerRadius.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "buttonCornerRadius.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='buttonEnum']"
		[Register ("buttonEnum")]
		protected global::Com.Nightonke.Boommenu.ButtonEnum ButtonEnum {
			get {
				const string __id = "buttonEnum.Lcom/nightonke/boommenu/ButtonEnum;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.ButtonEnum> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "buttonEnum.Lcom/nightonke/boommenu/ButtonEnum;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='buttonHeight']"
		[Register ("buttonHeight")]
		protected int ButtonHeight {
			get {
				const string __id = "buttonHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "buttonHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='buttonRadius']"
		[Register ("buttonRadius")]
		protected int ButtonRadius {
			get {
				const string __id = "buttonRadius.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "buttonRadius.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='buttonWidth']"
		[Register ("buttonWidth")]
		protected int ButtonWidth {
			get {
				const string __id = "buttonWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "buttonWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='centerPoint']"
		[Register ("centerPoint")]
		public global::Android.Graphics.PointF CenterPoint {
			get {
				const string __id = "centerPoint.Landroid/graphics/PointF;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "centerPoint.Landroid/graphics/PointF;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='containsSubText']"
		[Register ("containsSubText")]
		protected bool ContainsSubText {
			get {
				const string __id = "containsSubText.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "containsSubText.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='ellipsize']"
		[Register ("ellipsize")]
		protected global::Android.Text.TextUtils.TruncateAt Ellipsize {
			get {
				const string __id = "ellipsize.Landroid/text/TextUtils$TruncateAt;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Text.TextUtils.TruncateAt> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "ellipsize.Landroid/text/TextUtils$TruncateAt;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='highlightedColorRes']"
		[Register ("highlightedColorRes")]
		protected int HighlightedColorRes {
			get {
				const string __id = "highlightedColorRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "highlightedColorRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='highlightedImageDrawable']"
		[Register ("highlightedImageDrawable")]
		protected global::Android.Graphics.Drawables.Drawable HighlightedImageDrawable {
			get {
				const string __id = "highlightedImageDrawable.Landroid/graphics/drawable/Drawable;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "highlightedImageDrawable.Landroid/graphics/drawable/Drawable;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='highlightedImageRes']"
		[Register ("highlightedImageRes")]
		protected int HighlightedImageRes {
			get {
				const string __id = "highlightedImageRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "highlightedImageRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='highlightedText']"
		[Register ("highlightedText")]
		protected string HighlightedText {
			get {
				const string __id = "highlightedText.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "highlightedText.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='highlightedTextColor']"
		[Register ("highlightedTextColor")]
		protected int HighlightedTextColor {
			get {
				const string __id = "highlightedTextColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "highlightedTextColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='highlightedTextColorRes']"
		[Register ("highlightedTextColorRes")]
		protected int HighlightedTextColorRes {
			get {
				const string __id = "highlightedTextColorRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "highlightedTextColorRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='highlightedTextRes']"
		[Register ("highlightedTextRes")]
		protected int HighlightedTextRes {
			get {
				const string __id = "highlightedTextRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "highlightedTextRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='image']"
		[Register ("image")]
		protected global::Android.Widget.ImageView Image {
			get {
				const string __id = "image.Landroid/widget/ImageView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "image.Landroid/widget/ImageView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='imagePadding']"
		[Register ("imagePadding")]
		protected global::Android.Graphics.Rect ImagePadding {
			get {
				const string __id = "imagePadding.Landroid/graphics/Rect;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "imagePadding.Landroid/graphics/Rect;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='imageRect']"
		[Register ("imageRect")]
		protected global::Android.Graphics.Rect ImageRect {
			get {
				const string __id = "imageRect.Landroid/graphics/Rect;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "imageRect.Landroid/graphics/Rect;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='index']"
		[Register ("index")]
		protected int Index {
			get {
				const string __id = "index.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "index.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='isRound']"
		[Register ("isRound")]
		protected bool IsRound {
			get {
				const string __id = "isRound.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isRound.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='lastStateIsNormal']"
		[Register ("lastStateIsNormal")]
		protected bool LastStateIsNormal {
			get {
				const string __id = "lastStateIsNormal.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "lastStateIsNormal.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='listener']"
		[Register ("listener")]
		protected global::Com.Nightonke.Boommenu.BoomButtons.IInnerOnBoomButtonClickListener Listener {
			get {
				const string __id = "listener.Lcom/nightonke/boommenu/BoomButtons/InnerOnBoomButtonClickListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.IInnerOnBoomButtonClickListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "listener.Lcom/nightonke/boommenu/BoomButtons/InnerOnBoomButtonClickListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='maxLines']"
		[Register ("maxLines")]
		protected int MaxLines {
			get {
				const string __id = "maxLines.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "maxLines.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='nonRippleBitmapDrawable']"
		[Register ("nonRippleBitmapDrawable")]
		protected global::Android.Graphics.Drawables.StateListDrawable NonRippleBitmapDrawable {
			get {
				const string __id = "nonRippleBitmapDrawable.Landroid/graphics/drawable/StateListDrawable;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.StateListDrawable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "nonRippleBitmapDrawable.Landroid/graphics/drawable/StateListDrawable;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='nonRippleGradientDrawable']"
		[Register ("nonRippleGradientDrawable")]
		protected global::Android.Graphics.Drawables.GradientDrawable NonRippleGradientDrawable {
			get {
				const string __id = "nonRippleGradientDrawable.Landroid/graphics/drawable/GradientDrawable;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.GradientDrawable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "nonRippleGradientDrawable.Landroid/graphics/drawable/GradientDrawable;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='normalColorRes']"
		[Register ("normalColorRes")]
		protected int NormalColorRes {
			get {
				const string __id = "normalColorRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "normalColorRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='normalImageDrawable']"
		[Register ("normalImageDrawable")]
		protected global::Android.Graphics.Drawables.Drawable NormalImageDrawable {
			get {
				const string __id = "normalImageDrawable.Landroid/graphics/drawable/Drawable;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "normalImageDrawable.Landroid/graphics/drawable/Drawable;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='normalImageRes']"
		[Register ("normalImageRes")]
		protected int NormalImageRes {
			get {
				const string __id = "normalImageRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "normalImageRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='normalText']"
		[Register ("normalText")]
		protected string NormalText {
			get {
				const string __id = "normalText.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "normalText.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='normalTextColor']"
		[Register ("normalTextColor")]
		protected int NormalTextColor {
			get {
				const string __id = "normalTextColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "normalTextColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='normalTextColorRes']"
		[Register ("normalTextColorRes")]
		protected int NormalTextColorRes {
			get {
				const string __id = "normalTextColorRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "normalTextColorRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='normalTextRes']"
		[Register ("normalTextRes")]
		protected int NormalTextRes {
			get {
				const string __id = "normalTextRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "normalTextRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='onBMClickListener']"
		[Register ("onBMClickListener")]
		protected global::Com.Nightonke.Boommenu.BoomButtons.IOnBMClickListener OnBMClickListener {
			get {
				const string __id = "onBMClickListener.Lcom/nightonke/boommenu/BoomButtons/OnBMClickListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.IOnBMClickListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "onBMClickListener.Lcom/nightonke/boommenu/BoomButtons/OnBMClickListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='pieceColorRes']"
		[Register ("pieceColorRes")]
		protected int PieceColorRes {
			get {
				const string __id = "pieceColorRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "pieceColorRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='rippleDrawable']"
		[Register ("rippleDrawable")]
		protected global::Android.Graphics.Drawables.RippleDrawable RippleDrawable {
			get {
				const string __id = "rippleDrawable.Landroid/graphics/drawable/RippleDrawable;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.RippleDrawable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "rippleDrawable.Landroid/graphics/drawable/RippleDrawable;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='rippleEffect']"
		[Register ("rippleEffect")]
		protected bool RippleEffect {
			get {
				const string __id = "rippleEffect.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "rippleEffect.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='rippleEffectWorks']"
		[Register ("rippleEffectWorks")]
		protected bool RippleEffectWorks {
			get {
				const string __id = "rippleEffectWorks.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "rippleEffectWorks.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='rotateImage']"
		[Register ("rotateImage")]
		protected bool RotateImage {
			get {
				const string __id = "rotateImage.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "rotateImage.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='rotateText']"
		[Register ("rotateText")]
		protected bool RotateText {
			get {
				const string __id = "rotateText.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "rotateText.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='shadowColor']"
		[Register ("shadowColor")]
		protected int ShadowColor {
			get {
				const string __id = "shadowColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "shadowColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='shadowCornerRadius']"
		[Register ("shadowCornerRadius")]
		protected int ShadowCornerRadius {
			get {
				const string __id = "shadowCornerRadius.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "shadowCornerRadius.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='shadowEffect']"
		[Register ("shadowEffect")]
		protected bool ShadowEffect {
			get {
				const string __id = "shadowEffect.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "shadowEffect.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='shadowOffsetX']"
		[Register ("shadowOffsetX")]
		protected int ShadowOffsetX {
			get {
				const string __id = "shadowOffsetX.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "shadowOffsetX.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='shadowOffsetY']"
		[Register ("shadowOffsetY")]
		protected int ShadowOffsetY {
			get {
				const string __id = "shadowOffsetY.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "shadowOffsetY.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='shadowRadius']"
		[Register ("shadowRadius")]
		protected int ShadowRadius {
			get {
				const string __id = "shadowRadius.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "shadowRadius.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subEllipsize']"
		[Register ("subEllipsize")]
		protected global::Android.Text.TextUtils.TruncateAt SubEllipsize {
			get {
				const string __id = "subEllipsize.Landroid/text/TextUtils$TruncateAt;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Text.TextUtils.TruncateAt> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "subEllipsize.Landroid/text/TextUtils$TruncateAt;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subHighlightedText']"
		[Register ("subHighlightedText")]
		protected string SubHighlightedText {
			get {
				const string __id = "subHighlightedText.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "subHighlightedText.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subHighlightedTextColor']"
		[Register ("subHighlightedTextColor")]
		protected int SubHighlightedTextColor {
			get {
				const string __id = "subHighlightedTextColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "subHighlightedTextColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subHighlightedTextColorRes']"
		[Register ("subHighlightedTextColorRes")]
		protected int SubHighlightedTextColorRes {
			get {
				const string __id = "subHighlightedTextColorRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "subHighlightedTextColorRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subHighlightedTextRes']"
		[Register ("subHighlightedTextRes")]
		protected int SubHighlightedTextRes {
			get {
				const string __id = "subHighlightedTextRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "subHighlightedTextRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subMaxLines']"
		[Register ("subMaxLines")]
		protected int SubMaxLines {
			get {
				const string __id = "subMaxLines.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "subMaxLines.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subNormalText']"
		[Register ("subNormalText")]
		protected string SubNormalText {
			get {
				const string __id = "subNormalText.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "subNormalText.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subNormalTextColor']"
		[Register ("subNormalTextColor")]
		protected int SubNormalTextColor {
			get {
				const string __id = "subNormalTextColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "subNormalTextColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subNormalTextColorRes']"
		[Register ("subNormalTextColorRes")]
		protected int SubNormalTextColorRes {
			get {
				const string __id = "subNormalTextColorRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "subNormalTextColorRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subNormalTextRes']"
		[Register ("subNormalTextRes")]
		protected int SubNormalTextRes {
			get {
				const string __id = "subNormalTextRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "subNormalTextRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subText']"
		[Register ("subText")]
		protected global::Android.Widget.TextView SubText {
			get {
				const string __id = "subText.Landroid/widget/TextView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "subText.Landroid/widget/TextView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subTextGravity']"
		[Register ("subTextGravity")]
		protected int SubTextGravity {
			get {
				const string __id = "subTextGravity.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "subTextGravity.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subTextPadding']"
		[Register ("subTextPadding")]
		protected global::Android.Graphics.Rect SubTextPadding {
			get {
				const string __id = "subTextPadding.Landroid/graphics/Rect;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "subTextPadding.Landroid/graphics/Rect;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subTextRect']"
		[Register ("subTextRect")]
		protected global::Android.Graphics.Rect SubTextRect {
			get {
				const string __id = "subTextRect.Landroid/graphics/Rect;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "subTextRect.Landroid/graphics/Rect;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subTextSize']"
		[Register ("subTextSize")]
		protected int SubTextSize {
			get {
				const string __id = "subTextSize.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "subTextSize.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subTypeface']"
		[Register ("subTypeface")]
		protected global::Android.Graphics.Typeface SubTypeface {
			get {
				const string __id = "subTypeface.Landroid/graphics/Typeface;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "subTypeface.Landroid/graphics/Typeface;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subUnableText']"
		[Register ("subUnableText")]
		protected string SubUnableText {
			get {
				const string __id = "subUnableText.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "subUnableText.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subUnableTextColor']"
		[Register ("subUnableTextColor")]
		protected int SubUnableTextColor {
			get {
				const string __id = "subUnableTextColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "subUnableTextColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subUnableTextColorRes']"
		[Register ("subUnableTextColorRes")]
		protected int SubUnableTextColorRes {
			get {
				const string __id = "subUnableTextColorRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "subUnableTextColorRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='subUnableTextRes']"
		[Register ("subUnableTextRes")]
		protected int SubUnableTextRes {
			get {
				const string __id = "subUnableTextRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "subUnableTextRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='text']"
		[Register ("text")]
		protected global::Android.Widget.TextView Text {
			get {
				const string __id = "text.Landroid/widget/TextView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "text.Landroid/widget/TextView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='textGravity']"
		[Register ("textGravity")]
		protected int TextGravity {
			get {
				const string __id = "textGravity.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "textGravity.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='textHeight']"
		[Register ("textHeight")]
		protected int TextHeight {
			get {
				const string __id = "textHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "textHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='textPadding']"
		[Register ("textPadding")]
		protected global::Android.Graphics.Rect TextPadding {
			get {
				const string __id = "textPadding.Landroid/graphics/Rect;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "textPadding.Landroid/graphics/Rect;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='textRect']"
		[Register ("textRect")]
		protected global::Android.Graphics.Rect TextRect {
			get {
				const string __id = "textRect.Landroid/graphics/Rect;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "textRect.Landroid/graphics/Rect;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='textSize']"
		[Register ("textSize")]
		protected int TextSize {
			get {
				const string __id = "textSize.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "textSize.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='textTopMargin']"
		[Register ("textTopMargin")]
		protected int TextTopMargin {
			get {
				const string __id = "textTopMargin.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "textTopMargin.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='textWidth']"
		[Register ("textWidth")]
		protected int TextWidth {
			get {
				const string __id = "textWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "textWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='trueRadius']"
		[Register ("trueRadius")]
		protected int TrueRadius {
			get {
				const string __id = "trueRadius.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "trueRadius.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='typeface']"
		[Register ("typeface")]
		protected global::Android.Graphics.Typeface Typeface {
			get {
				const string __id = "typeface.Landroid/graphics/Typeface;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "typeface.Landroid/graphics/Typeface;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='unable']"
		[Register ("unable")]
		protected bool Unable {
			get {
				const string __id = "unable.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "unable.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='unableColorRes']"
		[Register ("unableColorRes")]
		protected int UnableColorRes {
			get {
				const string __id = "unableColorRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "unableColorRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='unableImageDrawable']"
		[Register ("unableImageDrawable")]
		protected global::Android.Graphics.Drawables.Drawable UnableImageDrawable {
			get {
				const string __id = "unableImageDrawable.Landroid/graphics/drawable/Drawable;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unableImageDrawable.Landroid/graphics/drawable/Drawable;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='unableImageRes']"
		[Register ("unableImageRes")]
		protected int UnableImageRes {
			get {
				const string __id = "unableImageRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "unableImageRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='unableText']"
		[Register ("unableText")]
		protected string UnableText {
			get {
				const string __id = "unableText.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "unableText.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='unableTextColor']"
		[Register ("unableTextColor")]
		protected int UnableTextColor {
			get {
				const string __id = "unableTextColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "unableTextColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='unableTextColorRes']"
		[Register ("unableTextColorRes")]
		protected int UnableTextColorRes {
			get {
				const string __id = "unableTextColorRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "unableTextColorRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/field[@name='unableTextRes']"
		[Register ("unableTextRes")]
		protected int UnableTextRes {
			get {
				const string __id = "unableTextRes.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "unableTextRes.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/BoomButtons/BoomButton", typeof (BoomButton));
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

		protected BoomButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/constructor[@name='BoomButton' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		protected unsafe BoomButton (global::Android.Content.Context context)
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

		static Delegate cb_getButton;
#pragma warning disable 0169
		static Delegate GetGetButtonHandler ()
		{
			if (cb_getButton == null)
				cb_getButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetButton);
			return cb_getButton;
		}

		static IntPtr n_GetButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Button);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.FrameLayout Button {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='getButton' and count(parameter)=0]"
			[Register ("getButton", "()Landroid/widget/FrameLayout;", "GetGetButtonHandler")]
			get {
				const string __id = "getButton.()Landroid/widget/FrameLayout;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageView;
#pragma warning disable 0169
		static Delegate GetGetImageViewHandler ()
		{
			if (cb_getImageView == null)
				cb_getImageView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageView);
			return cb_getImageView;
		}

		static IntPtr n_GetImageView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.ImageView ImageView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='getImageView' and count(parameter)=0]"
			[Register ("getImageView", "()Landroid/widget/ImageView;", "GetGetImageViewHandler")]
			get {
				const string __id = "getImageView.()Landroid/widget/ImageView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isNeededColorAnimation;
#pragma warning disable 0169
		static Delegate GetIsNeededColorAnimationHandler ()
		{
			if (cb_isNeededColorAnimation == null)
				cb_isNeededColorAnimation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNeededColorAnimation);
			return cb_isNeededColorAnimation;
		}

		static bool n_IsNeededColorAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNeededColorAnimation;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNeededColorAnimation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='isNeededColorAnimation' and count(parameter)=0]"
			[Register ("isNeededColorAnimation", "()Z", "GetIsNeededColorAnimationHandler")]
			get {
				const string __id = "isNeededColorAnimation.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLayout;
#pragma warning disable 0169
		static Delegate GetGetLayoutHandler ()
		{
			if (cb_getLayout == null)
				cb_getLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLayout);
			return cb_getLayout;
		}

		static IntPtr n_GetLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Layout);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.ViewGroup Layout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='getLayout' and count(parameter)=0]"
			[Register ("getLayout", "()Landroid/view/ViewGroup;", "GetGetLayoutHandler")]
			get {
				const string __id = "getLayout.()Landroid/view/ViewGroup;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getShadow;
#pragma warning disable 0169
		static Delegate GetGetShadowHandler ()
		{
			if (cb_getShadow == null)
				cb_getShadow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShadow);
			return cb_getShadow;
		}

		static IntPtr n_GetShadow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Shadow);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Nightonke.Boommenu.BMBShadow Shadow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='getShadow' and count(parameter)=0]"
			[Register ("getShadow", "()Lcom/nightonke/boommenu/BMBShadow;", "GetGetShadowHandler")]
			get {
				const string __id = "getShadow.()Lcom/nightonke/boommenu/BMBShadow;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BMBShadow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSubTextView;
#pragma warning disable 0169
		static Delegate GetGetSubTextViewHandler ()
		{
			if (cb_getSubTextView == null)
				cb_getSubTextView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubTextView);
			return cb_getSubTextView;
		}

		static IntPtr n_GetSubTextView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubTextView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.TextView SubTextView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='getSubTextView' and count(parameter)=0]"
			[Register ("getSubTextView", "()Landroid/widget/TextView;", "GetGetSubTextViewHandler")]
			get {
				const string __id = "getSubTextView.()Landroid/widget/TextView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextView;
#pragma warning disable 0169
		static Delegate GetGetTextViewHandler ()
		{
			if (cb_getTextView == null)
				cb_getTextView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextView);
			return cb_getTextView;
		}

		static IntPtr n_GetTextView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.TextView TextView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='getTextView' and count(parameter)=0]"
			[Register ("getTextView", "()Landroid/widget/TextView;", "GetGetTextViewHandler")]
			get {
				const string __id = "getTextView.()Landroid/widget/TextView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_buttonColor;
#pragma warning disable 0169
		static Delegate GetButtonColorHandler ()
		{
			if (cb_buttonColor == null)
				cb_buttonColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ButtonColor);
			return cb_buttonColor;
		}

		static int n_ButtonColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ButtonColor ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='buttonColor' and count(parameter)=0]"
		[Register ("buttonColor", "()I", "GetButtonColorHandler")]
		public virtual unsafe int ButtonColor ()
		{
			const string __id = "buttonColor.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

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
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentHeight ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='contentHeight' and count(parameter)=0]"
		[Register ("contentHeight", "()I", "GetContentHeightHandler")]
		public abstract int ContentHeight ();

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
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentWidth ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='contentWidth' and count(parameter)=0]"
		[Register ("contentWidth", "()I", "GetContentWidthHandler")]
		public abstract int ContentWidth ();

		static Delegate cb_didHide;
#pragma warning disable 0169
		static Delegate GetDidHideHandler ()
		{
			if (cb_didHide == null)
				cb_didHide = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DidHide);
			return cb_didHide;
		}

		static void n_DidHide (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DidHide ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='didHide' and count(parameter)=0]"
		[Register ("didHide", "()V", "GetDidHideHandler")]
		public virtual unsafe void DidHide ()
		{
			const string __id = "didHide.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_didShow;
#pragma warning disable 0169
		static Delegate GetDidShowHandler ()
		{
			if (cb_didShow == null)
				cb_didShow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DidShow);
			return cb_didShow;
		}

		static void n_DidShow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DidShow ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='didShow' and count(parameter)=0]"
		[Register ("didShow", "()V", "GetDidShowHandler")]
		public virtual unsafe void DidShow ()
		{
			const string __id = "didShow.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (__this.GoneViews ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='goneViews' and count(parameter)=0]"
		[Register ("goneViews", "()Ljava/util/ArrayList;", "GetGoneViewsHandler")]
		public abstract global::System.Collections.Generic.IList<global::Android.Views.View> GoneViews ();

		static Delegate cb_hideAllGoneViews;
#pragma warning disable 0169
		static Delegate GetHideAllGoneViewsHandler ()
		{
			if (cb_hideAllGoneViews == null)
				cb_hideAllGoneViews = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideAllGoneViews);
			return cb_hideAllGoneViews;
		}

		static void n_HideAllGoneViews (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideAllGoneViews ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='hideAllGoneViews' and count(parameter)=0]"
		[Register ("hideAllGoneViews", "()V", "GetHideAllGoneViewsHandler")]
		public virtual unsafe void HideAllGoneViews ()
		{
			const string __id = "hideAllGoneViews.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_highlightedColor;
#pragma warning disable 0169
		static Delegate GetHighlightedColorHandler ()
		{
			if (cb_highlightedColor == null)
				cb_highlightedColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_HighlightedColor);
			return cb_highlightedColor;
		}

		static int n_HighlightedColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightedColor ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='highlightedColor' and count(parameter)=0]"
		[Register ("highlightedColor", "()I", "GetHighlightedColorHandler")]
		protected virtual unsafe int HighlightedColor ()
		{
			const string __id = "highlightedColor.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_initAttrs_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_;
#pragma warning disable 0169
		static Delegate GetInitAttrs_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_Handler ()
		{
			if (cb_initAttrs_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_ == null)
				cb_initAttrs_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitAttrs_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_);
			return cb_initAttrs_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_;
		}

		static void n_InitAttrs_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder builder = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
			__this.InitAttrs (builder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='initAttrs' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.BoomButtons.BoomButtonBuilder']]"
		[Register ("initAttrs", "(Lcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;)V", "GetInitAttrs_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_Handler")]
		protected virtual unsafe void InitAttrs (global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder builder)
		{
			const string __id = "initAttrs.(Lcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initCircleButton;
#pragma warning disable 0169
		static Delegate GetInitCircleButtonHandler ()
		{
			if (cb_initCircleButton == null)
				cb_initCircleButton = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitCircleButton);
			return cb_initCircleButton;
		}

		static void n_InitCircleButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitCircleButton ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='initCircleButton' and count(parameter)=0]"
		[Register ("initCircleButton", "()V", "GetInitCircleButtonHandler")]
		protected virtual unsafe void InitCircleButton ()
		{
			const string __id = "initCircleButton.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_initCircleButtonDrawable;
#pragma warning disable 0169
		static Delegate GetInitCircleButtonDrawableHandler ()
		{
			if (cb_initCircleButtonDrawable == null)
				cb_initCircleButtonDrawable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitCircleButtonDrawable);
			return cb_initCircleButtonDrawable;
		}

		static void n_InitCircleButtonDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitCircleButtonDrawable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='initCircleButtonDrawable' and count(parameter)=0]"
		[Register ("initCircleButtonDrawable", "()V", "GetInitCircleButtonDrawableHandler")]
		protected virtual unsafe void InitCircleButtonDrawable ()
		{
			const string __id = "initCircleButtonDrawable.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_initHamButton;
#pragma warning disable 0169
		static Delegate GetInitHamButtonHandler ()
		{
			if (cb_initHamButton == null)
				cb_initHamButton = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitHamButton);
			return cb_initHamButton;
		}

		static void n_InitHamButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitHamButton ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='initHamButton' and count(parameter)=0]"
		[Register ("initHamButton", "()V", "GetInitHamButtonHandler")]
		protected virtual unsafe void InitHamButton ()
		{
			const string __id = "initHamButton.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_initHamButtonDrawable;
#pragma warning disable 0169
		static Delegate GetInitHamButtonDrawableHandler ()
		{
			if (cb_initHamButtonDrawable == null)
				cb_initHamButtonDrawable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitHamButtonDrawable);
			return cb_initHamButtonDrawable;
		}

		static void n_InitHamButtonDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitHamButtonDrawable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='initHamButtonDrawable' and count(parameter)=0]"
		[Register ("initHamButtonDrawable", "()V", "GetInitHamButtonDrawableHandler")]
		protected virtual unsafe void InitHamButtonDrawable ()
		{
			const string __id = "initHamButtonDrawable.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_initImage;
#pragma warning disable 0169
		static Delegate GetInitImageHandler ()
		{
			if (cb_initImage == null)
				cb_initImage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitImage);
			return cb_initImage;
		}

		static void n_InitImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitImage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='initImage' and count(parameter)=0]"
		[Register ("initImage", "()V", "GetInitImageHandler")]
		protected virtual unsafe void InitImage ()
		{
			const string __id = "initImage.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_initShadow_I;
#pragma warning disable 0169
		static Delegate GetInitShadow_IHandler ()
		{
			if (cb_initShadow_I == null)
				cb_initShadow_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_InitShadow_I);
			return cb_initShadow_I;
		}

		static void n_InitShadow_I (IntPtr jnienv, IntPtr native__this, int shadowCornerRadius)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitShadow (shadowCornerRadius);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='initShadow' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("initShadow", "(I)V", "GetInitShadow_IHandler")]
		protected virtual unsafe void InitShadow (int shadowCornerRadius)
		{
			const string __id = "initShadow.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shadowCornerRadius);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initSubText_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetInitSubText_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_initSubText_Landroid_view_ViewGroup_ == null)
				cb_initSubText_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitSubText_Landroid_view_ViewGroup_);
			return cb_initSubText_Landroid_view_ViewGroup_;
		}

		static void n_InitSubText_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parent)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup parent = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_parent, JniHandleOwnership.DoNotTransfer);
			__this.InitSubText (parent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='initSubText' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("initSubText", "(Landroid/view/ViewGroup;)V", "GetInitSubText_Landroid_view_ViewGroup_Handler")]
		protected virtual unsafe void InitSubText (global::Android.Views.ViewGroup parent)
		{
			const string __id = "initSubText.(Landroid/view/ViewGroup;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initText_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetInitText_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_initText_Landroid_view_ViewGroup_ == null)
				cb_initText_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitText_Landroid_view_ViewGroup_);
			return cb_initText_Landroid_view_ViewGroup_;
		}

		static void n_InitText_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parent)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup parent = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_parent, JniHandleOwnership.DoNotTransfer);
			__this.InitText (parent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='initText' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
		[Register ("initText", "(Landroid/view/ViewGroup;)V", "GetInitText_Landroid_view_ViewGroup_Handler")]
		protected virtual unsafe void InitText (global::Android.Views.ViewGroup parent)
		{
			const string __id = "initText.(Landroid/view/ViewGroup;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initTextOutsideCircleButtonLayout;
#pragma warning disable 0169
		static Delegate GetInitTextOutsideCircleButtonLayoutHandler ()
		{
			if (cb_initTextOutsideCircleButtonLayout == null)
				cb_initTextOutsideCircleButtonLayout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitTextOutsideCircleButtonLayout);
			return cb_initTextOutsideCircleButtonLayout;
		}

		static void n_InitTextOutsideCircleButtonLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitTextOutsideCircleButtonLayout ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='initTextOutsideCircleButtonLayout' and count(parameter)=0]"
		[Register ("initTextOutsideCircleButtonLayout", "()V", "GetInitTextOutsideCircleButtonLayoutHandler")]
		protected virtual unsafe void InitTextOutsideCircleButtonLayout ()
		{
			const string __id = "initTextOutsideCircleButtonLayout.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_normalColor;
#pragma warning disable 0169
		static Delegate GetNormalColorHandler ()
		{
			if (cb_normalColor == null)
				cb_normalColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_NormalColor);
			return cb_normalColor;
		}

		static int n_NormalColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NormalColor ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='normalColor' and count(parameter)=0]"
		[Register ("normalColor", "()I", "GetNormalColorHandler")]
		protected virtual unsafe int NormalColor ()
		{
			const string __id = "normalColor.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_pieceColor;
#pragma warning disable 0169
		static Delegate GetPieceColorHandler ()
		{
			if (cb_pieceColor == null)
				cb_pieceColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_PieceColor);
			return cb_pieceColor;
		}

		static int n_PieceColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PieceColor ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='pieceColor' and count(parameter)=0]"
		[Register ("pieceColor", "()I", "GetPieceColorHandler")]
		public virtual unsafe int PieceColor ()
		{
			const string __id = "pieceColor.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_place_IIII;
#pragma warning disable 0169
		static Delegate GetPlace_IIIIHandler ()
		{
			if (cb_place_IIII == null)
				cb_place_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, IntPtr>) n_Place_IIII);
			return cb_place_IIII;
		}

		static IntPtr n_Place_IIII (IntPtr jnienv, IntPtr native__this, int left, int top, int width, int height)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Place (left, top, width, height));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='place' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("place", "(IIII)Landroid/widget/FrameLayout$LayoutParams;", "GetPlace_IIIIHandler")]
		public virtual unsafe global::Android.Widget.FrameLayout.LayoutParams Place (int left, int top, int width, int height)
		{
			const string __id = "place.(IIII)Landroid/widget/FrameLayout$LayoutParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (width);
				__args [3] = new JniArgumentValue (height);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_prepareColorTransformAnimation;
#pragma warning disable 0169
		static Delegate GetPrepareColorTransformAnimationHandler ()
		{
			if (cb_prepareColorTransformAnimation == null)
				cb_prepareColorTransformAnimation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_PrepareColorTransformAnimation);
			return cb_prepareColorTransformAnimation;
		}

		static bool n_PrepareColorTransformAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrepareColorTransformAnimation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='prepareColorTransformAnimation' and count(parameter)=0]"
		[Register ("prepareColorTransformAnimation", "()Z", "GetPrepareColorTransformAnimationHandler")]
		public virtual unsafe bool PrepareColorTransformAnimation ()
		{
			const string __id = "prepareColorTransformAnimation.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
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
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (__this.RotateViews ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='rotateViews' and count(parameter)=0]"
		[Register ("rotateViews", "()Ljava/util/ArrayList;", "GetRotateViewsHandler")]
		public abstract global::System.Collections.Generic.IList<global::Android.Views.View> RotateViews ();

		static Delegate cb_setNonRippleButtonColor_I;
#pragma warning disable 0169
		static Delegate GetSetNonRippleButtonColor_IHandler ()
		{
			if (cb_setNonRippleButtonColor_I == null)
				cb_setNonRippleButtonColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNonRippleButtonColor_I);
			return cb_setNonRippleButtonColor_I;
		}

		static void n_SetNonRippleButtonColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNonRippleButtonColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='setNonRippleButtonColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNonRippleButtonColor", "(I)V", "GetSetNonRippleButtonColor_IHandler")]
		protected virtual unsafe void SetNonRippleButtonColor (int color)
		{
			const string __id = "setNonRippleButtonColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRippleButtonColor_I;
#pragma warning disable 0169
		static Delegate GetSetRippleButtonColor_IHandler ()
		{
			if (cb_setRippleButtonColor_I == null)
				cb_setRippleButtonColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRippleButtonColor_I);
			return cb_setRippleButtonColor_I;
		}

		static void n_SetRippleButtonColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRippleButtonColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='setRippleButtonColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRippleButtonColor", "(I)V", "GetSetRippleButtonColor_IHandler")]
		protected virtual unsafe void SetRippleButtonColor (int color)
		{
			const string __id = "setRippleButtonColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotateAnchorPoints ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='setRotateAnchorPoints' and count(parameter)=0]"
		[Register ("setRotateAnchorPoints", "()V", "GetSetRotateAnchorPointsHandler")]
		public abstract void SetRotateAnchorPoints ();

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
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSelfScaleAnchorPoints ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='setSelfScaleAnchorPoints' and count(parameter)=0]"
		[Register ("setSelfScaleAnchorPoints", "()V", "GetSetSelfScaleAnchorPointsHandler")]
		public abstract void SetSelfScaleAnchorPoints ();

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
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToHighlighted ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='toHighlighted' and count(parameter)=0]"
		[Register ("toHighlighted", "()V", "GetToHighlightedHandler")]
		protected abstract void ToHighlighted ();

		static Delegate cb_toHighlightedImage;
#pragma warning disable 0169
		static Delegate GetToHighlightedImageHandler ()
		{
			if (cb_toHighlightedImage == null)
				cb_toHighlightedImage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ToHighlightedImage);
			return cb_toHighlightedImage;
		}

		static void n_ToHighlightedImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToHighlightedImage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='toHighlightedImage' and count(parameter)=0]"
		[Register ("toHighlightedImage", "()V", "GetToHighlightedImageHandler")]
		protected virtual unsafe void ToHighlightedImage ()
		{
			const string __id = "toHighlightedImage.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_toHighlightedSubText;
#pragma warning disable 0169
		static Delegate GetToHighlightedSubTextHandler ()
		{
			if (cb_toHighlightedSubText == null)
				cb_toHighlightedSubText = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ToHighlightedSubText);
			return cb_toHighlightedSubText;
		}

		static void n_ToHighlightedSubText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToHighlightedSubText ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='toHighlightedSubText' and count(parameter)=0]"
		[Register ("toHighlightedSubText", "()V", "GetToHighlightedSubTextHandler")]
		protected virtual unsafe void ToHighlightedSubText ()
		{
			const string __id = "toHighlightedSubText.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_toHighlightedText;
#pragma warning disable 0169
		static Delegate GetToHighlightedTextHandler ()
		{
			if (cb_toHighlightedText == null)
				cb_toHighlightedText = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ToHighlightedText);
			return cb_toHighlightedText;
		}

		static void n_ToHighlightedText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToHighlightedText ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='toHighlightedText' and count(parameter)=0]"
		[Register ("toHighlightedText", "()V", "GetToHighlightedTextHandler")]
		protected virtual unsafe void ToHighlightedText ()
		{
			const string __id = "toHighlightedText.()V";
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
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToNormal ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='toNormal' and count(parameter)=0]"
		[Register ("toNormal", "()V", "GetToNormalHandler")]
		protected abstract void ToNormal ();

		static Delegate cb_toNormalImage;
#pragma warning disable 0169
		static Delegate GetToNormalImageHandler ()
		{
			if (cb_toNormalImage == null)
				cb_toNormalImage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ToNormalImage);
			return cb_toNormalImage;
		}

		static void n_ToNormalImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToNormalImage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='toNormalImage' and count(parameter)=0]"
		[Register ("toNormalImage", "()V", "GetToNormalImageHandler")]
		protected virtual unsafe void ToNormalImage ()
		{
			const string __id = "toNormalImage.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_toNormalSubText;
#pragma warning disable 0169
		static Delegate GetToNormalSubTextHandler ()
		{
			if (cb_toNormalSubText == null)
				cb_toNormalSubText = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ToNormalSubText);
			return cb_toNormalSubText;
		}

		static void n_ToNormalSubText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToNormalSubText ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='toNormalSubText' and count(parameter)=0]"
		[Register ("toNormalSubText", "()V", "GetToNormalSubTextHandler")]
		protected virtual unsafe void ToNormalSubText ()
		{
			const string __id = "toNormalSubText.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_toNormalText;
#pragma warning disable 0169
		static Delegate GetToNormalTextHandler ()
		{
			if (cb_toNormalText == null)
				cb_toNormalText = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ToNormalText);
			return cb_toNormalText;
		}

		static void n_ToNormalText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToNormalText ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='toNormalText' and count(parameter)=0]"
		[Register ("toNormalText", "()V", "GetToNormalTextHandler")]
		protected virtual unsafe void ToNormalText ()
		{
			const string __id = "toNormalText.()V";
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
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrueHeight ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='trueHeight' and count(parameter)=0]"
		[Register ("trueHeight", "()I", "GetTrueHeightHandler")]
		public abstract int TrueHeight ();

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
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrueWidth ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='trueWidth' and count(parameter)=0]"
		[Register ("trueWidth", "()I", "GetTrueWidthHandler")]
		public abstract int TrueWidth ();

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
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Lcom/nightonke/boommenu/ButtonEnum;", "GetTypeHandler")]
		public abstract global::Com.Nightonke.Boommenu.ButtonEnum Type ();

		static Delegate cb_unableColor;
#pragma warning disable 0169
		static Delegate GetUnableColorHandler ()
		{
			if (cb_unableColor == null)
				cb_unableColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_UnableColor);
			return cb_unableColor;
		}

		static int n_UnableColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnableColor ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='unableColor' and count(parameter)=0]"
		[Register ("unableColor", "()I", "GetUnableColorHandler")]
		protected virtual unsafe int UnableColor ()
		{
			const string __id = "unableColor.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_willHide;
#pragma warning disable 0169
		static Delegate GetWillHideHandler ()
		{
			if (cb_willHide == null)
				cb_willHide = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WillHide);
			return cb_willHide;
		}

		static void n_WillHide (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WillHide ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='willHide' and count(parameter)=0]"
		[Register ("willHide", "()V", "GetWillHideHandler")]
		public virtual unsafe void WillHide ()
		{
			const string __id = "willHide.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_willShow;
#pragma warning disable 0169
		static Delegate GetWillShowHandler ()
		{
			if (cb_willShow == null)
				cb_willShow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WillShow);
			return cb_willShow;
		}

		static void n_WillShow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WillShow ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='willShow' and count(parameter)=0]"
		[Register ("willShow", "()V", "GetWillShowHandler")]
		public virtual unsafe void WillShow ()
		{
			const string __id = "willShow.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomButtons/BoomButton", DoNotGenerateAcw=true)]
	internal partial class BoomButtonInvoker : BoomButton {

		public BoomButtonInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/BoomButtons/BoomButton", typeof (BoomButtonInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='contentHeight' and count(parameter)=0]"
		[Register ("contentHeight", "()I", "GetContentHeightHandler")]
		public override unsafe int ContentHeight ()
		{
			const string __id = "contentHeight.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='contentWidth' and count(parameter)=0]"
		[Register ("contentWidth", "()I", "GetContentWidthHandler")]
		public override unsafe int ContentWidth ()
		{
			const string __id = "contentWidth.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='goneViews' and count(parameter)=0]"
		[Register ("goneViews", "()Ljava/util/ArrayList;", "GetGoneViewsHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Android.Views.View> GoneViews ()
		{
			const string __id = "goneViews.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Android.Views.View>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='rotateViews' and count(parameter)=0]"
		[Register ("rotateViews", "()Ljava/util/ArrayList;", "GetRotateViewsHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Android.Views.View> RotateViews ()
		{
			const string __id = "rotateViews.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Android.Views.View>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='setRotateAnchorPoints' and count(parameter)=0]"
		[Register ("setRotateAnchorPoints", "()V", "GetSetRotateAnchorPointsHandler")]
		public override unsafe void SetRotateAnchorPoints ()
		{
			const string __id = "setRotateAnchorPoints.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='setSelfScaleAnchorPoints' and count(parameter)=0]"
		[Register ("setSelfScaleAnchorPoints", "()V", "GetSetSelfScaleAnchorPointsHandler")]
		public override unsafe void SetSelfScaleAnchorPoints ()
		{
			const string __id = "setSelfScaleAnchorPoints.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='toHighlighted' and count(parameter)=0]"
		[Register ("toHighlighted", "()V", "GetToHighlightedHandler")]
		protected override unsafe void ToHighlighted ()
		{
			const string __id = "toHighlighted.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='toNormal' and count(parameter)=0]"
		[Register ("toNormal", "()V", "GetToNormalHandler")]
		protected override unsafe void ToNormal ()
		{
			const string __id = "toNormal.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='trueHeight' and count(parameter)=0]"
		[Register ("trueHeight", "()I", "GetTrueHeightHandler")]
		public override unsafe int TrueHeight ()
		{
			const string __id = "trueHeight.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='trueWidth' and count(parameter)=0]"
		[Register ("trueWidth", "()I", "GetTrueWidthHandler")]
		public override unsafe int TrueWidth ()
		{
			const string __id = "trueWidth.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/class[@name='BoomButton']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Lcom/nightonke/boommenu/ButtonEnum;", "GetTypeHandler")]
		public override unsafe global::Com.Nightonke.Boommenu.ButtonEnum Type ()
		{
			const string __id = "type.()Lcom/nightonke/boommenu/ButtonEnum;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.ButtonEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
