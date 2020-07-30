using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BMBShadow']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/BMBShadow", DoNotGenerateAcw=true)]
	public partial class BMBShadow : global::Android.Widget.FrameLayout {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/BMBShadow", typeof (BMBShadow));
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

		protected BMBShadow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BMBShadow']/constructor[@name='BMBShadow' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BMBShadow (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BMBShadow']/constructor[@name='BMBShadow' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe BMBShadow (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BMBShadow']/constructor[@name='BMBShadow' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe BMBShadow (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_clearShadow;
#pragma warning disable 0169
		static Delegate GetClearShadowHandler ()
		{
			if (cb_clearShadow == null)
				cb_clearShadow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearShadow);
			return cb_clearShadow;
		}

		static void n_ClearShadow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.BMBShadow __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BMBShadow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearShadow ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BMBShadow']/method[@name='clearShadow' and count(parameter)=0]"
		[Register ("clearShadow", "()V", "GetClearShadowHandler")]
		public virtual unsafe void ClearShadow ()
		{
			const string __id = "clearShadow.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

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
			global::Com.Nightonke.Boommenu.BMBShadow __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BMBShadow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShadowColor (shadowColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BMBShadow']/method[@name='setShadowColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setShadowColor", "(I)V", "GetSetShadowColor_IHandler")]
		public virtual unsafe void SetShadowColor (int shadowColor)
		{
			const string __id = "setShadowColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shadowColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setShadowCornerRadius_I;
#pragma warning disable 0169
		static Delegate GetSetShadowCornerRadius_IHandler ()
		{
			if (cb_setShadowCornerRadius_I == null)
				cb_setShadowCornerRadius_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShadowCornerRadius_I);
			return cb_setShadowCornerRadius_I;
		}

		static void n_SetShadowCornerRadius_I (IntPtr jnienv, IntPtr native__this, int shadowCornerRadius)
		{
			global::Com.Nightonke.Boommenu.BMBShadow __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BMBShadow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShadowCornerRadius (shadowCornerRadius);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BMBShadow']/method[@name='setShadowCornerRadius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setShadowCornerRadius", "(I)V", "GetSetShadowCornerRadius_IHandler")]
		public virtual unsafe void SetShadowCornerRadius (int shadowCornerRadius)
		{
			const string __id = "setShadowCornerRadius.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shadowCornerRadius);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::Com.Nightonke.Boommenu.BMBShadow __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BMBShadow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShadowEffect (shadowEffect);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BMBShadow']/method[@name='setShadowEffect' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShadowEffect", "(Z)V", "GetSetShadowEffect_ZHandler")]
		public virtual unsafe void SetShadowEffect (bool shadowEffect)
		{
			const string __id = "setShadowEffect.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shadowEffect);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::Com.Nightonke.Boommenu.BMBShadow __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BMBShadow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShadowOffsetX (shadowOffsetX);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BMBShadow']/method[@name='setShadowOffsetX' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setShadowOffsetX", "(I)V", "GetSetShadowOffsetX_IHandler")]
		public virtual unsafe void SetShadowOffsetX (int shadowOffsetX)
		{
			const string __id = "setShadowOffsetX.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shadowOffsetX);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::Com.Nightonke.Boommenu.BMBShadow __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BMBShadow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShadowOffsetY (shadowOffsetY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BMBShadow']/method[@name='setShadowOffsetY' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setShadowOffsetY", "(I)V", "GetSetShadowOffsetY_IHandler")]
		public virtual unsafe void SetShadowOffsetY (int shadowOffsetY)
		{
			const string __id = "setShadowOffsetY.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shadowOffsetY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::Com.Nightonke.Boommenu.BMBShadow __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BMBShadow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShadowRadius (shadowRadius);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='BMBShadow']/method[@name='setShadowRadius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setShadowRadius", "(I)V", "GetSetShadowRadius_IHandler")]
		public virtual unsafe void SetShadowRadius (int shadowRadius)
		{
			const string __id = "setShadowRadius.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (shadowRadius);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
