using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.BoomButtons {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/interface[@name='InnerOnBoomButtonClickListener']"
	[Register ("com/nightonke/boommenu/BoomButtons/InnerOnBoomButtonClickListener", "", "Com.Nightonke.Boommenu.BoomButtons.IInnerOnBoomButtonClickListenerInvoker")]
	public partial interface IInnerOnBoomButtonClickListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/interface[@name='InnerOnBoomButtonClickListener']/method[@name='onButtonClick' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.nightonke.boommenu.BoomButtons.BoomButton']]"
		[Register ("onButtonClick", "(ILcom/nightonke/boommenu/BoomButtons/BoomButton;)V", "GetOnButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_Handler:Com.Nightonke.Boommenu.BoomButtons.IInnerOnBoomButtonClickListenerInvoker, BoomXamarinAndroid.Binding")]
		void OnButtonClick (int p0, global::Com.Nightonke.Boommenu.BoomButtons.BoomButton p1);

	}

	[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomButtons/InnerOnBoomButtonClickListener", DoNotGenerateAcw=true)]
	internal partial class IInnerOnBoomButtonClickListenerInvoker : global::Java.Lang.Object, IInnerOnBoomButtonClickListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/BoomButtons/InnerOnBoomButtonClickListener", typeof (IInnerOnBoomButtonClickListenerInvoker));

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

		public static IInnerOnBoomButtonClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInnerOnBoomButtonClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nightonke.boommenu.BoomButtons.InnerOnBoomButtonClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInnerOnBoomButtonClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_;
#pragma warning disable 0169
		static Delegate GetOnButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_Handler ()
		{
			if (cb_onButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ == null)
				cb_onButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_);
			return cb_onButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_;
		}

		static void n_OnButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.IInnerOnBoomButtonClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.IInnerOnBoomButtonClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nightonke.Boommenu.BoomButtons.BoomButton p1 = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.BoomButton> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnButtonClick (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_;
		public unsafe void OnButtonClick (int p0, global::Com.Nightonke.Boommenu.BoomButtons.BoomButton p1)
		{
			if (id_onButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ == IntPtr.Zero)
				id_onButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_ = JNIEnv.GetMethodID (class_ref, "onButtonClick", "(ILcom/nightonke/boommenu/BoomButtons/BoomButton;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_, __args);
		}

	}

	// event args for com.nightonke.boommenu.BoomButtons.InnerOnBoomButtonClickListener.onButtonClick
	public partial class InnerOnBoomButtonClickEventArgs : global::System.EventArgs {

		public InnerOnBoomButtonClickEventArgs (int p0, global::Com.Nightonke.Boommenu.BoomButtons.BoomButton p1)
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

	[global::Android.Runtime.Register ("mono/com/nightonke/boommenu/BoomButtons/InnerOnBoomButtonClickListenerImplementor")]
	internal sealed partial class IInnerOnBoomButtonClickListenerImplementor : global::Java.Lang.Object, IInnerOnBoomButtonClickListener {

		object sender;

		public IInnerOnBoomButtonClickListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/nightonke/boommenu/BoomButtons/InnerOnBoomButtonClickListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<InnerOnBoomButtonClickEventArgs> Handler;
#pragma warning restore 0649

		public void OnButtonClick (int p0, global::Com.Nightonke.Boommenu.BoomButtons.BoomButton p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new InnerOnBoomButtonClickEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IInnerOnBoomButtonClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
