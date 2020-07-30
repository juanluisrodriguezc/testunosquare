using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.BoomButtons {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/interface[@name='OnBMClickListener']"
	[Register ("com/nightonke/boommenu/BoomButtons/OnBMClickListener", "", "Com.Nightonke.Boommenu.BoomButtons.IOnBMClickListenerInvoker")]
	public partial interface IOnBMClickListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.BoomButtons']/interface[@name='OnBMClickListener']/method[@name='onBoomButtonClick' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onBoomButtonClick", "(I)V", "GetOnBoomButtonClick_IHandler:Com.Nightonke.Boommenu.BoomButtons.IOnBMClickListenerInvoker, BoomXamarinAndroid.Binding")]
		void OnBoomButtonClick (int p0);

	}

	[global::Android.Runtime.Register ("com/nightonke/boommenu/BoomButtons/OnBMClickListener", DoNotGenerateAcw=true)]
	internal partial class IOnBMClickListenerInvoker : global::Java.Lang.Object, IOnBMClickListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/BoomButtons/OnBMClickListener", typeof (IOnBMClickListenerInvoker));

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

		public static IOnBMClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnBMClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.nightonke.boommenu.BoomButtons.OnBMClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnBMClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBoomButtonClick_I;
#pragma warning disable 0169
		static Delegate GetOnBoomButtonClick_IHandler ()
		{
			if (cb_onBoomButtonClick_I == null)
				cb_onBoomButtonClick_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnBoomButtonClick_I);
			return cb_onBoomButtonClick_I;
		}

		static void n_OnBoomButtonClick_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nightonke.Boommenu.BoomButtons.IOnBMClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.BoomButtons.IOnBMClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBoomButtonClick (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBoomButtonClick_I;
		public unsafe void OnBoomButtonClick (int p0)
		{
			if (id_onBoomButtonClick_I == IntPtr.Zero)
				id_onBoomButtonClick_I = JNIEnv.GetMethodID (class_ref, "onBoomButtonClick", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBoomButtonClick_I, __args);
		}

	}

	// event args for com.nightonke.boommenu.BoomButtons.OnBMClickListener.onBoomButtonClick
	public partial class BMClickEventArgs : global::System.EventArgs {

		public BMClickEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/nightonke/boommenu/BoomButtons/OnBMClickListenerImplementor")]
	internal sealed partial class IOnBMClickListenerImplementor : global::Java.Lang.Object, IOnBMClickListener {

		object sender;

		public IOnBMClickListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/nightonke/boommenu/BoomButtons/OnBMClickListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BMClickEventArgs> Handler;
#pragma warning restore 0649

		public void OnBoomButtonClick (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BMClickEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnBMClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
