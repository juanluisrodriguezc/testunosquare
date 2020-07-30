using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='OnBoomListenerAdapter']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/OnBoomListenerAdapter", DoNotGenerateAcw=true)]
	public partial class OnBoomListenerAdapter : global::Java.Lang.Object, global::Com.Nightonke.Boommenu.IOnBoomListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/OnBoomListenerAdapter", typeof (OnBoomListenerAdapter));
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

		protected OnBoomListenerAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='OnBoomListenerAdapter']/constructor[@name='OnBoomListenerAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OnBoomListenerAdapter ()
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

		static Delegate cb_onBackgroundClick;
#pragma warning disable 0169
		static Delegate GetOnBackgroundClickHandler ()
		{
			if (cb_onBackgroundClick == null)
				cb_onBackgroundClick = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBackgroundClick);
			return cb_onBackgroundClick;
		}

		static void n_OnBackgroundClick (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.OnBoomListenerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.OnBoomListenerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBackgroundClick ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='OnBoomListenerAdapter']/method[@name='onBackgroundClick' and count(parameter)=0]"
		[Register ("onBackgroundClick", "()V", "GetOnBackgroundClickHandler")]
		public virtual unsafe void OnBackgroundClick ()
		{
			const string __id = "onBackgroundClick.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onBoomDidHide;
#pragma warning disable 0169
		static Delegate GetOnBoomDidHideHandler ()
		{
			if (cb_onBoomDidHide == null)
				cb_onBoomDidHide = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBoomDidHide);
			return cb_onBoomDidHide;
		}

		static void n_OnBoomDidHide (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.OnBoomListenerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.OnBoomListenerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBoomDidHide ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='OnBoomListenerAdapter']/method[@name='onBoomDidHide' and count(parameter)=0]"
		[Register ("onBoomDidHide", "()V", "GetOnBoomDidHideHandler")]
		public virtual unsafe void OnBoomDidHide ()
		{
			const string __id = "onBoomDidHide.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onBoomDidShow;
#pragma warning disable 0169
		static Delegate GetOnBoomDidShowHandler ()
		{
			if (cb_onBoomDidShow == null)
				cb_onBoomDidShow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBoomDidShow);
			return cb_onBoomDidShow;
		}

		static void n_OnBoomDidShow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.OnBoomListenerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.OnBoomListenerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBoomDidShow ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='OnBoomListenerAdapter']/method[@name='onBoomDidShow' and count(parameter)=0]"
		[Register ("onBoomDidShow", "()V", "GetOnBoomDidShowHandler")]
		public virtual unsafe void OnBoomDidShow ()
		{
			const string __id = "onBoomDidShow.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onBoomWillHide;
#pragma warning disable 0169
		static Delegate GetOnBoomWillHideHandler ()
		{
			if (cb_onBoomWillHide == null)
				cb_onBoomWillHide = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBoomWillHide);
			return cb_onBoomWillHide;
		}

		static void n_OnBoomWillHide (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.OnBoomListenerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.OnBoomListenerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBoomWillHide ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='OnBoomListenerAdapter']/method[@name='onBoomWillHide' and count(parameter)=0]"
		[Register ("onBoomWillHide", "()V", "GetOnBoomWillHideHandler")]
		public virtual unsafe void OnBoomWillHide ()
		{
			const string __id = "onBoomWillHide.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onBoomWillShow;
#pragma warning disable 0169
		static Delegate GetOnBoomWillShowHandler ()
		{
			if (cb_onBoomWillShow == null)
				cb_onBoomWillShow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBoomWillShow);
			return cb_onBoomWillShow;
		}

		static void n_OnBoomWillShow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nightonke.Boommenu.OnBoomListenerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.OnBoomListenerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBoomWillShow ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='OnBoomListenerAdapter']/method[@name='onBoomWillShow' and count(parameter)=0]"
		[Register ("onBoomWillShow", "()V", "GetOnBoomWillShowHandler")]
		public virtual unsafe void OnBoomWillShow ()
		{
			const string __id = "onBoomWillShow.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_;
#pragma warning disable 0169
		static Delegate GetOnClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_Handler ()
		{
			if (cb_onClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ == null)
				cb_onClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_);
			return cb_onClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_;
		}

		static void n_OnClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_boomButton)
		{
			global::Com.Nightonke.Boommenu.OnBoomListenerAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.OnBoomListenerAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton boomButton = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (native_boomButton, JniHandleOwnership.DoNotTransfer);
			__this.OnClicked (index, boomButton);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='OnBoomListenerAdapter']/method[@name='onClicked' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.nightonke.boommenu.BoomButtons.BoomButton']]"
		[Register ("onClicked", "(ILcom/nightonke/boommenu/BoomButtons/BoomButton;)V", "GetOnClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_Handler")]
		public virtual unsafe void OnClicked (int index, global::Com.Nightonke.Boommenu.BoomButtons.BoomButton boomButton)
		{
			const string __id = "onClicked.(ILcom/nightonke/boommenu/BoomButtons/BoomButton;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((boomButton == null) ? IntPtr.Zero : ((global::Java.Lang.Object) boomButton).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
