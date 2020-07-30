using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomMenuButton", DoNotGenerateAcw=true)]
	public partial class BoomMenuButton : global::Android.Widget.FrameLayout, global::Com.Nightonke.Boommenu.BoomButtons.IInnerOnBoomButtonClickListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/BoomMenuButton", typeof (BoomMenuButton));
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

		protected BoomMenuButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/constructor[@name='BoomMenuButton' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BoomMenuButton (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/constructor[@name='BoomMenuButton' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe BoomMenuButton (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/constructor[@name='BoomMenuButton' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe BoomMenuButton (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isAutoBoom;
#pragma warning disable 0169
		static Delegate GetIsAutoBoomHandler ()
		{
			if (cb_isAutoBoom == null)
				cb_isAutoBoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoBoom);
			return cb_isAutoBoom;
		}

		static bool n_IsAutoBoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoBoom;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoBoom_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoBoom_ZHandler ()
		{
			if (cb_setAutoBoom_Z == null)
				cb_setAutoBoom_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutoBoom_Z);
			return cb_setAutoBoom_Z;
		}

		static void n_SetAutoBoom_Z (IntPtr jnienv, IntPtr native__this, bool autoBoom)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoBoom = autoBoom;
		}
#pragma warning restore 0169

		public virtual unsafe bool AutoBoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isAutoBoom' and count(parameter)=0]"
			[Register ("isAutoBoom", "()Z", "GetIsAutoBoomHandler")]
			get {
				const string __id = "isAutoBoom.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setAutoBoom' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoBoom", "(Z)V", "GetSetAutoBoom_ZHandler")]
			set {
				const string __id = "setAutoBoom.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAutoBoomImmediately;
#pragma warning disable 0169
		static Delegate GetIsAutoBoomImmediatelyHandler ()
		{
			if (cb_isAutoBoomImmediately == null)
				cb_isAutoBoomImmediately = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoBoomImmediately);
			return cb_isAutoBoomImmediately;
		}

		static bool n_IsAutoBoomImmediately (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoBoomImmediately;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoBoomImmediately_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoBoomImmediately_ZHandler ()
		{
			if (cb_setAutoBoomImmediately_Z == null)
				cb_setAutoBoomImmediately_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutoBoomImmediately_Z);
			return cb_setAutoBoomImmediately_Z;
		}

		static void n_SetAutoBoomImmediately_Z (IntPtr jnienv, IntPtr native__this, bool autoBoomImmediately)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoBoomImmediately = autoBoomImmediately;
		}
#pragma warning restore 0169

		public virtual unsafe bool AutoBoomImmediately {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isAutoBoomImmediately' and count(parameter)=0]"
			[Register ("isAutoBoomImmediately", "()Z", "GetIsAutoBoomImmediatelyHandler")]
			get {
				const string __id = "isAutoBoomImmediately.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setAutoBoomImmediately' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoBoomImmediately", "(Z)V", "GetSetAutoBoomImmediately_ZHandler")]
			set {
				const string __id = "setAutoBoomImmediately.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAutoHide;
#pragma warning disable 0169
		static Delegate GetIsAutoHideHandler ()
		{
			if (cb_isAutoHide == null)
				cb_isAutoHide = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoHide);
			return cb_isAutoHide;
		}

		static bool n_IsAutoHide (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoHide;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoHide_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoHide_ZHandler ()
		{
			if (cb_setAutoHide_Z == null)
				cb_setAutoHide_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutoHide_Z);
			return cb_setAutoHide_Z;
		}

		static void n_SetAutoHide_Z (IntPtr jnienv, IntPtr native__this, bool autoHide)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoHide = autoHide;
		}
#pragma warning restore 0169

		public virtual unsafe bool AutoHide {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isAutoHide' and count(parameter)=0]"
			[Register ("isAutoHide", "()Z", "GetIsAutoHideHandler")]
			get {
				const string __id = "isAutoHide.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setAutoHide' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoHide", "(Z)V", "GetSetAutoHide_ZHandler")]
			set {
				const string __id = "setAutoHide.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isBackPressListened;
#pragma warning disable 0169
		static Delegate GetIsBackPressListenedHandler ()
		{
			if (cb_isBackPressListened == null)
				cb_isBackPressListened = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBackPressListened);
			return cb_isBackPressListened;
		}

		static bool n_IsBackPressListened (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackPressListened;
		}
#pragma warning restore 0169

		static Delegate cb_setBackPressListened_Z;
#pragma warning disable 0169
		static Delegate GetSetBackPressListened_ZHandler ()
		{
			if (cb_setBackPressListened_Z == null)
				cb_setBackPressListened_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBackPressListened_Z);
			return cb_setBackPressListened_Z;
		}

		static void n_SetBackPressListened_Z (IntPtr jnienv, IntPtr native__this, bool backPressListened)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BackPressListened = backPressListened;
		}
#pragma warning restore 0169

		public virtual unsafe bool BackPressListened {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isBackPressListened' and count(parameter)=0]"
			[Register ("isBackPressListened", "()Z", "GetIsBackPressListenedHandler")]
			get {
				const string __id = "isBackPressListened.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setBackPressListened' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBackPressListened", "(Z)V", "GetSetBackPressListened_ZHandler")]
			set {
				const string __id = "setBackPressListened.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isBackgroundEffect;
#pragma warning disable 0169
		static Delegate GetIsBackgroundEffectHandler ()
		{
			if (cb_isBackgroundEffect == null)
				cb_isBackgroundEffect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBackgroundEffect);
			return cb_isBackgroundEffect;
		}

		static bool n_IsBackgroundEffect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackgroundEffect;
		}
#pragma warning restore 0169

		static Delegate cb_setBackgroundEffect_Z;
#pragma warning disable 0169
		static Delegate GetSetBackgroundEffect_ZHandler ()
		{
			if (cb_setBackgroundEffect_Z == null)
				cb_setBackgroundEffect_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBackgroundEffect_Z);
			return cb_setBackgroundEffect_Z;
		}

		static void n_SetBackgroundEffect_Z (IntPtr jnienv, IntPtr native__this, bool backgroundEffect)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BackgroundEffect = backgroundEffect;
		}
#pragma warning restore 0169

		public virtual unsafe bool BackgroundEffect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isBackgroundEffect' and count(parameter)=0]"
			[Register ("isBackgroundEffect", "()Z", "GetIsBackgroundEffectHandler")]
			get {
				const string __id = "isBackgroundEffect.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setBackgroundEffect' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBackgroundEffect", "(Z)V", "GetSetBackgroundEffect_ZHandler")]
			set {
				const string __id = "setBackgroundEffect.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBoomButtons;
#pragma warning disable 0169
		static Delegate GetGetBoomButtonsHandler ()
		{
			if (cb_getBoomButtons == null)
				cb_getBoomButtons = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBoomButtons);
			return cb_getBoomButtons;
		}

		static IntPtr n_GetBoomButtons (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton>.ToLocalJniHandle (__this.BoomButtons);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> BoomButtons {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getBoomButtons' and count(parameter)=0]"
			[Register ("getBoomButtons", "()Ljava/util/ArrayList;", "GetGetBoomButtonsHandler")]
			get {
				const string __id = "getBoomButtons.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBoomEnum;
#pragma warning disable 0169
		static Delegate GetGetBoomEnumHandler ()
		{
			if (cb_getBoomEnum == null)
				cb_getBoomEnum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBoomEnum);
			return cb_getBoomEnum;
		}

		static IntPtr n_GetBoomEnum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BoomEnum);
		}
#pragma warning restore 0169

		static Delegate cb_setBoomEnum_Lcom_nightonke_boommenu_Animation_BoomEnum_;
#pragma warning disable 0169
		static Delegate GetSetBoomEnum_Lcom_nightonke_boommenu_Animation_BoomEnum_Handler ()
		{
			if (cb_setBoomEnum_Lcom_nightonke_boommenu_Animation_BoomEnum_ == null)
				cb_setBoomEnum_Lcom_nightonke_boommenu_Animation_BoomEnum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBoomEnum_Lcom_nightonke_boommenu_Animation_BoomEnum_);
			return cb_setBoomEnum_Lcom_nightonke_boommenu_Animation_BoomEnum_;
		}

		static void n_SetBoomEnum_Lcom_nightonke_boommenu_Animation_BoomEnum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_boomEnum)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.Animation.BoomEnum boomEnum = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.BoomEnum> (native_boomEnum, JniHandleOwnership.DoNotTransfer);
			__this.BoomEnum = boomEnum;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Nightonke.Boommenu.Animation.BoomEnum BoomEnum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getBoomEnum' and count(parameter)=0]"
			[Register ("getBoomEnum", "()Lcom/nightonke/boommenu/Animation/BoomEnum;", "GetGetBoomEnumHandler")]
			get {
				const string __id = "getBoomEnum.()Lcom/nightonke/boommenu/Animation/BoomEnum;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.BoomEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setBoomEnum' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.Animation.BoomEnum']]"
			[Register ("setBoomEnum", "(Lcom/nightonke/boommenu/Animation/BoomEnum;)V", "GetSetBoomEnum_Lcom_nightonke_boommenu_Animation_BoomEnum_Handler")]
			set {
				const string __id = "setBoomEnum.(Lcom/nightonke/boommenu/Animation/BoomEnum;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isBoomInWholeScreen;
#pragma warning disable 0169
		static Delegate GetIsBoomInWholeScreenHandler ()
		{
			if (cb_isBoomInWholeScreen == null)
				cb_isBoomInWholeScreen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBoomInWholeScreen);
			return cb_isBoomInWholeScreen;
		}

		static bool n_IsBoomInWholeScreen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BoomInWholeScreen;
		}
#pragma warning restore 0169

		static Delegate cb_setBoomInWholeScreen_Z;
#pragma warning disable 0169
		static Delegate GetSetBoomInWholeScreen_ZHandler ()
		{
			if (cb_setBoomInWholeScreen_Z == null)
				cb_setBoomInWholeScreen_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBoomInWholeScreen_Z);
			return cb_setBoomInWholeScreen_Z;
		}

		static void n_SetBoomInWholeScreen_Z (IntPtr jnienv, IntPtr native__this, bool boomInWholeScreen)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BoomInWholeScreen = boomInWholeScreen;
		}
#pragma warning restore 0169

		public virtual unsafe bool BoomInWholeScreen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isBoomInWholeScreen' and count(parameter)=0]"
			[Register ("isBoomInWholeScreen", "()Z", "GetIsBoomInWholeScreenHandler")]
			get {
				const string __id = "isBoomInWholeScreen.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setBoomInWholeScreen' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBoomInWholeScreen", "(Z)V", "GetSetBoomInWholeScreen_ZHandler")]
			set {
				const string __id = "setBoomInWholeScreen.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBottomHamButtonTopMargin;
#pragma warning disable 0169
		static Delegate GetGetBottomHamButtonTopMarginHandler ()
		{
			if (cb_getBottomHamButtonTopMargin == null)
				cb_getBottomHamButtonTopMargin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBottomHamButtonTopMargin);
			return cb_getBottomHamButtonTopMargin;
		}

		static float n_GetBottomHamButtonTopMargin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BottomHamButtonTopMargin;
		}
#pragma warning restore 0169

		static Delegate cb_setBottomHamButtonTopMargin_F;
#pragma warning disable 0169
		static Delegate GetSetBottomHamButtonTopMargin_FHandler ()
		{
			if (cb_setBottomHamButtonTopMargin_F == null)
				cb_setBottomHamButtonTopMargin_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBottomHamButtonTopMargin_F);
			return cb_setBottomHamButtonTopMargin_F;
		}

		static void n_SetBottomHamButtonTopMargin_F (IntPtr jnienv, IntPtr native__this, float bottomHamButtonTopMargin)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BottomHamButtonTopMargin = bottomHamButtonTopMargin;
		}
#pragma warning restore 0169

		public virtual unsafe float BottomHamButtonTopMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getBottomHamButtonTopMargin' and count(parameter)=0]"
			[Register ("getBottomHamButtonTopMargin", "()F", "GetGetBottomHamButtonTopMarginHandler")]
			get {
				const string __id = "getBottomHamButtonTopMargin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setBottomHamButtonTopMargin' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBottomHamButtonTopMargin", "(F)V", "GetSetBottomHamButtonTopMargin_FHandler")]
			set {
				const string __id = "setBottomHamButtonTopMargin.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBuilders;
#pragma warning disable 0169
		static Delegate GetGetBuildersHandler ()
		{
			if (cb_getBuilders == null)
				cb_getBuilders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBuilders);
			return cb_getBuilders;
		}

		static IntPtr n_GetBuilders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder>.ToLocalJniHandle (__this.Builders);
		}
#pragma warning restore 0169

		static Delegate cb_setBuilders_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetBuilders_Ljava_util_ArrayList_Handler ()
		{
			if (cb_setBuilders_Ljava_util_ArrayList_ == null)
				cb_setBuilders_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBuilders_Ljava_util_ArrayList_);
			return cb_setBuilders_Ljava_util_ArrayList_;
		}

		static void n_SetBuilders_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_builders)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var builders = global::Android.Runtime.JavaList<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder>.FromJniHandle (native_builders, JniHandleOwnership.DoNotTransfer);
			__this.Builders = builders;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> Builders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getBuilders' and count(parameter)=0]"
			[Register ("getBuilders", "()Ljava/util/ArrayList;", "GetGetBuildersHandler")]
			get {
				const string __id = "getBuilders.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setBuilders' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.nightonke.boommenu.BoomButtons.BoomButtonBuilder&gt;']]"
			[Register ("setBuilders", "(Ljava/util/ArrayList;)V", "GetSetBuilders_Ljava_util_ArrayList_Handler")]
			set {
				const string __id = "setBuilders.(Ljava/util/ArrayList;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getButtonBottomMargin;
#pragma warning disable 0169
		static Delegate GetGetButtonBottomMarginHandler ()
		{
			if (cb_getButtonBottomMargin == null)
				cb_getButtonBottomMargin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetButtonBottomMargin);
			return cb_getButtonBottomMargin;
		}

		static float n_GetButtonBottomMargin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ButtonBottomMargin;
		}
#pragma warning restore 0169

		static Delegate cb_setButtonBottomMargin_F;
#pragma warning disable 0169
		static Delegate GetSetButtonBottomMargin_FHandler ()
		{
			if (cb_setButtonBottomMargin_F == null)
				cb_setButtonBottomMargin_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetButtonBottomMargin_F);
			return cb_setButtonBottomMargin_F;
		}

		static void n_SetButtonBottomMargin_F (IntPtr jnienv, IntPtr native__this, float buttonBottomMargin)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ButtonBottomMargin = buttonBottomMargin;
		}
#pragma warning restore 0169

		public virtual unsafe float ButtonBottomMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getButtonBottomMargin' and count(parameter)=0]"
			[Register ("getButtonBottomMargin", "()F", "GetGetButtonBottomMarginHandler")]
			get {
				const string __id = "getButtonBottomMargin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setButtonBottomMargin' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setButtonBottomMargin", "(F)V", "GetSetButtonBottomMargin_FHandler")]
			set {
				const string __id = "setButtonBottomMargin.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getButtonEnum;
#pragma warning disable 0169
		static Delegate GetGetButtonEnumHandler ()
		{
			if (cb_getButtonEnum == null)
				cb_getButtonEnum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetButtonEnum);
			return cb_getButtonEnum;
		}

		static IntPtr n_GetButtonEnum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ButtonEnum);
		}
#pragma warning restore 0169

		static Delegate cb_setButtonEnum_Lcom_nightonke_boommenu_ButtonEnum_;
#pragma warning disable 0169
		static Delegate GetSetButtonEnum_Lcom_nightonke_boommenu_ButtonEnum_Handler ()
		{
			if (cb_setButtonEnum_Lcom_nightonke_boommenu_ButtonEnum_ == null)
				cb_setButtonEnum_Lcom_nightonke_boommenu_ButtonEnum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetButtonEnum_Lcom_nightonke_boommenu_ButtonEnum_);
			return cb_setButtonEnum_Lcom_nightonke_boommenu_ButtonEnum_;
		}

		static void n_SetButtonEnum_Lcom_nightonke_boommenu_ButtonEnum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buttonEnum)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.ButtonEnum buttonEnum = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.ButtonEnum> (native_buttonEnum, JniHandleOwnership.DoNotTransfer);
			__this.ButtonEnum = buttonEnum;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Nightonke.Boommenu.ButtonEnum ButtonEnum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getButtonEnum' and count(parameter)=0]"
			[Register ("getButtonEnum", "()Lcom/nightonke/boommenu/ButtonEnum;", "GetGetButtonEnumHandler")]
			get {
				const string __id = "getButtonEnum.()Lcom/nightonke/boommenu/ButtonEnum;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.ButtonEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setButtonEnum' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.ButtonEnum']]"
			[Register ("setButtonEnum", "(Lcom/nightonke/boommenu/ButtonEnum;)V", "GetSetButtonEnum_Lcom_nightonke_boommenu_ButtonEnum_Handler")]
			set {
				const string __id = "setButtonEnum.(Lcom/nightonke/boommenu/ButtonEnum;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getButtonHorizontalMargin;
#pragma warning disable 0169
		static Delegate GetGetButtonHorizontalMarginHandler ()
		{
			if (cb_getButtonHorizontalMargin == null)
				cb_getButtonHorizontalMargin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetButtonHorizontalMargin);
			return cb_getButtonHorizontalMargin;
		}

		static float n_GetButtonHorizontalMargin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ButtonHorizontalMargin;
		}
#pragma warning restore 0169

		static Delegate cb_setButtonHorizontalMargin_F;
#pragma warning disable 0169
		static Delegate GetSetButtonHorizontalMargin_FHandler ()
		{
			if (cb_setButtonHorizontalMargin_F == null)
				cb_setButtonHorizontalMargin_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetButtonHorizontalMargin_F);
			return cb_setButtonHorizontalMargin_F;
		}

		static void n_SetButtonHorizontalMargin_F (IntPtr jnienv, IntPtr native__this, float buttonHorizontalMargin)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ButtonHorizontalMargin = buttonHorizontalMargin;
		}
#pragma warning restore 0169

		public virtual unsafe float ButtonHorizontalMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getButtonHorizontalMargin' and count(parameter)=0]"
			[Register ("getButtonHorizontalMargin", "()F", "GetGetButtonHorizontalMarginHandler")]
			get {
				const string __id = "getButtonHorizontalMargin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setButtonHorizontalMargin' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setButtonHorizontalMargin", "(F)V", "GetSetButtonHorizontalMargin_FHandler")]
			set {
				const string __id = "setButtonHorizontalMargin.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getButtonInclinedMargin;
#pragma warning disable 0169
		static Delegate GetGetButtonInclinedMarginHandler ()
		{
			if (cb_getButtonInclinedMargin == null)
				cb_getButtonInclinedMargin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetButtonInclinedMargin);
			return cb_getButtonInclinedMargin;
		}

		static float n_GetButtonInclinedMargin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ButtonInclinedMargin;
		}
#pragma warning restore 0169

		static Delegate cb_setButtonInclinedMargin_F;
#pragma warning disable 0169
		static Delegate GetSetButtonInclinedMargin_FHandler ()
		{
			if (cb_setButtonInclinedMargin_F == null)
				cb_setButtonInclinedMargin_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetButtonInclinedMargin_F);
			return cb_setButtonInclinedMargin_F;
		}

		static void n_SetButtonInclinedMargin_F (IntPtr jnienv, IntPtr native__this, float buttonInclinedMargin)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ButtonInclinedMargin = buttonInclinedMargin;
		}
#pragma warning restore 0169

		public virtual unsafe float ButtonInclinedMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getButtonInclinedMargin' and count(parameter)=0]"
			[Register ("getButtonInclinedMargin", "()F", "GetGetButtonInclinedMarginHandler")]
			get {
				const string __id = "getButtonInclinedMargin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setButtonInclinedMargin' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setButtonInclinedMargin", "(F)V", "GetSetButtonInclinedMargin_FHandler")]
			set {
				const string __id = "setButtonInclinedMargin.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getButtonLeftMargin;
#pragma warning disable 0169
		static Delegate GetGetButtonLeftMarginHandler ()
		{
			if (cb_getButtonLeftMargin == null)
				cb_getButtonLeftMargin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetButtonLeftMargin);
			return cb_getButtonLeftMargin;
		}

		static float n_GetButtonLeftMargin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ButtonLeftMargin;
		}
#pragma warning restore 0169

		static Delegate cb_setButtonLeftMargin_F;
#pragma warning disable 0169
		static Delegate GetSetButtonLeftMargin_FHandler ()
		{
			if (cb_setButtonLeftMargin_F == null)
				cb_setButtonLeftMargin_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetButtonLeftMargin_F);
			return cb_setButtonLeftMargin_F;
		}

		static void n_SetButtonLeftMargin_F (IntPtr jnienv, IntPtr native__this, float buttonLeftMargin)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ButtonLeftMargin = buttonLeftMargin;
		}
#pragma warning restore 0169

		public virtual unsafe float ButtonLeftMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getButtonLeftMargin' and count(parameter)=0]"
			[Register ("getButtonLeftMargin", "()F", "GetGetButtonLeftMarginHandler")]
			get {
				const string __id = "getButtonLeftMargin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setButtonLeftMargin' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setButtonLeftMargin", "(F)V", "GetSetButtonLeftMargin_FHandler")]
			set {
				const string __id = "setButtonLeftMargin.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getButtonPlaceAlignmentEnum;
#pragma warning disable 0169
		static Delegate GetGetButtonPlaceAlignmentEnumHandler ()
		{
			if (cb_getButtonPlaceAlignmentEnum == null)
				cb_getButtonPlaceAlignmentEnum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetButtonPlaceAlignmentEnum);
			return cb_getButtonPlaceAlignmentEnum;
		}

		static IntPtr n_GetButtonPlaceAlignmentEnum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ButtonPlaceAlignmentEnum);
		}
#pragma warning restore 0169

		static Delegate cb_setButtonPlaceAlignmentEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceAlignmentEnum_;
#pragma warning disable 0169
		static Delegate GetSetButtonPlaceAlignmentEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceAlignmentEnum_Handler ()
		{
			if (cb_setButtonPlaceAlignmentEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceAlignmentEnum_ == null)
				cb_setButtonPlaceAlignmentEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceAlignmentEnum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetButtonPlaceAlignmentEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceAlignmentEnum_);
			return cb_setButtonPlaceAlignmentEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceAlignmentEnum_;
		}

		static void n_SetButtonPlaceAlignmentEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceAlignmentEnum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buttonPlaceAlignmentEnum)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.BoomButtons.ButtonPlaceAlignmentEnum buttonPlaceAlignmentEnum = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.ButtonPlaceAlignmentEnum> (native_buttonPlaceAlignmentEnum, JniHandleOwnership.DoNotTransfer);
			__this.ButtonPlaceAlignmentEnum = buttonPlaceAlignmentEnum;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.ButtonPlaceAlignmentEnum ButtonPlaceAlignmentEnum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getButtonPlaceAlignmentEnum' and count(parameter)=0]"
			[Register ("getButtonPlaceAlignmentEnum", "()Lcom/nightonke/boommenu/BoomButtons/ButtonPlaceAlignmentEnum;", "GetGetButtonPlaceAlignmentEnumHandler")]
			get {
				const string __id = "getButtonPlaceAlignmentEnum.()Lcom/nightonke/boommenu/BoomButtons/ButtonPlaceAlignmentEnum;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.ButtonPlaceAlignmentEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setButtonPlaceAlignmentEnum' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.BoomButtons.ButtonPlaceAlignmentEnum']]"
			[Register ("setButtonPlaceAlignmentEnum", "(Lcom/nightonke/boommenu/BoomButtons/ButtonPlaceAlignmentEnum;)V", "GetSetButtonPlaceAlignmentEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceAlignmentEnum_Handler")]
			set {
				const string __id = "setButtonPlaceAlignmentEnum.(Lcom/nightonke/boommenu/BoomButtons/ButtonPlaceAlignmentEnum;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getButtonPlaceEnum;
#pragma warning disable 0169
		static Delegate GetGetButtonPlaceEnumHandler ()
		{
			if (cb_getButtonPlaceEnum == null)
				cb_getButtonPlaceEnum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetButtonPlaceEnum);
			return cb_getButtonPlaceEnum;
		}

		static IntPtr n_GetButtonPlaceEnum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ButtonPlaceEnum);
		}
#pragma warning restore 0169

		static Delegate cb_setButtonPlaceEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceEnum_;
#pragma warning disable 0169
		static Delegate GetSetButtonPlaceEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceEnum_Handler ()
		{
			if (cb_setButtonPlaceEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceEnum_ == null)
				cb_setButtonPlaceEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceEnum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetButtonPlaceEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceEnum_);
			return cb_setButtonPlaceEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceEnum_;
		}

		static void n_SetButtonPlaceEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceEnum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buttonPlaceEnum)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.BoomButtons.ButtonPlaceEnum buttonPlaceEnum = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.ButtonPlaceEnum> (native_buttonPlaceEnum, JniHandleOwnership.DoNotTransfer);
			__this.ButtonPlaceEnum = buttonPlaceEnum;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.ButtonPlaceEnum ButtonPlaceEnum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getButtonPlaceEnum' and count(parameter)=0]"
			[Register ("getButtonPlaceEnum", "()Lcom/nightonke/boommenu/BoomButtons/ButtonPlaceEnum;", "GetGetButtonPlaceEnumHandler")]
			get {
				const string __id = "getButtonPlaceEnum.()Lcom/nightonke/boommenu/BoomButtons/ButtonPlaceEnum;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.ButtonPlaceEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setButtonPlaceEnum' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.BoomButtons.ButtonPlaceEnum']]"
			[Register ("setButtonPlaceEnum", "(Lcom/nightonke/boommenu/BoomButtons/ButtonPlaceEnum;)V", "GetSetButtonPlaceEnum_Lcom_nightonke_boommenu_BoomButtons_ButtonPlaceEnum_Handler")]
			set {
				const string __id = "setButtonPlaceEnum.(Lcom/nightonke/boommenu/BoomButtons/ButtonPlaceEnum;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getButtonRadius;
#pragma warning disable 0169
		static Delegate GetGetButtonRadiusHandler ()
		{
			if (cb_getButtonRadius == null)
				cb_getButtonRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetButtonRadius);
			return cb_getButtonRadius;
		}

		static int n_GetButtonRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ButtonRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setButtonRadius_I;
#pragma warning disable 0169
		static Delegate GetSetButtonRadius_IHandler ()
		{
			if (cb_setButtonRadius_I == null)
				cb_setButtonRadius_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetButtonRadius_I);
			return cb_setButtonRadius_I;
		}

		static void n_SetButtonRadius_I (IntPtr jnienv, IntPtr native__this, int buttonRadius)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ButtonRadius = buttonRadius;
		}
#pragma warning restore 0169

		public virtual unsafe int ButtonRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getButtonRadius' and count(parameter)=0]"
			[Register ("getButtonRadius", "()I", "GetGetButtonRadiusHandler")]
			get {
				const string __id = "getButtonRadius.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setButtonRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setButtonRadius", "(I)V", "GetSetButtonRadius_IHandler")]
			set {
				const string __id = "setButtonRadius.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getButtonRightMargin;
#pragma warning disable 0169
		static Delegate GetGetButtonRightMarginHandler ()
		{
			if (cb_getButtonRightMargin == null)
				cb_getButtonRightMargin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetButtonRightMargin);
			return cb_getButtonRightMargin;
		}

		static float n_GetButtonRightMargin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ButtonRightMargin;
		}
#pragma warning restore 0169

		static Delegate cb_setButtonRightMargin_F;
#pragma warning disable 0169
		static Delegate GetSetButtonRightMargin_FHandler ()
		{
			if (cb_setButtonRightMargin_F == null)
				cb_setButtonRightMargin_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetButtonRightMargin_F);
			return cb_setButtonRightMargin_F;
		}

		static void n_SetButtonRightMargin_F (IntPtr jnienv, IntPtr native__this, float buttonRightMargin)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ButtonRightMargin = buttonRightMargin;
		}
#pragma warning restore 0169

		public virtual unsafe float ButtonRightMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getButtonRightMargin' and count(parameter)=0]"
			[Register ("getButtonRightMargin", "()F", "GetGetButtonRightMarginHandler")]
			get {
				const string __id = "getButtonRightMargin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setButtonRightMargin' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setButtonRightMargin", "(F)V", "GetSetButtonRightMargin_FHandler")]
			set {
				const string __id = "setButtonRightMargin.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getButtonTopMargin;
#pragma warning disable 0169
		static Delegate GetGetButtonTopMarginHandler ()
		{
			if (cb_getButtonTopMargin == null)
				cb_getButtonTopMargin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetButtonTopMargin);
			return cb_getButtonTopMargin;
		}

		static float n_GetButtonTopMargin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ButtonTopMargin;
		}
#pragma warning restore 0169

		static Delegate cb_setButtonTopMargin_F;
#pragma warning disable 0169
		static Delegate GetSetButtonTopMargin_FHandler ()
		{
			if (cb_setButtonTopMargin_F == null)
				cb_setButtonTopMargin_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetButtonTopMargin_F);
			return cb_setButtonTopMargin_F;
		}

		static void n_SetButtonTopMargin_F (IntPtr jnienv, IntPtr native__this, float buttonTopMargin)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ButtonTopMargin = buttonTopMargin;
		}
#pragma warning restore 0169

		public virtual unsafe float ButtonTopMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getButtonTopMargin' and count(parameter)=0]"
			[Register ("getButtonTopMargin", "()F", "GetGetButtonTopMarginHandler")]
			get {
				const string __id = "getButtonTopMargin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setButtonTopMargin' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setButtonTopMargin", "(F)V", "GetSetButtonTopMargin_FHandler")]
			set {
				const string __id = "setButtonTopMargin.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getButtonVerticalMargin;
#pragma warning disable 0169
		static Delegate GetGetButtonVerticalMarginHandler ()
		{
			if (cb_getButtonVerticalMargin == null)
				cb_getButtonVerticalMargin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetButtonVerticalMargin);
			return cb_getButtonVerticalMargin;
		}

		static float n_GetButtonVerticalMargin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ButtonVerticalMargin;
		}
#pragma warning restore 0169

		static Delegate cb_setButtonVerticalMargin_F;
#pragma warning disable 0169
		static Delegate GetSetButtonVerticalMargin_FHandler ()
		{
			if (cb_setButtonVerticalMargin_F == null)
				cb_setButtonVerticalMargin_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetButtonVerticalMargin_F);
			return cb_setButtonVerticalMargin_F;
		}

		static void n_SetButtonVerticalMargin_F (IntPtr jnienv, IntPtr native__this, float buttonVerticalMargin)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ButtonVerticalMargin = buttonVerticalMargin;
		}
#pragma warning restore 0169

		public virtual unsafe float ButtonVerticalMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getButtonVerticalMargin' and count(parameter)=0]"
			[Register ("getButtonVerticalMargin", "()F", "GetGetButtonVerticalMarginHandler")]
			get {
				const string __id = "getButtonVerticalMargin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setButtonVerticalMargin' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setButtonVerticalMargin", "(F)V", "GetSetButtonVerticalMargin_FHandler")]
			set {
				const string __id = "setButtonVerticalMargin.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCacheOptimization;
#pragma warning disable 0169
		static Delegate GetIsCacheOptimizationHandler ()
		{
			if (cb_isCacheOptimization == null)
				cb_isCacheOptimization = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCacheOptimization);
			return cb_isCacheOptimization;
		}

		static bool n_IsCacheOptimization (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CacheOptimization;
		}
#pragma warning restore 0169

		static Delegate cb_setCacheOptimization_Z;
#pragma warning disable 0169
		static Delegate GetSetCacheOptimization_ZHandler ()
		{
			if (cb_setCacheOptimization_Z == null)
				cb_setCacheOptimization_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCacheOptimization_Z);
			return cb_setCacheOptimization_Z;
		}

		static void n_SetCacheOptimization_Z (IntPtr jnienv, IntPtr native__this, bool cacheOptimization)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CacheOptimization = cacheOptimization;
		}
#pragma warning restore 0169

		public virtual unsafe bool CacheOptimization {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isCacheOptimization' and count(parameter)=0]"
			[Register ("isCacheOptimization", "()Z", "GetIsCacheOptimizationHandler")]
			get {
				const string __id = "isCacheOptimization.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setCacheOptimization' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCacheOptimization", "(Z)V", "GetSetCacheOptimization_ZHandler")]
			set {
				const string __id = "setCacheOptimization.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCancelable;
#pragma warning disable 0169
		static Delegate GetIsCancelableHandler ()
		{
			if (cb_isCancelable == null)
				cb_isCancelable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCancelable);
			return cb_isCancelable;
		}

		static bool n_IsCancelable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cancelable;
		}
#pragma warning restore 0169

		static Delegate cb_setCancelable_Z;
#pragma warning disable 0169
		static Delegate GetSetCancelable_ZHandler ()
		{
			if (cb_setCancelable_Z == null)
				cb_setCancelable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCancelable_Z);
			return cb_setCancelable_Z;
		}

		static void n_SetCancelable_Z (IntPtr jnienv, IntPtr native__this, bool cancelable)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancelable = cancelable;
		}
#pragma warning restore 0169

		public virtual unsafe bool Cancelable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isCancelable' and count(parameter)=0]"
			[Register ("isCancelable", "()Z", "GetIsCancelableHandler")]
			get {
				const string __id = "isCancelable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setCancelable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCancelable", "(Z)V", "GetSetCancelable_ZHandler")]
			set {
				const string __id = "setCancelable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomButtonPlacePositions;
#pragma warning disable 0169
		static Delegate GetGetCustomButtonPlacePositionsHandler ()
		{
			if (cb_getCustomButtonPlacePositions == null)
				cb_getCustomButtonPlacePositions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomButtonPlacePositions);
			return cb_getCustomButtonPlacePositions;
		}

		static IntPtr n_GetCustomButtonPlacePositions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.ToLocalJniHandle (__this.CustomButtonPlacePositions);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomButtonPlacePositions_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetCustomButtonPlacePositions_Ljava_util_ArrayList_Handler ()
		{
			if (cb_setCustomButtonPlacePositions_Ljava_util_ArrayList_ == null)
				cb_setCustomButtonPlacePositions_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomButtonPlacePositions_Ljava_util_ArrayList_);
			return cb_setCustomButtonPlacePositions_Ljava_util_ArrayList_;
		}

		static void n_SetCustomButtonPlacePositions_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_customButtonPlacePositions)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var customButtonPlacePositions = global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.FromJniHandle (native_customButtonPlacePositions, JniHandleOwnership.DoNotTransfer);
			__this.CustomButtonPlacePositions = customButtonPlacePositions;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Graphics.PointF> CustomButtonPlacePositions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getCustomButtonPlacePositions' and count(parameter)=0]"
			[Register ("getCustomButtonPlacePositions", "()Ljava/util/ArrayList;", "GetGetCustomButtonPlacePositionsHandler")]
			get {
				const string __id = "getCustomButtonPlacePositions.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setCustomButtonPlacePositions' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;android.graphics.PointF&gt;']]"
			[Register ("setCustomButtonPlacePositions", "(Ljava/util/ArrayList;)V", "GetSetCustomButtonPlacePositions_Ljava_util_ArrayList_Handler")]
			set {
				const string __id = "setCustomButtonPlacePositions.(Ljava/util/ArrayList;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCustomPiecePlacePositions;
#pragma warning disable 0169
		static Delegate GetGetCustomPiecePlacePositionsHandler ()
		{
			if (cb_getCustomPiecePlacePositions == null)
				cb_getCustomPiecePlacePositions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomPiecePlacePositions);
			return cb_getCustomPiecePlacePositions;
		}

		static IntPtr n_GetCustomPiecePlacePositions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.ToLocalJniHandle (__this.CustomPiecePlacePositions);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomPiecePlacePositions_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetCustomPiecePlacePositions_Ljava_util_ArrayList_Handler ()
		{
			if (cb_setCustomPiecePlacePositions_Ljava_util_ArrayList_ == null)
				cb_setCustomPiecePlacePositions_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomPiecePlacePositions_Ljava_util_ArrayList_);
			return cb_setCustomPiecePlacePositions_Ljava_util_ArrayList_;
		}

		static void n_SetCustomPiecePlacePositions_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_customPiecePlacePositions)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var customPiecePlacePositions = global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.FromJniHandle (native_customPiecePlacePositions, JniHandleOwnership.DoNotTransfer);
			__this.CustomPiecePlacePositions = customPiecePlacePositions;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Graphics.PointF> CustomPiecePlacePositions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getCustomPiecePlacePositions' and count(parameter)=0]"
			[Register ("getCustomPiecePlacePositions", "()Ljava/util/ArrayList;", "GetGetCustomPiecePlacePositionsHandler")]
			get {
				const string __id = "getCustomPiecePlacePositions.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setCustomPiecePlacePositions' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;android.graphics.PointF&gt;']]"
			[Register ("setCustomPiecePlacePositions", "(Ljava/util/ArrayList;)V", "GetSetCustomPiecePlacePositions_Ljava_util_ArrayList_Handler")]
			set {
				const string __id = "setCustomPiecePlacePositions.(Ljava/util/ArrayList;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDimColor;
#pragma warning disable 0169
		static Delegate GetGetDimColorHandler ()
		{
			if (cb_getDimColor == null)
				cb_getDimColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDimColor);
			return cb_getDimColor;
		}

		static int n_GetDimColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DimColor;
		}
#pragma warning restore 0169

		static Delegate cb_setDimColor_I;
#pragma warning disable 0169
		static Delegate GetSetDimColor_IHandler ()
		{
			if (cb_setDimColor_I == null)
				cb_setDimColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDimColor_I);
			return cb_setDimColor_I;
		}

		static void n_SetDimColor_I (IntPtr jnienv, IntPtr native__this, int dimColor)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DimColor = dimColor;
		}
#pragma warning restore 0169

		public virtual unsafe int DimColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getDimColor' and count(parameter)=0]"
			[Register ("getDimColor", "()I", "GetGetDimColorHandler")]
			get {
				const string __id = "getDimColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setDimColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDimColor", "(I)V", "GetSetDimColor_IHandler")]
			set {
				const string __id = "setDimColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDotRadius;
#pragma warning disable 0169
		static Delegate GetGetDotRadiusHandler ()
		{
			if (cb_getDotRadius == null)
				cb_getDotRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDotRadius);
			return cb_getDotRadius;
		}

		static float n_GetDotRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DotRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setDotRadius_F;
#pragma warning disable 0169
		static Delegate GetSetDotRadius_FHandler ()
		{
			if (cb_setDotRadius_F == null)
				cb_setDotRadius_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetDotRadius_F);
			return cb_setDotRadius_F;
		}

		static void n_SetDotRadius_F (IntPtr jnienv, IntPtr native__this, float dotRadius)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DotRadius = dotRadius;
		}
#pragma warning restore 0169

		public virtual unsafe float DotRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getDotRadius' and count(parameter)=0]"
			[Register ("getDotRadius", "()F", "GetGetDotRadiusHandler")]
			get {
				const string __id = "getDotRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setDotRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setDotRadius", "(F)V", "GetSetDotRadius_FHandler")]
			set {
				const string __id = "setDotRadius.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDraggable;
#pragma warning disable 0169
		static Delegate GetIsDraggableHandler ()
		{
			if (cb_isDraggable == null)
				cb_isDraggable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDraggable);
			return cb_isDraggable;
		}

		static bool n_IsDraggable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Draggable;
		}
#pragma warning restore 0169

		static Delegate cb_setDraggable_Z;
#pragma warning disable 0169
		static Delegate GetSetDraggable_ZHandler ()
		{
			if (cb_setDraggable_Z == null)
				cb_setDraggable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDraggable_Z);
			return cb_setDraggable_Z;
		}

		static void n_SetDraggable_Z (IntPtr jnienv, IntPtr native__this, bool draggable)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Draggable = draggable;
		}
#pragma warning restore 0169

		public virtual unsafe bool Draggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isDraggable' and count(parameter)=0]"
			[Register ("isDraggable", "()Z", "GetIsDraggableHandler")]
			get {
				const string __id = "isDraggable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setDraggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDraggable", "(Z)V", "GetSetDraggable_ZHandler")]
			set {
				const string __id = "setDraggable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEdgeInsetsInParentView;
#pragma warning disable 0169
		static Delegate GetGetEdgeInsetsInParentViewHandler ()
		{
			if (cb_getEdgeInsetsInParentView == null)
				cb_getEdgeInsetsInParentView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEdgeInsetsInParentView);
			return cb_getEdgeInsetsInParentView;
		}

		static IntPtr n_GetEdgeInsetsInParentView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EdgeInsetsInParentView);
		}
#pragma warning restore 0169

		static Delegate cb_setEdgeInsetsInParentView_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetSetEdgeInsetsInParentView_Landroid_graphics_Rect_Handler ()
		{
			if (cb_setEdgeInsetsInParentView_Landroid_graphics_Rect_ == null)
				cb_setEdgeInsetsInParentView_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEdgeInsetsInParentView_Landroid_graphics_Rect_);
			return cb_setEdgeInsetsInParentView_Landroid_graphics_Rect_;
		}

		static void n_SetEdgeInsetsInParentView_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_edgeInsetsInParentView)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect edgeInsetsInParentView = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_edgeInsetsInParentView, JniHandleOwnership.DoNotTransfer);
			__this.EdgeInsetsInParentView = edgeInsetsInParentView;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Rect EdgeInsetsInParentView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getEdgeInsetsInParentView' and count(parameter)=0]"
			[Register ("getEdgeInsetsInParentView", "()Landroid/graphics/Rect;", "GetGetEdgeInsetsInParentViewHandler")]
			get {
				const string __id = "getEdgeInsetsInParentView.()Landroid/graphics/Rect;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setEdgeInsetsInParentView' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
			[Register ("setEdgeInsetsInParentView", "(Landroid/graphics/Rect;)V", "GetSetEdgeInsetsInParentView_Landroid_graphics_Rect_Handler")]
			set {
				const string __id = "setEdgeInsetsInParentView.(Landroid/graphics/Rect;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFrames;
#pragma warning disable 0169
		static Delegate GetGetFramesHandler ()
		{
			if (cb_getFrames == null)
				cb_getFrames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFrames);
			return cb_getFrames;
		}

		static int n_GetFrames (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Frames;
		}
#pragma warning restore 0169

		static Delegate cb_setFrames_I;
#pragma warning disable 0169
		static Delegate GetSetFrames_IHandler ()
		{
			if (cb_setFrames_I == null)
				cb_setFrames_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFrames_I);
			return cb_setFrames_I;
		}

		static void n_SetFrames_I (IntPtr jnienv, IntPtr native__this, int frames)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Frames = frames;
		}
#pragma warning restore 0169

		public virtual unsafe int Frames {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getFrames' and count(parameter)=0]"
			[Register ("getFrames", "()I", "GetGetFramesHandler")]
			get {
				const string __id = "getFrames.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setFrames' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFrames", "(I)V", "GetSetFrames_IHandler")]
			set {
				const string __id = "setFrames.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHamHeight;
#pragma warning disable 0169
		static Delegate GetGetHamHeightHandler ()
		{
			if (cb_getHamHeight == null)
				cb_getHamHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHamHeight);
			return cb_getHamHeight;
		}

		static float n_GetHamHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HamHeight;
		}
#pragma warning restore 0169

		public virtual unsafe float HamHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getHamHeight' and count(parameter)=0]"
			[Register ("getHamHeight", "()F", "GetGetHamHeightHandler")]
			get {
				const string __id = "getHamHeight.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getHamWidth;
#pragma warning disable 0169
		static Delegate GetGetHamWidthHandler ()
		{
			if (cb_getHamWidth == null)
				cb_getHamWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHamWidth);
			return cb_getHamWidth;
		}

		static float n_GetHamWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HamWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setHamWidth_F;
#pragma warning disable 0169
		static Delegate GetSetHamWidth_FHandler ()
		{
			if (cb_setHamWidth_F == null)
				cb_setHamWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetHamWidth_F);
			return cb_setHamWidth_F;
		}

		static void n_SetHamWidth_F (IntPtr jnienv, IntPtr native__this, float hamWidth)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HamWidth = hamWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float HamWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getHamWidth' and count(parameter)=0]"
			[Register ("getHamWidth", "()F", "GetGetHamWidthHandler")]
			get {
				const string __id = "getHamWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setHamWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setHamWidth", "(F)V", "GetSetHamWidth_FHandler")]
			set {
				const string __id = "setHamWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHideDelay;
#pragma warning disable 0169
		static Delegate GetGetHideDelayHandler ()
		{
			if (cb_getHideDelay == null)
				cb_getHideDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetHideDelay);
			return cb_getHideDelay;
		}

		static long n_GetHideDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HideDelay;
		}
#pragma warning restore 0169

		static Delegate cb_setHideDelay_J;
#pragma warning disable 0169
		static Delegate GetSetHideDelay_JHandler ()
		{
			if (cb_setHideDelay_J == null)
				cb_setHideDelay_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetHideDelay_J);
			return cb_setHideDelay_J;
		}

		static void n_SetHideDelay_J (IntPtr jnienv, IntPtr native__this, long hideDelay)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideDelay = hideDelay;
		}
#pragma warning restore 0169

		public virtual unsafe long HideDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getHideDelay' and count(parameter)=0]"
			[Register ("getHideDelay", "()J", "GetGetHideDelayHandler")]
			get {
				const string __id = "getHideDelay.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setHideDelay' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setHideDelay", "(J)V", "GetSetHideDelay_JHandler")]
			set {
				const string __id = "setHideDelay.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHideDuration;
#pragma warning disable 0169
		static Delegate GetGetHideDurationHandler ()
		{
			if (cb_getHideDuration == null)
				cb_getHideDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetHideDuration);
			return cb_getHideDuration;
		}

		static long n_GetHideDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HideDuration;
		}
#pragma warning restore 0169

		static Delegate cb_setHideDuration_J;
#pragma warning disable 0169
		static Delegate GetSetHideDuration_JHandler ()
		{
			if (cb_setHideDuration_J == null)
				cb_setHideDuration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetHideDuration_J);
			return cb_setHideDuration_J;
		}

		static void n_SetHideDuration_J (IntPtr jnienv, IntPtr native__this, long hideDuration)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideDuration = hideDuration;
		}
#pragma warning restore 0169

		public virtual unsafe long HideDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getHideDuration' and count(parameter)=0]"
			[Register ("getHideDuration", "()J", "GetGetHideDurationHandler")]
			get {
				const string __id = "getHideDuration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setHideDuration' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setHideDuration", "(J)V", "GetSetHideDuration_JHandler")]
			set {
				const string __id = "setHideDuration.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHideMoveEaseEnum;
#pragma warning disable 0169
		static Delegate GetGetHideMoveEaseEnumHandler ()
		{
			if (cb_getHideMoveEaseEnum == null)
				cb_getHideMoveEaseEnum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHideMoveEaseEnum);
			return cb_getHideMoveEaseEnum;
		}

		static IntPtr n_GetHideMoveEaseEnum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HideMoveEaseEnum);
		}
#pragma warning restore 0169

		static Delegate cb_setHideMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
#pragma warning disable 0169
		static Delegate GetSetHideMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler ()
		{
			if (cb_setHideMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ == null)
				cb_setHideMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHideMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_);
			return cb_setHideMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
		}

		static void n_SetHideMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hideMoveEaseEnum)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.Animation.EaseEnum hideMoveEaseEnum = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.EaseEnum> (native_hideMoveEaseEnum, JniHandleOwnership.DoNotTransfer);
			__this.HideMoveEaseEnum = hideMoveEaseEnum;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Nightonke.Boommenu.Animation.EaseEnum HideMoveEaseEnum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getHideMoveEaseEnum' and count(parameter)=0]"
			[Register ("getHideMoveEaseEnum", "()Lcom/nightonke/boommenu/Animation/EaseEnum;", "GetGetHideMoveEaseEnumHandler")]
			get {
				const string __id = "getHideMoveEaseEnum.()Lcom/nightonke/boommenu/Animation/EaseEnum;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.EaseEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setHideMoveEaseEnum' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.Animation.EaseEnum']]"
			[Register ("setHideMoveEaseEnum", "(Lcom/nightonke/boommenu/Animation/EaseEnum;)V", "GetSetHideMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler")]
			set {
				const string __id = "setHideMoveEaseEnum.(Lcom/nightonke/boommenu/Animation/EaseEnum;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHideRotateEaseEnum;
#pragma warning disable 0169
		static Delegate GetGetHideRotateEaseEnumHandler ()
		{
			if (cb_getHideRotateEaseEnum == null)
				cb_getHideRotateEaseEnum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHideRotateEaseEnum);
			return cb_getHideRotateEaseEnum;
		}

		static IntPtr n_GetHideRotateEaseEnum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HideRotateEaseEnum);
		}
#pragma warning restore 0169

		static Delegate cb_setHideRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
#pragma warning disable 0169
		static Delegate GetSetHideRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler ()
		{
			if (cb_setHideRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ == null)
				cb_setHideRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHideRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_);
			return cb_setHideRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
		}

		static void n_SetHideRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hideRotateEaseEnum)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.Animation.EaseEnum hideRotateEaseEnum = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.EaseEnum> (native_hideRotateEaseEnum, JniHandleOwnership.DoNotTransfer);
			__this.HideRotateEaseEnum = hideRotateEaseEnum;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Nightonke.Boommenu.Animation.EaseEnum HideRotateEaseEnum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getHideRotateEaseEnum' and count(parameter)=0]"
			[Register ("getHideRotateEaseEnum", "()Lcom/nightonke/boommenu/Animation/EaseEnum;", "GetGetHideRotateEaseEnumHandler")]
			get {
				const string __id = "getHideRotateEaseEnum.()Lcom/nightonke/boommenu/Animation/EaseEnum;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.EaseEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setHideRotateEaseEnum' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.Animation.EaseEnum']]"
			[Register ("setHideRotateEaseEnum", "(Lcom/nightonke/boommenu/Animation/EaseEnum;)V", "GetSetHideRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler")]
			set {
				const string __id = "setHideRotateEaseEnum.(Lcom/nightonke/boommenu/Animation/EaseEnum;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHideScaleEaseEnum;
#pragma warning disable 0169
		static Delegate GetGetHideScaleEaseEnumHandler ()
		{
			if (cb_getHideScaleEaseEnum == null)
				cb_getHideScaleEaseEnum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHideScaleEaseEnum);
			return cb_getHideScaleEaseEnum;
		}

		static IntPtr n_GetHideScaleEaseEnum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HideScaleEaseEnum);
		}
#pragma warning restore 0169

		static Delegate cb_setHideScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
#pragma warning disable 0169
		static Delegate GetSetHideScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler ()
		{
			if (cb_setHideScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ == null)
				cb_setHideScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHideScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_);
			return cb_setHideScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
		}

		static void n_SetHideScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hideScaleEaseEnum)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.Animation.EaseEnum hideScaleEaseEnum = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.EaseEnum> (native_hideScaleEaseEnum, JniHandleOwnership.DoNotTransfer);
			__this.HideScaleEaseEnum = hideScaleEaseEnum;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Nightonke.Boommenu.Animation.EaseEnum HideScaleEaseEnum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getHideScaleEaseEnum' and count(parameter)=0]"
			[Register ("getHideScaleEaseEnum", "()Lcom/nightonke/boommenu/Animation/EaseEnum;", "GetGetHideScaleEaseEnumHandler")]
			get {
				const string __id = "getHideScaleEaseEnum.()Lcom/nightonke/boommenu/Animation/EaseEnum;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.EaseEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setHideScaleEaseEnum' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.Animation.EaseEnum']]"
			[Register ("setHideScaleEaseEnum", "(Lcom/nightonke/boommenu/Animation/EaseEnum;)V", "GetSetHideScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler")]
			set {
				const string __id = "setHideScaleEaseEnum.(Lcom/nightonke/boommenu/Animation/EaseEnum;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHighlightedColor;
#pragma warning disable 0169
		static Delegate GetGetHighlightedColorHandler ()
		{
			if (cb_getHighlightedColor == null)
				cb_getHighlightedColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHighlightedColor);
			return cb_getHighlightedColor;
		}

		static int n_GetHighlightedColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightedColor;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightedColor_I;
#pragma warning disable 0169
		static Delegate GetSetHighlightedColor_IHandler ()
		{
			if (cb_setHighlightedColor_I == null)
				cb_setHighlightedColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHighlightedColor_I);
			return cb_setHighlightedColor_I;
		}

		static void n_SetHighlightedColor_I (IntPtr jnienv, IntPtr native__this, int highlightedColor)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightedColor = highlightedColor;
		}
#pragma warning restore 0169

		public virtual unsafe int HighlightedColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getHighlightedColor' and count(parameter)=0]"
			[Register ("getHighlightedColor", "()I", "GetGetHighlightedColorHandler")]
			get {
				const string __id = "getHighlightedColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setHighlightedColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHighlightedColor", "(I)V", "GetSetHighlightedColor_IHandler")]
			set {
				const string __id = "setHighlightedColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isInFragment;
#pragma warning disable 0169
		static Delegate GetIsInFragmentHandler ()
		{
			if (cb_isInFragment == null)
				cb_isInFragment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInFragment);
			return cb_isInFragment;
		}

		static bool n_IsInFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InFragment;
		}
#pragma warning restore 0169

		static Delegate cb_setInFragment_Z;
#pragma warning disable 0169
		static Delegate GetSetInFragment_ZHandler ()
		{
			if (cb_setInFragment_Z == null)
				cb_setInFragment_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetInFragment_Z);
			return cb_setInFragment_Z;
		}

		static void n_SetInFragment_Z (IntPtr jnienv, IntPtr native__this, bool inFragment)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InFragment = inFragment;
		}
#pragma warning restore 0169

		public virtual unsafe bool InFragment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isInFragment' and count(parameter)=0]"
			[Register ("isInFragment", "()Z", "GetIsInFragmentHandler")]
			get {
				const string __id = "isInFragment.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setInFragment' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setInFragment", "(Z)V", "GetSetInFragment_ZHandler")]
			set {
				const string __id = "setInFragment.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isInList;
#pragma warning disable 0169
		static Delegate GetIsInListHandler ()
		{
			if (cb_isInList == null)
				cb_isInList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInList);
			return cb_isInList;
		}

		static bool n_IsInList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InList;
		}
#pragma warning restore 0169

		static Delegate cb_setInList_Z;
#pragma warning disable 0169
		static Delegate GetSetInList_ZHandler ()
		{
			if (cb_setInList_Z == null)
				cb_setInList_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetInList_Z);
			return cb_setInList_Z;
		}

		static void n_SetInList_Z (IntPtr jnienv, IntPtr native__this, bool inList)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InList = inList;
		}
#pragma warning restore 0169

		public virtual unsafe bool InList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isInList' and count(parameter)=0]"
			[Register ("isInList", "()Z", "GetIsInListHandler")]
			get {
				const string __id = "isInList.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setInList' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setInList", "(Z)V", "GetSetInList_ZHandler")]
			set {
				const string __id = "setInList.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAnimating;
#pragma warning disable 0169
		static Delegate GetIsAnimatingHandler ()
		{
			if (cb_isAnimating == null)
				cb_isAnimating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAnimating);
			return cb_isAnimating;
		}

		static bool n_IsAnimating (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnimating;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAnimating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isAnimating' and count(parameter)=0]"
			[Register ("isAnimating", "()Z", "GetIsAnimatingHandler")]
			get {
				const string __id = "isAnimating.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isBoomed;
#pragma warning disable 0169
		static Delegate GetIsBoomedHandler ()
		{
			if (cb_isBoomed == null)
				cb_isBoomed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBoomed);
			return cb_isBoomed;
		}

		static bool n_IsBoomed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBoomed;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsBoomed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isBoomed' and count(parameter)=0]"
			[Register ("isBoomed", "()Z", "GetIsBoomedHandler")]
			get {
				const string __id = "isBoomed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isReBoomed;
#pragma warning disable 0169
		static Delegate GetIsReBoomedHandler ()
		{
			if (cb_isReBoomed == null)
				cb_isReBoomed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReBoomed);
			return cb_isReBoomed;
		}

		static bool n_IsReBoomed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReBoomed;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsReBoomed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isReBoomed' and count(parameter)=0]"
			[Register ("isReBoomed", "()Z", "GetIsReBoomedHandler")]
			get {
				const string __id = "isReBoomed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNormalColor;
#pragma warning disable 0169
		static Delegate GetGetNormalColorHandler ()
		{
			if (cb_getNormalColor == null)
				cb_getNormalColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNormalColor);
			return cb_getNormalColor;
		}

		static int n_GetNormalColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NormalColor;
		}
#pragma warning restore 0169

		static Delegate cb_setNormalColor_I;
#pragma warning disable 0169
		static Delegate GetSetNormalColor_IHandler ()
		{
			if (cb_setNormalColor_I == null)
				cb_setNormalColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNormalColor_I);
			return cb_setNormalColor_I;
		}

		static void n_SetNormalColor_I (IntPtr jnienv, IntPtr native__this, int normalColor)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NormalColor = normalColor;
		}
#pragma warning restore 0169

		public virtual unsafe int NormalColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getNormalColor' and count(parameter)=0]"
			[Register ("getNormalColor", "()I", "GetGetNormalColorHandler")]
			get {
				const string __id = "getNormalColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setNormalColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNormalColor", "(I)V", "GetSetNormalColor_IHandler")]
			set {
				const string __id = "setNormalColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnBoomListener;
#pragma warning disable 0169
		static Delegate GetGetOnBoomListenerHandler ()
		{
			if (cb_getOnBoomListener == null)
				cb_getOnBoomListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnBoomListener);
			return cb_getOnBoomListener;
		}

		static IntPtr n_GetOnBoomListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnBoomListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnBoomListener_Lcom_nightonke_boommenu_OnBoomListener_;
#pragma warning disable 0169
		static Delegate GetSetOnBoomListener_Lcom_nightonke_boommenu_OnBoomListener_Handler ()
		{
			if (cb_setOnBoomListener_Lcom_nightonke_boommenu_OnBoomListener_ == null)
				cb_setOnBoomListener_Lcom_nightonke_boommenu_OnBoomListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnBoomListener_Lcom_nightonke_boommenu_OnBoomListener_);
			return cb_setOnBoomListener_Lcom_nightonke_boommenu_OnBoomListener_;
		}

		static void n_SetOnBoomListener_Lcom_nightonke_boommenu_OnBoomListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onBoomListener)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.IOnBoomListener onBoomListener = (global::Com.Nightonke.Boommenu.IOnBoomListener)global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.IOnBoomListener> (native_onBoomListener, JniHandleOwnership.DoNotTransfer);
			__this.OnBoomListener = onBoomListener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Nightonke.Boommenu.IOnBoomListener OnBoomListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getOnBoomListener' and count(parameter)=0]"
			[Register ("getOnBoomListener", "()Lcom/nightonke/boommenu/OnBoomListener;", "GetGetOnBoomListenerHandler")]
			get {
				const string __id = "getOnBoomListener.()Lcom/nightonke/boommenu/OnBoomListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.IOnBoomListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setOnBoomListener' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.OnBoomListener']]"
			[Register ("setOnBoomListener", "(Lcom/nightonke/boommenu/OnBoomListener;)V", "GetSetOnBoomListener_Lcom_nightonke_boommenu_OnBoomListener_Handler")]
			set {
				const string __id = "setOnBoomListener.(Lcom/nightonke/boommenu/OnBoomListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOrderEnum;
#pragma warning disable 0169
		static Delegate GetGetOrderEnumHandler ()
		{
			if (cb_getOrderEnum == null)
				cb_getOrderEnum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrderEnum);
			return cb_getOrderEnum;
		}

		static IntPtr n_GetOrderEnum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OrderEnum);
		}
#pragma warning restore 0169

		static Delegate cb_setOrderEnum_Lcom_nightonke_boommenu_Animation_OrderEnum_;
#pragma warning disable 0169
		static Delegate GetSetOrderEnum_Lcom_nightonke_boommenu_Animation_OrderEnum_Handler ()
		{
			if (cb_setOrderEnum_Lcom_nightonke_boommenu_Animation_OrderEnum_ == null)
				cb_setOrderEnum_Lcom_nightonke_boommenu_Animation_OrderEnum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOrderEnum_Lcom_nightonke_boommenu_Animation_OrderEnum_);
			return cb_setOrderEnum_Lcom_nightonke_boommenu_Animation_OrderEnum_;
		}

		static void n_SetOrderEnum_Lcom_nightonke_boommenu_Animation_OrderEnum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_orderEnum)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.Animation.OrderEnum orderEnum = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.OrderEnum> (native_orderEnum, JniHandleOwnership.DoNotTransfer);
			__this.OrderEnum = orderEnum;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Nightonke.Boommenu.Animation.OrderEnum OrderEnum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getOrderEnum' and count(parameter)=0]"
			[Register ("getOrderEnum", "()Lcom/nightonke/boommenu/Animation/OrderEnum;", "GetGetOrderEnumHandler")]
			get {
				const string __id = "getOrderEnum.()Lcom/nightonke/boommenu/Animation/OrderEnum;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.OrderEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setOrderEnum' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.Animation.OrderEnum']]"
			[Register ("setOrderEnum", "(Lcom/nightonke/boommenu/Animation/OrderEnum;)V", "GetSetOrderEnum_Lcom_nightonke_boommenu_Animation_OrderEnum_Handler")]
			set {
				const string __id = "setOrderEnum.(Lcom/nightonke/boommenu/Animation/OrderEnum;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isOrientationAdaptable;
#pragma warning disable 0169
		static Delegate GetIsOrientationAdaptableHandler ()
		{
			if (cb_isOrientationAdaptable == null)
				cb_isOrientationAdaptable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOrientationAdaptable);
			return cb_isOrientationAdaptable;
		}

		static bool n_IsOrientationAdaptable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OrientationAdaptable;
		}
#pragma warning restore 0169

		static Delegate cb_setOrientationAdaptable_Z;
#pragma warning disable 0169
		static Delegate GetSetOrientationAdaptable_ZHandler ()
		{
			if (cb_setOrientationAdaptable_Z == null)
				cb_setOrientationAdaptable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOrientationAdaptable_Z);
			return cb_setOrientationAdaptable_Z;
		}

		static void n_SetOrientationAdaptable_Z (IntPtr jnienv, IntPtr native__this, bool orientationAdaptable)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OrientationAdaptable = orientationAdaptable;
		}
#pragma warning restore 0169

		public virtual unsafe bool OrientationAdaptable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isOrientationAdaptable' and count(parameter)=0]"
			[Register ("isOrientationAdaptable", "()Z", "GetIsOrientationAdaptableHandler")]
			get {
				const string __id = "isOrientationAdaptable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setOrientationAdaptable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOrientationAdaptable", "(Z)V", "GetSetOrientationAdaptable_ZHandler")]
			set {
				const string __id = "setOrientationAdaptable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getParentView;
#pragma warning disable 0169
		static Delegate GetGetParentViewHandler ()
		{
			if (cb_getParentView == null)
				cb_getParentView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParentView);
			return cb_getParentView;
		}

		static IntPtr n_GetParentView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ParentView);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Android.Views.ViewGroup ParentView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getParentView' and count(parameter)=0]"
			[Register ("getParentView", "()Landroid/view/ViewGroup;", "GetGetParentViewHandler")]
			get {
				const string __id = "getParentView.()Landroid/view/ViewGroup;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPieceCornerRadius;
#pragma warning disable 0169
		static Delegate GetGetPieceCornerRadiusHandler ()
		{
			if (cb_getPieceCornerRadius == null)
				cb_getPieceCornerRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPieceCornerRadius);
			return cb_getPieceCornerRadius;
		}

		static float n_GetPieceCornerRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PieceCornerRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setPieceCornerRadius_F;
#pragma warning disable 0169
		static Delegate GetSetPieceCornerRadius_FHandler ()
		{
			if (cb_setPieceCornerRadius_F == null)
				cb_setPieceCornerRadius_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPieceCornerRadius_F);
			return cb_setPieceCornerRadius_F;
		}

		static void n_SetPieceCornerRadius_F (IntPtr jnienv, IntPtr native__this, float pieceCornerRadius)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PieceCornerRadius = pieceCornerRadius;
		}
#pragma warning restore 0169

		public virtual unsafe float PieceCornerRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getPieceCornerRadius' and count(parameter)=0]"
			[Register ("getPieceCornerRadius", "()F", "GetGetPieceCornerRadiusHandler")]
			get {
				const string __id = "getPieceCornerRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setPieceCornerRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPieceCornerRadius", "(F)V", "GetSetPieceCornerRadius_FHandler")]
			set {
				const string __id = "setPieceCornerRadius.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPieceHorizontalMargin;
#pragma warning disable 0169
		static Delegate GetGetPieceHorizontalMarginHandler ()
		{
			if (cb_getPieceHorizontalMargin == null)
				cb_getPieceHorizontalMargin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPieceHorizontalMargin);
			return cb_getPieceHorizontalMargin;
		}

		static float n_GetPieceHorizontalMargin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PieceHorizontalMargin;
		}
#pragma warning restore 0169

		static Delegate cb_setPieceHorizontalMargin_F;
#pragma warning disable 0169
		static Delegate GetSetPieceHorizontalMargin_FHandler ()
		{
			if (cb_setPieceHorizontalMargin_F == null)
				cb_setPieceHorizontalMargin_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPieceHorizontalMargin_F);
			return cb_setPieceHorizontalMargin_F;
		}

		static void n_SetPieceHorizontalMargin_F (IntPtr jnienv, IntPtr native__this, float pieceHorizontalMargin)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PieceHorizontalMargin = pieceHorizontalMargin;
		}
#pragma warning restore 0169

		public virtual unsafe float PieceHorizontalMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getPieceHorizontalMargin' and count(parameter)=0]"
			[Register ("getPieceHorizontalMargin", "()F", "GetGetPieceHorizontalMarginHandler")]
			get {
				const string __id = "getPieceHorizontalMargin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setPieceHorizontalMargin' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPieceHorizontalMargin", "(F)V", "GetSetPieceHorizontalMargin_FHandler")]
			set {
				const string __id = "setPieceHorizontalMargin.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPieceInclinedMargin;
#pragma warning disable 0169
		static Delegate GetGetPieceInclinedMarginHandler ()
		{
			if (cb_getPieceInclinedMargin == null)
				cb_getPieceInclinedMargin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPieceInclinedMargin);
			return cb_getPieceInclinedMargin;
		}

		static float n_GetPieceInclinedMargin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PieceInclinedMargin;
		}
#pragma warning restore 0169

		static Delegate cb_setPieceInclinedMargin_F;
#pragma warning disable 0169
		static Delegate GetSetPieceInclinedMargin_FHandler ()
		{
			if (cb_setPieceInclinedMargin_F == null)
				cb_setPieceInclinedMargin_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPieceInclinedMargin_F);
			return cb_setPieceInclinedMargin_F;
		}

		static void n_SetPieceInclinedMargin_F (IntPtr jnienv, IntPtr native__this, float pieceInclinedMargin)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PieceInclinedMargin = pieceInclinedMargin;
		}
#pragma warning restore 0169

		public virtual unsafe float PieceInclinedMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getPieceInclinedMargin' and count(parameter)=0]"
			[Register ("getPieceInclinedMargin", "()F", "GetGetPieceInclinedMarginHandler")]
			get {
				const string __id = "getPieceInclinedMargin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setPieceInclinedMargin' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPieceInclinedMargin", "(F)V", "GetSetPieceInclinedMargin_FHandler")]
			set {
				const string __id = "setPieceInclinedMargin.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPiecePlaceEnum;
#pragma warning disable 0169
		static Delegate GetGetPiecePlaceEnumHandler ()
		{
			if (cb_getPiecePlaceEnum == null)
				cb_getPiecePlaceEnum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPiecePlaceEnum);
			return cb_getPiecePlaceEnum;
		}

		static IntPtr n_GetPiecePlaceEnum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PiecePlaceEnum);
		}
#pragma warning restore 0169

		static Delegate cb_setPiecePlaceEnum_Lcom_nightonke_boommenu_Piece_PiecePlaceEnum_;
#pragma warning disable 0169
		static Delegate GetSetPiecePlaceEnum_Lcom_nightonke_boommenu_Piece_PiecePlaceEnum_Handler ()
		{
			if (cb_setPiecePlaceEnum_Lcom_nightonke_boommenu_Piece_PiecePlaceEnum_ == null)
				cb_setPiecePlaceEnum_Lcom_nightonke_boommenu_Piece_PiecePlaceEnum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPiecePlaceEnum_Lcom_nightonke_boommenu_Piece_PiecePlaceEnum_);
			return cb_setPiecePlaceEnum_Lcom_nightonke_boommenu_Piece_PiecePlaceEnum_;
		}

		static void n_SetPiecePlaceEnum_Lcom_nightonke_boommenu_Piece_PiecePlaceEnum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_piecePlaceEnum)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.Piece.PiecePlaceEnum piecePlaceEnum = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Piece.PiecePlaceEnum> (native_piecePlaceEnum, JniHandleOwnership.DoNotTransfer);
			__this.PiecePlaceEnum = piecePlaceEnum;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Nightonke.Boommenu.Piece.PiecePlaceEnum PiecePlaceEnum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getPiecePlaceEnum' and count(parameter)=0]"
			[Register ("getPiecePlaceEnum", "()Lcom/nightonke/boommenu/Piece/PiecePlaceEnum;", "GetGetPiecePlaceEnumHandler")]
			get {
				const string __id = "getPiecePlaceEnum.()Lcom/nightonke/boommenu/Piece/PiecePlaceEnum;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Piece.PiecePlaceEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setPiecePlaceEnum' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.Piece.PiecePlaceEnum']]"
			[Register ("setPiecePlaceEnum", "(Lcom/nightonke/boommenu/Piece/PiecePlaceEnum;)V", "GetSetPiecePlaceEnum_Lcom_nightonke_boommenu_Piece_PiecePlaceEnum_Handler")]
			set {
				const string __id = "setPiecePlaceEnum.(Lcom/nightonke/boommenu/Piece/PiecePlaceEnum;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPieceVerticalMargin;
#pragma warning disable 0169
		static Delegate GetGetPieceVerticalMarginHandler ()
		{
			if (cb_getPieceVerticalMargin == null)
				cb_getPieceVerticalMargin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPieceVerticalMargin);
			return cb_getPieceVerticalMargin;
		}

		static float n_GetPieceVerticalMargin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PieceVerticalMargin;
		}
#pragma warning restore 0169

		static Delegate cb_setPieceVerticalMargin_F;
#pragma warning disable 0169
		static Delegate GetSetPieceVerticalMargin_FHandler ()
		{
			if (cb_setPieceVerticalMargin_F == null)
				cb_setPieceVerticalMargin_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPieceVerticalMargin_F);
			return cb_setPieceVerticalMargin_F;
		}

		static void n_SetPieceVerticalMargin_F (IntPtr jnienv, IntPtr native__this, float pieceVerticalMargin)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PieceVerticalMargin = pieceVerticalMargin;
		}
#pragma warning restore 0169

		public virtual unsafe float PieceVerticalMargin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getPieceVerticalMargin' and count(parameter)=0]"
			[Register ("getPieceVerticalMargin", "()F", "GetGetPieceVerticalMarginHandler")]
			get {
				const string __id = "getPieceVerticalMargin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setPieceVerticalMargin' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPieceVerticalMargin", "(F)V", "GetSetPieceVerticalMargin_FHandler")]
			set {
				const string __id = "setPieceVerticalMargin.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isRippleEffect;
#pragma warning disable 0169
		static Delegate GetIsRippleEffectHandler ()
		{
			if (cb_isRippleEffect == null)
				cb_isRippleEffect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRippleEffect);
			return cb_isRippleEffect;
		}

		static bool n_IsRippleEffect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RippleEffect;
		}
#pragma warning restore 0169

		static Delegate cb_setRippleEffect_Z;
#pragma warning disable 0169
		static Delegate GetSetRippleEffect_ZHandler ()
		{
			if (cb_setRippleEffect_Z == null)
				cb_setRippleEffect_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRippleEffect_Z);
			return cb_setRippleEffect_Z;
		}

		static void n_SetRippleEffect_Z (IntPtr jnienv, IntPtr native__this, bool rippleEffect)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RippleEffect = rippleEffect;
		}
#pragma warning restore 0169

		public virtual unsafe bool RippleEffect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isRippleEffect' and count(parameter)=0]"
			[Register ("isRippleEffect", "()Z", "GetIsRippleEffectHandler")]
			get {
				const string __id = "isRippleEffect.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setRippleEffect' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRippleEffect", "(Z)V", "GetSetRippleEffect_ZHandler")]
			set {
				const string __id = "setRippleEffect.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRotateDegree;
#pragma warning disable 0169
		static Delegate GetGetRotateDegreeHandler ()
		{
			if (cb_getRotateDegree == null)
				cb_getRotateDegree = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRotateDegree);
			return cb_getRotateDegree;
		}

		static int n_GetRotateDegree (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RotateDegree;
		}
#pragma warning restore 0169

		static Delegate cb_setRotateDegree_I;
#pragma warning disable 0169
		static Delegate GetSetRotateDegree_IHandler ()
		{
			if (cb_setRotateDegree_I == null)
				cb_setRotateDegree_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRotateDegree_I);
			return cb_setRotateDegree_I;
		}

		static void n_SetRotateDegree_I (IntPtr jnienv, IntPtr native__this, int rotateDegree)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RotateDegree = rotateDegree;
		}
#pragma warning restore 0169

		public virtual unsafe int RotateDegree {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getRotateDegree' and count(parameter)=0]"
			[Register ("getRotateDegree", "()I", "GetGetRotateDegreeHandler")]
			get {
				const string __id = "getRotateDegree.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setRotateDegree' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRotateDegree", "(I)V", "GetSetRotateDegree_IHandler")]
			set {
				const string __id = "setRotateDegree.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShadowColor;
#pragma warning disable 0169
		static Delegate GetGetShadowColorHandler ()
		{
			if (cb_getShadowColor == null)
				cb_getShadowColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetShadowColor);
			return cb_getShadowColor;
		}

		static int n_GetShadowColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowColor;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowColor_I;
#pragma warning disable 0169
		static Delegate GetSetShadowColor_IHandler ()
		{
			if (cb_setShadowColor_I == null)
				cb_setShadowColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShadowColor_I);
			return cb_setShadowColor_I;
		}

		static void n_SetShadowColor_I (IntPtr jnienv, IntPtr native__this, int shadowColor)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowColor = shadowColor;
		}
#pragma warning restore 0169

		public virtual unsafe int ShadowColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getShadowColor' and count(parameter)=0]"
			[Register ("getShadowColor", "()I", "GetGetShadowColorHandler")]
			get {
				const string __id = "getShadowColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setShadowColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShadowColor", "(I)V", "GetSetShadowColor_IHandler")]
			set {
				const string __id = "setShadowColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isShadowEffect;
#pragma warning disable 0169
		static Delegate GetIsShadowEffectHandler ()
		{
			if (cb_isShadowEffect == null)
				cb_isShadowEffect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShadowEffect);
			return cb_isShadowEffect;
		}

		static bool n_IsShadowEffect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowEffect;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowEffect_Z;
#pragma warning disable 0169
		static Delegate GetSetShadowEffect_ZHandler ()
		{
			if (cb_setShadowEffect_Z == null)
				cb_setShadowEffect_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShadowEffect_Z);
			return cb_setShadowEffect_Z;
		}

		static void n_SetShadowEffect_Z (IntPtr jnienv, IntPtr native__this, bool shadowEffect)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowEffect = shadowEffect;
		}
#pragma warning restore 0169

		public virtual unsafe bool ShadowEffect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isShadowEffect' and count(parameter)=0]"
			[Register ("isShadowEffect", "()Z", "GetIsShadowEffectHandler")]
			get {
				const string __id = "isShadowEffect.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setShadowEffect' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShadowEffect", "(Z)V", "GetSetShadowEffect_ZHandler")]
			set {
				const string __id = "setShadowEffect.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShadowOffsetX;
#pragma warning disable 0169
		static Delegate GetGetShadowOffsetXHandler ()
		{
			if (cb_getShadowOffsetX == null)
				cb_getShadowOffsetX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetShadowOffsetX);
			return cb_getShadowOffsetX;
		}

		static int n_GetShadowOffsetX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowOffsetX;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowOffsetX_I;
#pragma warning disable 0169
		static Delegate GetSetShadowOffsetX_IHandler ()
		{
			if (cb_setShadowOffsetX_I == null)
				cb_setShadowOffsetX_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShadowOffsetX_I);
			return cb_setShadowOffsetX_I;
		}

		static void n_SetShadowOffsetX_I (IntPtr jnienv, IntPtr native__this, int shadowOffsetX)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowOffsetX = shadowOffsetX;
		}
#pragma warning restore 0169

		public virtual unsafe int ShadowOffsetX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getShadowOffsetX' and count(parameter)=0]"
			[Register ("getShadowOffsetX", "()I", "GetGetShadowOffsetXHandler")]
			get {
				const string __id = "getShadowOffsetX.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setShadowOffsetX' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShadowOffsetX", "(I)V", "GetSetShadowOffsetX_IHandler")]
			set {
				const string __id = "setShadowOffsetX.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShadowOffsetY;
#pragma warning disable 0169
		static Delegate GetGetShadowOffsetYHandler ()
		{
			if (cb_getShadowOffsetY == null)
				cb_getShadowOffsetY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetShadowOffsetY);
			return cb_getShadowOffsetY;
		}

		static int n_GetShadowOffsetY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowOffsetY;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowOffsetY_I;
#pragma warning disable 0169
		static Delegate GetSetShadowOffsetY_IHandler ()
		{
			if (cb_setShadowOffsetY_I == null)
				cb_setShadowOffsetY_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShadowOffsetY_I);
			return cb_setShadowOffsetY_I;
		}

		static void n_SetShadowOffsetY_I (IntPtr jnienv, IntPtr native__this, int shadowOffsetY)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowOffsetY = shadowOffsetY;
		}
#pragma warning restore 0169

		public virtual unsafe int ShadowOffsetY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getShadowOffsetY' and count(parameter)=0]"
			[Register ("getShadowOffsetY", "()I", "GetGetShadowOffsetYHandler")]
			get {
				const string __id = "getShadowOffsetY.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setShadowOffsetY' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShadowOffsetY", "(I)V", "GetSetShadowOffsetY_IHandler")]
			set {
				const string __id = "setShadowOffsetY.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShadowRadius;
#pragma warning disable 0169
		static Delegate GetGetShadowRadiusHandler ()
		{
			if (cb_getShadowRadius == null)
				cb_getShadowRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetShadowRadius);
			return cb_getShadowRadius;
		}

		static int n_GetShadowRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowRadius_I;
#pragma warning disable 0169
		static Delegate GetSetShadowRadius_IHandler ()
		{
			if (cb_setShadowRadius_I == null)
				cb_setShadowRadius_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShadowRadius_I);
			return cb_setShadowRadius_I;
		}

		static void n_SetShadowRadius_I (IntPtr jnienv, IntPtr native__this, int shadowRadius)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowRadius = shadowRadius;
		}
#pragma warning restore 0169

		public virtual unsafe int ShadowRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getShadowRadius' and count(parameter)=0]"
			[Register ("getShadowRadius", "()I", "GetGetShadowRadiusHandler")]
			get {
				const string __id = "getShadowRadius.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setShadowRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShadowRadius", "(I)V", "GetSetShadowRadius_IHandler")]
			set {
				const string __id = "setShadowRadius.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShareLine1Color;
#pragma warning disable 0169
		static Delegate GetGetShareLine1ColorHandler ()
		{
			if (cb_getShareLine1Color == null)
				cb_getShareLine1Color = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetShareLine1Color);
			return cb_getShareLine1Color;
		}

		static int n_GetShareLine1Color (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShareLine1Color;
		}
#pragma warning restore 0169

		static Delegate cb_setShareLine1Color_I;
#pragma warning disable 0169
		static Delegate GetSetShareLine1Color_IHandler ()
		{
			if (cb_setShareLine1Color_I == null)
				cb_setShareLine1Color_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShareLine1Color_I);
			return cb_setShareLine1Color_I;
		}

		static void n_SetShareLine1Color_I (IntPtr jnienv, IntPtr native__this, int shareLine1Color)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShareLine1Color = shareLine1Color;
		}
#pragma warning restore 0169

		public virtual unsafe int ShareLine1Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getShareLine1Color' and count(parameter)=0]"
			[Register ("getShareLine1Color", "()I", "GetGetShareLine1ColorHandler")]
			get {
				const string __id = "getShareLine1Color.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setShareLine1Color' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShareLine1Color", "(I)V", "GetSetShareLine1Color_IHandler")]
			set {
				const string __id = "setShareLine1Color.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShareLine2Color;
#pragma warning disable 0169
		static Delegate GetGetShareLine2ColorHandler ()
		{
			if (cb_getShareLine2Color == null)
				cb_getShareLine2Color = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetShareLine2Color);
			return cb_getShareLine2Color;
		}

		static int n_GetShareLine2Color (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShareLine2Color;
		}
#pragma warning restore 0169

		static Delegate cb_setShareLine2Color_I;
#pragma warning disable 0169
		static Delegate GetSetShareLine2Color_IHandler ()
		{
			if (cb_setShareLine2Color_I == null)
				cb_setShareLine2Color_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShareLine2Color_I);
			return cb_setShareLine2Color_I;
		}

		static void n_SetShareLine2Color_I (IntPtr jnienv, IntPtr native__this, int shareLine2Color)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShareLine2Color = shareLine2Color;
		}
#pragma warning restore 0169

		public virtual unsafe int ShareLine2Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getShareLine2Color' and count(parameter)=0]"
			[Register ("getShareLine2Color", "()I", "GetGetShareLine2ColorHandler")]
			get {
				const string __id = "getShareLine2Color.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setShareLine2Color' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShareLine2Color", "(I)V", "GetSetShareLine2Color_IHandler")]
			set {
				const string __id = "setShareLine2Color.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShareLineLength;
#pragma warning disable 0169
		static Delegate GetGetShareLineLengthHandler ()
		{
			if (cb_getShareLineLength == null)
				cb_getShareLineLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetShareLineLength);
			return cb_getShareLineLength;
		}

		static float n_GetShareLineLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShareLineLength;
		}
#pragma warning restore 0169

		static Delegate cb_setShareLineLength_F;
#pragma warning disable 0169
		static Delegate GetSetShareLineLength_FHandler ()
		{
			if (cb_setShareLineLength_F == null)
				cb_setShareLineLength_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetShareLineLength_F);
			return cb_setShareLineLength_F;
		}

		static void n_SetShareLineLength_F (IntPtr jnienv, IntPtr native__this, float shareLineLength)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShareLineLength = shareLineLength;
		}
#pragma warning restore 0169

		public virtual unsafe float ShareLineLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getShareLineLength' and count(parameter)=0]"
			[Register ("getShareLineLength", "()F", "GetGetShareLineLengthHandler")]
			get {
				const string __id = "getShareLineLength.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setShareLineLength' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setShareLineLength", "(F)V", "GetSetShareLineLength_FHandler")]
			set {
				const string __id = "setShareLineLength.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShareLineWidth;
#pragma warning disable 0169
		static Delegate GetGetShareLineWidthHandler ()
		{
			if (cb_getShareLineWidth == null)
				cb_getShareLineWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetShareLineWidth);
			return cb_getShareLineWidth;
		}

		static float n_GetShareLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShareLineWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setShareLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetShareLineWidth_FHandler ()
		{
			if (cb_setShareLineWidth_F == null)
				cb_setShareLineWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetShareLineWidth_F);
			return cb_setShareLineWidth_F;
		}

		static void n_SetShareLineWidth_F (IntPtr jnienv, IntPtr native__this, float shareLineWidth)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShareLineWidth = shareLineWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float ShareLineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getShareLineWidth' and count(parameter)=0]"
			[Register ("getShareLineWidth", "()F", "GetGetShareLineWidthHandler")]
			get {
				const string __id = "getShareLineWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setShareLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setShareLineWidth", "(F)V", "GetSetShareLineWidth_FHandler")]
			set {
				const string __id = "setShareLineWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShowDelay;
#pragma warning disable 0169
		static Delegate GetGetShowDelayHandler ()
		{
			if (cb_getShowDelay == null)
				cb_getShowDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetShowDelay);
			return cb_getShowDelay;
		}

		static long n_GetShowDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowDelay;
		}
#pragma warning restore 0169

		static Delegate cb_setShowDelay_J;
#pragma warning disable 0169
		static Delegate GetSetShowDelay_JHandler ()
		{
			if (cb_setShowDelay_J == null)
				cb_setShowDelay_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetShowDelay_J);
			return cb_setShowDelay_J;
		}

		static void n_SetShowDelay_J (IntPtr jnienv, IntPtr native__this, long showDelay)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowDelay = showDelay;
		}
#pragma warning restore 0169

		public virtual unsafe long ShowDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getShowDelay' and count(parameter)=0]"
			[Register ("getShowDelay", "()J", "GetGetShowDelayHandler")]
			get {
				const string __id = "getShowDelay.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setShowDelay' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setShowDelay", "(J)V", "GetSetShowDelay_JHandler")]
			set {
				const string __id = "setShowDelay.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShowDuration;
#pragma warning disable 0169
		static Delegate GetGetShowDurationHandler ()
		{
			if (cb_getShowDuration == null)
				cb_getShowDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetShowDuration);
			return cb_getShowDuration;
		}

		static long n_GetShowDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowDuration;
		}
#pragma warning restore 0169

		static Delegate cb_setShowDuration_J;
#pragma warning disable 0169
		static Delegate GetSetShowDuration_JHandler ()
		{
			if (cb_setShowDuration_J == null)
				cb_setShowDuration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetShowDuration_J);
			return cb_setShowDuration_J;
		}

		static void n_SetShowDuration_J (IntPtr jnienv, IntPtr native__this, long showDuration)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowDuration = showDuration;
		}
#pragma warning restore 0169

		public virtual unsafe long ShowDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getShowDuration' and count(parameter)=0]"
			[Register ("getShowDuration", "()J", "GetGetShowDurationHandler")]
			get {
				const string __id = "getShowDuration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setShowDuration' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setShowDuration", "(J)V", "GetSetShowDuration_JHandler")]
			set {
				const string __id = "setShowDuration.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShowMoveEaseEnum;
#pragma warning disable 0169
		static Delegate GetGetShowMoveEaseEnumHandler ()
		{
			if (cb_getShowMoveEaseEnum == null)
				cb_getShowMoveEaseEnum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShowMoveEaseEnum);
			return cb_getShowMoveEaseEnum;
		}

		static IntPtr n_GetShowMoveEaseEnum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowMoveEaseEnum);
		}
#pragma warning restore 0169

		static Delegate cb_setShowMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
#pragma warning disable 0169
		static Delegate GetSetShowMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler ()
		{
			if (cb_setShowMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ == null)
				cb_setShowMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShowMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_);
			return cb_setShowMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
		}

		static void n_SetShowMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_showMoveEaseEnum)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.Animation.EaseEnum showMoveEaseEnum = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.EaseEnum> (native_showMoveEaseEnum, JniHandleOwnership.DoNotTransfer);
			__this.ShowMoveEaseEnum = showMoveEaseEnum;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Nightonke.Boommenu.Animation.EaseEnum ShowMoveEaseEnum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getShowMoveEaseEnum' and count(parameter)=0]"
			[Register ("getShowMoveEaseEnum", "()Lcom/nightonke/boommenu/Animation/EaseEnum;", "GetGetShowMoveEaseEnumHandler")]
			get {
				const string __id = "getShowMoveEaseEnum.()Lcom/nightonke/boommenu/Animation/EaseEnum;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.EaseEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setShowMoveEaseEnum' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.Animation.EaseEnum']]"
			[Register ("setShowMoveEaseEnum", "(Lcom/nightonke/boommenu/Animation/EaseEnum;)V", "GetSetShowMoveEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler")]
			set {
				const string __id = "setShowMoveEaseEnum.(Lcom/nightonke/boommenu/Animation/EaseEnum;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShowRotateEaseEnum;
#pragma warning disable 0169
		static Delegate GetGetShowRotateEaseEnumHandler ()
		{
			if (cb_getShowRotateEaseEnum == null)
				cb_getShowRotateEaseEnum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShowRotateEaseEnum);
			return cb_getShowRotateEaseEnum;
		}

		static IntPtr n_GetShowRotateEaseEnum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowRotateEaseEnum);
		}
#pragma warning restore 0169

		static Delegate cb_setShowRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
#pragma warning disable 0169
		static Delegate GetSetShowRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler ()
		{
			if (cb_setShowRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ == null)
				cb_setShowRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShowRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_);
			return cb_setShowRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
		}

		static void n_SetShowRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_showRotateEaseEnum)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.Animation.EaseEnum showRotateEaseEnum = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.EaseEnum> (native_showRotateEaseEnum, JniHandleOwnership.DoNotTransfer);
			__this.ShowRotateEaseEnum = showRotateEaseEnum;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Nightonke.Boommenu.Animation.EaseEnum ShowRotateEaseEnum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getShowRotateEaseEnum' and count(parameter)=0]"
			[Register ("getShowRotateEaseEnum", "()Lcom/nightonke/boommenu/Animation/EaseEnum;", "GetGetShowRotateEaseEnumHandler")]
			get {
				const string __id = "getShowRotateEaseEnum.()Lcom/nightonke/boommenu/Animation/EaseEnum;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.EaseEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setShowRotateEaseEnum' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.Animation.EaseEnum']]"
			[Register ("setShowRotateEaseEnum", "(Lcom/nightonke/boommenu/Animation/EaseEnum;)V", "GetSetShowRotateEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler")]
			set {
				const string __id = "setShowRotateEaseEnum.(Lcom/nightonke/boommenu/Animation/EaseEnum;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShowScaleEaseEnum;
#pragma warning disable 0169
		static Delegate GetGetShowScaleEaseEnumHandler ()
		{
			if (cb_getShowScaleEaseEnum == null)
				cb_getShowScaleEaseEnum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShowScaleEaseEnum);
			return cb_getShowScaleEaseEnum;
		}

		static IntPtr n_GetShowScaleEaseEnum (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowScaleEaseEnum);
		}
#pragma warning restore 0169

		static Delegate cb_setShowScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
#pragma warning disable 0169
		static Delegate GetSetShowScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler ()
		{
			if (cb_setShowScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ == null)
				cb_setShowScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShowScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_);
			return cb_setShowScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
		}

		static void n_SetShowScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_showScaleEaseEnum)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.Animation.EaseEnum showScaleEaseEnum = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.EaseEnum> (native_showScaleEaseEnum, JniHandleOwnership.DoNotTransfer);
			__this.ShowScaleEaseEnum = showScaleEaseEnum;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Nightonke.Boommenu.Animation.EaseEnum ShowScaleEaseEnum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getShowScaleEaseEnum' and count(parameter)=0]"
			[Register ("getShowScaleEaseEnum", "()Lcom/nightonke/boommenu/Animation/EaseEnum;", "GetGetShowScaleEaseEnumHandler")]
			get {
				const string __id = "getShowScaleEaseEnum.()Lcom/nightonke/boommenu/Animation/EaseEnum;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.EaseEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setShowScaleEaseEnum' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.Animation.EaseEnum']]"
			[Register ("setShowScaleEaseEnum", "(Lcom/nightonke/boommenu/Animation/EaseEnum;)V", "GetSetShowScaleEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler")]
			set {
				const string __id = "setShowScaleEaseEnum.(Lcom/nightonke/boommenu/Animation/EaseEnum;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUnableColor;
#pragma warning disable 0169
		static Delegate GetGetUnableColorHandler ()
		{
			if (cb_getUnableColor == null)
				cb_getUnableColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUnableColor);
			return cb_getUnableColor;
		}

		static int n_GetUnableColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnableColor;
		}
#pragma warning restore 0169

		static Delegate cb_setUnableColor_I;
#pragma warning disable 0169
		static Delegate GetSetUnableColor_IHandler ()
		{
			if (cb_setUnableColor_I == null)
				cb_setUnableColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUnableColor_I);
			return cb_setUnableColor_I;
		}

		static void n_SetUnableColor_I (IntPtr jnienv, IntPtr native__this, int unableColor)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnableColor = unableColor;
		}
#pragma warning restore 0169

		public virtual unsafe int UnableColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getUnableColor' and count(parameter)=0]"
			[Register ("getUnableColor", "()I", "GetGetUnableColorHandler")]
			get {
				const string __id = "getUnableColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setUnableColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUnableColor", "(I)V", "GetSetUnableColor_IHandler")]
			set {
				const string __id = "setUnableColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUse3DTransformAnimation;
#pragma warning disable 0169
		static Delegate GetIsUse3DTransformAnimationHandler ()
		{
			if (cb_isUse3DTransformAnimation == null)
				cb_isUse3DTransformAnimation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUse3DTransformAnimation);
			return cb_isUse3DTransformAnimation;
		}

		static bool n_IsUse3DTransformAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Use3DTransformAnimation;
		}
#pragma warning restore 0169

		static Delegate cb_setUse3DTransformAnimation_Z;
#pragma warning disable 0169
		static Delegate GetSetUse3DTransformAnimation_ZHandler ()
		{
			if (cb_setUse3DTransformAnimation_Z == null)
				cb_setUse3DTransformAnimation_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUse3DTransformAnimation_Z);
			return cb_setUse3DTransformAnimation_Z;
		}

		static void n_SetUse3DTransformAnimation_Z (IntPtr jnienv, IntPtr native__this, bool use3DTransformAnimation)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Use3DTransformAnimation = use3DTransformAnimation;
		}
#pragma warning restore 0169

		public virtual unsafe bool Use3DTransformAnimation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='isUse3DTransformAnimation' and count(parameter)=0]"
			[Register ("isUse3DTransformAnimation", "()Z", "GetIsUse3DTransformAnimationHandler")]
			get {
				const string __id = "isUse3DTransformAnimation.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setUse3DTransformAnimation' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUse3DTransformAnimation", "(Z)V", "GetSetUse3DTransformAnimation_ZHandler")]
			set {
				const string __id = "setUse3DTransformAnimation.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_addBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_;
#pragma warning disable 0169
		static Delegate GetAddBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_Handler ()
		{
			if (cb_addBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_ == null)
				cb_addBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_);
			return cb_addBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_;
		}

		static void n_AddBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder builder = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
			__this.AddBuilder (builder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='addBuilder' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.BoomButtons.BoomButtonBuilder']]"
		[Register ("addBuilder", "(Lcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;)V", "GetAddBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_Handler")]
		public virtual unsafe void AddBuilder (global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder builder)
		{
			const string __id = "addBuilder.(Lcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_boom;
#pragma warning disable 0169
		static Delegate GetBoomHandler ()
		{
			if (cb_boom == null)
				cb_boom = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Boom);
			return cb_boom;
		}

		static void n_Boom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Boom ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='boom' and count(parameter)=0]"
		[Register ("boom", "()V", "GetBoomHandler")]
		public virtual unsafe void Boom ()
		{
			const string __id = "boom.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_boomImmediately;
#pragma warning disable 0169
		static Delegate GetBoomImmediatelyHandler ()
		{
			if (cb_boomImmediately == null)
				cb_boomImmediately = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BoomImmediately);
			return cb_boomImmediately;
		}

		static void n_BoomImmediately (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BoomImmediately ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='boomImmediately' and count(parameter)=0]"
		[Register ("boomImmediately", "()V", "GetBoomImmediatelyHandler")]
		public virtual unsafe void BoomImmediately ()
		{
			const string __id = "boomImmediately.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearBuilders;
#pragma warning disable 0169
		static Delegate GetClearBuildersHandler ()
		{
			if (cb_clearBuilders == null)
				cb_clearBuilders = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearBuilders);
			return cb_clearBuilders;
		}

		static void n_ClearBuilders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearBuilders ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='clearBuilders' and count(parameter)=0]"
		[Register ("clearBuilders", "()V", "GetClearBuildersHandler")]
		public virtual unsafe void ClearBuilders ()
		{
			const string __id = "clearBuilders.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getBoomButton_I;
#pragma warning disable 0169
		static Delegate GetGetBoomButton_IHandler ()
		{
			if (cb_getBoomButton_I == null)
				cb_getBoomButton_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetBoomButton_I);
			return cb_getBoomButton_I;
		}

		static IntPtr n_GetBoomButton_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetBoomButton (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getBoomButton' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBoomButton", "(I)Lcom/nightonke/boommenu/BoomButtons/BoomButton;", "GetGetBoomButton_IHandler")]
		public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.BoomButton GetBoomButton (int index)
		{
			const string __id = "getBoomButton.(I)Lcom/nightonke/boommenu/BoomButtons/BoomButton;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getBuilder_I;
#pragma warning disable 0169
		static Delegate GetGetBuilder_IHandler ()
		{
			if (cb_getBuilder_I == null)
				cb_getBuilder_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetBuilder_I);
			return cb_getBuilder_I;
		}

		static IntPtr n_GetBuilder_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetBuilder (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='getBuilder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBuilder", "(I)Lcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;", "GetGetBuilder_IHandler")]
		public virtual unsafe global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder GetBuilder (int index)
		{
			const string __id = "getBuilder.(I)Lcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onBackgroundClicked;
#pragma warning disable 0169
		static Delegate GetOnBackgroundClickedHandler ()
		{
			if (cb_onBackgroundClicked == null)
				cb_onBackgroundClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBackgroundClicked);
			return cb_onBackgroundClicked;
		}

		static void n_OnBackgroundClicked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBackgroundClicked ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='onBackgroundClicked' and count(parameter)=0]"
		[Register ("onBackgroundClicked", "()V", "GetOnBackgroundClickedHandler")]
		protected virtual unsafe void OnBackgroundClicked ()
		{
			const string __id = "onBackgroundClicked.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_;
#pragma warning disable 0169
		static Delegate GetOnButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_Handler ()
		{
			if (cb_onButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ == null)
				cb_onButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_);
			return cb_onButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_;
		}

		static void n_OnButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_boomButton)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton boomButton = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (native_boomButton, JniHandleOwnership.DoNotTransfer);
			__this.OnButtonClick (index, boomButton);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='onButtonClick' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.nightonke.boommenu.BoomButtons.BoomButton']]"
		[Register ("onButtonClick", "(ILcom/nightonke/boommenu/BoomButtons/BoomButton;)V", "GetOnButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_Handler")]
		public virtual unsafe void OnButtonClick (int index, global::Com.Nightonke.Boommenu.BoomButtons.BoomButton boomButton)
		{
			const string __id = "onButtonClick.(ILcom/nightonke/boommenu/BoomButtons/BoomButton;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((boomButton == null) ? IntPtr.Zero : ((global::Java.Lang.Object) boomButton).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reboom;
#pragma warning disable 0169
		static Delegate GetReboomHandler ()
		{
			if (cb_reboom == null)
				cb_reboom = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reboom);
			return cb_reboom;
		}

		static void n_Reboom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reboom ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='reboom' and count(parameter)=0]"
		[Register ("reboom", "()V", "GetReboomHandler")]
		public virtual unsafe void Reboom ()
		{
			const string __id = "reboom.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reboomImmediately;
#pragma warning disable 0169
		static Delegate GetReboomImmediatelyHandler ()
		{
			if (cb_reboomImmediately == null)
				cb_reboomImmediately = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReboomImmediately);
			return cb_reboomImmediately;
		}

		static void n_ReboomImmediately (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReboomImmediately ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='reboomImmediately' and count(parameter)=0]"
		[Register ("reboomImmediately", "()V", "GetReboomImmediatelyHandler")]
		public virtual unsafe void ReboomImmediately ()
		{
			const string __id = "reboomImmediately.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_;
#pragma warning disable 0169
		static Delegate GetRemoveBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_Handler ()
		{
			if (cb_removeBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_ == null)
				cb_removeBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_);
			return cb_removeBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_;
		}

		static void n_RemoveBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder builder = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
			__this.RemoveBuilder (builder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='removeBuilder' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.BoomButtons.BoomButtonBuilder']]"
		[Register ("removeBuilder", "(Lcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;)V", "GetRemoveBuilder_Lcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_Handler")]
		public virtual unsafe void RemoveBuilder (global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder builder)
		{
			const string __id = "removeBuilder.(Lcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeBuilder_I;
#pragma warning disable 0169
		static Delegate GetRemoveBuilder_IHandler ()
		{
			if (cb_removeBuilder_I == null)
				cb_removeBuilder_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveBuilder_I);
			return cb_removeBuilder_I;
		}

		static void n_RemoveBuilder_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveBuilder (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='removeBuilder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeBuilder", "(I)V", "GetRemoveBuilder_IHandler")]
		public virtual unsafe void RemoveBuilder (int index)
		{
			const string __id = "removeBuilder.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBuilder_ILcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_;
#pragma warning disable 0169
		static Delegate GetSetBuilder_ILcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_Handler ()
		{
			if (cb_setBuilder_ILcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_ == null)
				cb_setBuilder_ILcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetBuilder_ILcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_);
			return cb_setBuilder_ILcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_;
		}

		static void n_SetBuilder_ILcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_builder)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder builder = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder> (native_builder, JniHandleOwnership.DoNotTransfer);
			__this.SetBuilder (index, builder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setBuilder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.nightonke.boommenu.BoomButtons.BoomButtonBuilder']]"
		[Register ("setBuilder", "(ILcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;)V", "GetSetBuilder_ILcom_nightonke_boommenu_BoomButtons_BoomButtonBuilder_Handler")]
		public virtual unsafe void SetBuilder (int index, global::Com.Nightonke.Boommenu.BoomButtons.BoomButtonBuilder builder)
		{
			const string __id = "setBuilder.(ILcom/nightonke/boommenu/BoomButtons/BoomButtonBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((builder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) builder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDelay_J;
#pragma warning disable 0169
		static Delegate GetSetDelay_JHandler ()
		{
			if (cb_setDelay_J == null)
				cb_setDelay_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetDelay_J);
			return cb_setDelay_J;
		}

		static void n_SetDelay_J (IntPtr jnienv, IntPtr native__this, long delay)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDelay (delay);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setDelay' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDelay", "(J)V", "GetSetDelay_JHandler")]
		public virtual unsafe void SetDelay (long delay)
		{
			const string __id = "setDelay.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (delay);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDuration_J;
#pragma warning disable 0169
		static Delegate GetSetDuration_JHandler ()
		{
			if (cb_setDuration_J == null)
				cb_setDuration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetDuration_J);
			return cb_setDuration_J;
		}

		static void n_SetDuration_J (IntPtr jnienv, IntPtr native__this, long duration)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDuration (duration);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDuration", "(J)V", "GetSetDuration_JHandler")]
		public virtual unsafe void SetDuration (long duration)
		{
			const string __id = "setDuration.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (duration);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setEnable_IZ;
#pragma warning disable 0169
		static Delegate GetSetEnable_IZHandler ()
		{
			if (cb_setEnable_IZ == null)
				cb_setEnable_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetEnable_IZ);
			return cb_setEnable_IZ;
		}

		static void n_SetEnable_IZ (IntPtr jnienv, IntPtr native__this, int index, bool enable)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEnable (index, enable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setEnable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setEnable", "(IZ)V", "GetSetEnable_IZHandler")]
		public virtual unsafe void SetEnable (int index, bool enable)
		{
			const string __id = "setEnable.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (enable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHamHeight_I;
#pragma warning disable 0169
		static Delegate GetSetHamHeight_IHandler ()
		{
			if (cb_setHamHeight_I == null)
				cb_setHamHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHamHeight_I);
			return cb_setHamHeight_I;
		}

		static void n_SetHamHeight_I (IntPtr jnienv, IntPtr native__this, int hamHeight)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHamHeight (hamHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setHamHeight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHamHeight", "(I)V", "GetSetHamHeight_IHandler")]
		public virtual unsafe void SetHamHeight (int hamHeight)
		{
			const string __id = "setHamHeight.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (hamHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHideEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
#pragma warning disable 0169
		static Delegate GetSetHideEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler ()
		{
			if (cb_setHideEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ == null)
				cb_setHideEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHideEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_);
			return cb_setHideEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
		}

		static void n_SetHideEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hideEaseEnum)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.Animation.EaseEnum hideEaseEnum = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.EaseEnum> (native_hideEaseEnum, JniHandleOwnership.DoNotTransfer);
			__this.SetHideEaseEnum (hideEaseEnum);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setHideEaseEnum' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.Animation.EaseEnum']]"
		[Register ("setHideEaseEnum", "(Lcom/nightonke/boommenu/Animation/EaseEnum;)V", "GetSetHideEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler")]
		public virtual unsafe void SetHideEaseEnum (global::Com.Nightonke.Boommenu.Animation.EaseEnum hideEaseEnum)
		{
			const string __id = "setHideEaseEnum.(Lcom/nightonke/boommenu/Animation/EaseEnum;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((hideEaseEnum == null) ? IntPtr.Zero : ((global::Java.Lang.Object) hideEaseEnum).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setShowEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
#pragma warning disable 0169
		static Delegate GetSetShowEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler ()
		{
			if (cb_setShowEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ == null)
				cb_setShowEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShowEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_);
			return cb_setShowEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_;
		}

		static void n_SetShowEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_showEaseEnum)
		{
			global::Com.Nightonke.Boommenu.BoomMenuButton __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomMenuButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.Animation.EaseEnum showEaseEnum = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.EaseEnum> (native_showEaseEnum, JniHandleOwnership.DoNotTransfer);
			__this.SetShowEaseEnum (showEaseEnum);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BoomMenuButton']/method[@name='setShowEaseEnum' and count(parameter)=1 and parameter[1][@type='com.nightonke.boommenu.Animation.EaseEnum']]"
		[Register ("setShowEaseEnum", "(Lcom/nightonke/boommenu/Animation/EaseEnum;)V", "GetSetShowEaseEnum_Lcom_nightonke_boommenu_Animation_EaseEnum_Handler")]
		public virtual unsafe void SetShowEaseEnum (global::Com.Nightonke.Boommenu.Animation.EaseEnum showEaseEnum)
		{
			const string __id = "setShowEaseEnum.(Lcom/nightonke/boommenu/Animation/EaseEnum;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((showEaseEnum == null) ? IntPtr.Zero : ((global::Java.Lang.Object) showEaseEnum).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Nightonke.Boommenu.IOnBoomListener"
		public event EventHandler BackgroundClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nightonke.Boommenu.IOnBoomListener, global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor>(
						ref weak_implementor___SetOnBoomListener,
						__CreateIOnBoomListenerImplementor,
						__v => OnBoomListener = __v,
						__h => __h.OnBackgroundClickHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nightonke.Boommenu.IOnBoomListener, global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor>(
						ref weak_implementor___SetOnBoomListener,
						global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor.__IsEmpty,
						__v => OnBoomListener = null,
						__h => __h.OnBackgroundClickHandler -= value);
			}
		}

		public event EventHandler BoomDidHide {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nightonke.Boommenu.IOnBoomListener, global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor>(
						ref weak_implementor___SetOnBoomListener,
						__CreateIOnBoomListenerImplementor,
						__v => OnBoomListener = __v,
						__h => __h.OnBoomDidHideHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nightonke.Boommenu.IOnBoomListener, global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor>(
						ref weak_implementor___SetOnBoomListener,
						global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor.__IsEmpty,
						__v => OnBoomListener = null,
						__h => __h.OnBoomDidHideHandler -= value);
			}
		}

		public event EventHandler BoomDidShow {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nightonke.Boommenu.IOnBoomListener, global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor>(
						ref weak_implementor___SetOnBoomListener,
						__CreateIOnBoomListenerImplementor,
						__v => OnBoomListener = __v,
						__h => __h.OnBoomDidShowHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nightonke.Boommenu.IOnBoomListener, global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor>(
						ref weak_implementor___SetOnBoomListener,
						global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor.__IsEmpty,
						__v => OnBoomListener = null,
						__h => __h.OnBoomDidShowHandler -= value);
			}
		}

		public event EventHandler BoomWillHide {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nightonke.Boommenu.IOnBoomListener, global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor>(
						ref weak_implementor___SetOnBoomListener,
						__CreateIOnBoomListenerImplementor,
						__v => OnBoomListener = __v,
						__h => __h.OnBoomWillHideHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nightonke.Boommenu.IOnBoomListener, global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor>(
						ref weak_implementor___SetOnBoomListener,
						global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor.__IsEmpty,
						__v => OnBoomListener = null,
						__h => __h.OnBoomWillHideHandler -= value);
			}
		}

		public event EventHandler BoomWillShow {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nightonke.Boommenu.IOnBoomListener, global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor>(
						ref weak_implementor___SetOnBoomListener,
						__CreateIOnBoomListenerImplementor,
						__v => OnBoomListener = __v,
						__h => __h.OnBoomWillShowHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nightonke.Boommenu.IOnBoomListener, global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor>(
						ref weak_implementor___SetOnBoomListener,
						global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor.__IsEmpty,
						__v => OnBoomListener = null,
						__h => __h.OnBoomWillShowHandler -= value);
			}
		}

		public event EventHandler<global::Com.Nightonke.Boommenu.ClickedEventArgs> Clicked {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nightonke.Boommenu.IOnBoomListener, global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor>(
						ref weak_implementor___SetOnBoomListener,
						__CreateIOnBoomListenerImplementor,
						__v => OnBoomListener = __v,
						__h => __h.OnClickedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nightonke.Boommenu.IOnBoomListener, global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor>(
						ref weak_implementor___SetOnBoomListener,
						global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor.__IsEmpty,
						__v => OnBoomListener = null,
						__h => __h.OnClickedHandler -= value);
			}
		}

		WeakReference weak_implementor___SetOnBoomListener;

		global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor __CreateIOnBoomListenerImplementor ()
		{
			return new global::Com.Nightonke.Boommenu.IOnBoomListenerImplementor (this);
		}
#endregion
	}
}
