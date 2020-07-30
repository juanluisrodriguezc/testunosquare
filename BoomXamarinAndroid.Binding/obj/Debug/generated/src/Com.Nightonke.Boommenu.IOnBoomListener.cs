using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nightonke.boommenu']/interface[@name='OnBoomListener']"
	[Register ("com/nightonke/boommenu/OnBoomListener", "", "Com.Nightonke.Boommenu.IOnBoomListenerInvoker")]
	public partial interface IOnBoomListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/interface[@name='OnBoomListener']/method[@name='onBackgroundClick' and count(parameter)=0]"
		[Register ("onBackgroundClick", "()V", "GetOnBackgroundClickHandler:Com.Nightonke.Boommenu.IOnBoomListenerInvoker, BoomXamarinAndroid.Binding")]
		void OnBackgroundClick ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/interface[@name='OnBoomListener']/method[@name='onBoomDidHide' and count(parameter)=0]"
		[Register ("onBoomDidHide", "()V", "GetOnBoomDidHideHandler:Com.Nightonke.Boommenu.IOnBoomListenerInvoker, BoomXamarinAndroid.Binding")]
		void OnBoomDidHide ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/interface[@name='OnBoomListener']/method[@name='onBoomDidShow' and count(parameter)=0]"
		[Register ("onBoomDidShow", "()V", "GetOnBoomDidShowHandler:Com.Nightonke.Boommenu.IOnBoomListenerInvoker, BoomXamarinAndroid.Binding")]
		void OnBoomDidShow ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/interface[@name='OnBoomListener']/method[@name='onBoomWillHide' and count(parameter)=0]"
		[Register ("onBoomWillHide", "()V", "GetOnBoomWillHideHandler:Com.Nightonke.Boommenu.IOnBoomListenerInvoker, BoomXamarinAndroid.Binding")]
		void OnBoomWillHide ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/interface[@name='OnBoomListener']/method[@name='onBoomWillShow' and count(parameter)=0]"
		[Register ("onBoomWillShow", "()V", "GetOnBoomWillShowHandler:Com.Nightonke.Boommenu.IOnBoomListenerInvoker, BoomXamarinAndroid.Binding")]
		void OnBoomWillShow ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/interface[@name='OnBoomListener']/method[@name='onClicked' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.nightonke.boommenu.BoomButtons.BoomButton']]"
		[Register ("onClicked", "(ILcom/nightonke/boommenu/BoomButtons/BoomButton;)V", "GetOnClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_Handler:Com.Nightonke.Boommenu.IOnBoomListenerInvoker, BoomXamarinAndroid.Binding")]
		void OnClicked (int p0, global::Com.Nightonke.Boommenu.BoomButtons.BoomButton p1);

	}

	[global::Android.Runtime.Register ("com/nightonke/boommenu/OnBoomListener", DoNotGenerateAcw=true)]
	internal partial class IOnBoomListenerInvoker : global::Java.Lang.Object, IOnBoomListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/OnBoomListener", typeof (IOnBoomListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IOnBoomListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnBoomListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nightonke.boommenu.OnBoomListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnBoomListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Nightonke.Boommenu.IOnBoomListener __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.IOnBoomListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBackgroundClick ();
		}
#pragma warning restore 0169

		IntPtr id_onBackgroundClick;
		public unsafe void OnBackgroundClick ()
		{
			if (id_onBackgroundClick == IntPtr.Zero)
				id_onBackgroundClick = JNIEnv.GetMethodID (class_ref, "onBackgroundClick", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBackgroundClick);
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
			global::Com.Nightonke.Boommenu.IOnBoomListener __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.IOnBoomListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBoomDidHide ();
		}
#pragma warning restore 0169

		IntPtr id_onBoomDidHide;
		public unsafe void OnBoomDidHide ()
		{
			if (id_onBoomDidHide == IntPtr.Zero)
				id_onBoomDidHide = JNIEnv.GetMethodID (class_ref, "onBoomDidHide", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBoomDidHide);
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
			global::Com.Nightonke.Boommenu.IOnBoomListener __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.IOnBoomListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBoomDidShow ();
		}
#pragma warning restore 0169

		IntPtr id_onBoomDidShow;
		public unsafe void OnBoomDidShow ()
		{
			if (id_onBoomDidShow == IntPtr.Zero)
				id_onBoomDidShow = JNIEnv.GetMethodID (class_ref, "onBoomDidShow", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBoomDidShow);
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
			global::Com.Nightonke.Boommenu.IOnBoomListener __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.IOnBoomListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBoomWillHide ();
		}
#pragma warning restore 0169

		IntPtr id_onBoomWillHide;
		public unsafe void OnBoomWillHide ()
		{
			if (id_onBoomWillHide == IntPtr.Zero)
				id_onBoomWillHide = JNIEnv.GetMethodID (class_ref, "onBoomWillHide", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBoomWillHide);
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
			global::Com.Nightonke.Boommenu.IOnBoomListener __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.IOnBoomListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBoomWillShow ();
		}
#pragma warning restore 0169

		IntPtr id_onBoomWillShow;
		public unsafe void OnBoomWillShow ()
		{
			if (id_onBoomWillShow == IntPtr.Zero)
				id_onBoomWillShow = JNIEnv.GetMethodID (class_ref, "onBoomWillShow", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBoomWillShow);
		}

		static Delegate cb_onClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_;
#pragma warning disable 0169
		static Delegate GetOnClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_Handler ()
		{
			if (cb_onClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ == null)
				cb_onClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_);
			return cb_onClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_;
		}

		static void n_OnClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Nightonke.Boommenu.IOnBoomListener __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.IOnBoomListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton p1 = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnClicked (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_;
		public unsafe void OnClicked (int p0, global::Com.Nightonke.Boommenu.BoomButtons.BoomButton p1)
		{
			if (id_onClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ == IntPtr.Zero)
				id_onClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ = JNIEnv.GetMethodID (class_ref, "onClicked", "(ILcom/nightonke/boommenu/BoomButtons/BoomButton;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_, __args);
		}

	}

	// event args for com.nightonke.boommenu.OnBoomListener.onClicked
	public partial class ClickedEventArgs : global::System.EventArgs {

		public ClickedEventArgs (int p0, global::Com.Nightonke.Boommenu.BoomButtons.BoomButton p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		global::Com.Nightonke.Boommenu.BoomButtons.BoomButton p1;
		public global::Com.Nightonke.Boommenu.BoomButtons.BoomButton P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/nightonke/boommenu/OnBoomListenerImplementor")]
	internal sealed partial class IOnBoomListenerImplementor : global::Java.Lang.Object, IOnBoomListener {

		object sender;

		public IOnBoomListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/nightonke/boommenu/OnBoomListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnBackgroundClickHandler;
#pragma warning restore 0649

		public void OnBackgroundClick ()
		{
			var __h = OnBackgroundClickHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnBoomDidHideHandler;
#pragma warning restore 0649

		public void OnBoomDidHide ()
		{
			var __h = OnBoomDidHideHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnBoomDidShowHandler;
#pragma warning restore 0649

		public void OnBoomDidShow ()
		{
			var __h = OnBoomDidShowHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnBoomWillHideHandler;
#pragma warning restore 0649

		public void OnBoomWillHide ()
		{
			var __h = OnBoomWillHideHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnBoomWillShowHandler;
#pragma warning restore 0649

		public void OnBoomWillShow ()
		{
			var __h = OnBoomWillShowHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<ClickedEventArgs> OnClickedHandler;
#pragma warning restore 0649

		public void OnClicked (int p0, global::Com.Nightonke.Boommenu.BoomButtons.BoomButton p1)
		{
			var __h = OnClickedHandler;
			if (__h != null)
				__h (sender, new ClickedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IOnBoomListenerImplementor value)
		{
			return value.OnBackgroundClickHandler == null && value.OnBoomDidHideHandler == null && value.OnBoomDidShowHandler == null && value.OnBoomWillHideHandler == null && value.OnBoomWillShowHandler == null && value.OnClickedHandler == null;
		}
	}

}
