using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='OrderEnum']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/Animation/OrderEnum", DoNotGenerateAcw=true)]
	public sealed partial class OrderEnum : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='OrderEnum']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Nightonke.Boommenu.Animation.OrderEnum Default {
			get {
				const string __id = "DEFAULT.Lcom/nightonke/boommenu/Animation/OrderEnum;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.OrderEnum> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='OrderEnum']/field[@name='RANDOM']"
		[Register ("RANDOM")]
		public static global::Com.Nightonke.Boommenu.Animation.OrderEnum Random {
			get {
				const string __id = "RANDOM.Lcom/nightonke/boommenu/Animation/OrderEnum;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.OrderEnum> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='OrderEnum']/field[@name='REVERSE']"
		[Register ("REVERSE")]
		public static global::Com.Nightonke.Boommenu.Animation.OrderEnum Reverse {
			get {
				const string __id = "REVERSE.Lcom/nightonke/boommenu/Animation/OrderEnum;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.OrderEnum> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='OrderEnum']/field[@name='Unknown']"
		[Register ("Unknown")]
		public static global::Com.Nightonke.Boommenu.Animation.OrderEnum Unknown {
			get {
				const string __id = "Unknown.Lcom/nightonke/boommenu/Animation/OrderEnum;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.OrderEnum> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/Animation/OrderEnum", typeof (OrderEnum));
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

		internal OrderEnum (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='OrderEnum']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "")]
			get {
				const string __id = "getValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='OrderEnum']/method[@name='getEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getEnum", "(I)Lcom/nightonke/boommenu/Animation/OrderEnum;", "")]
		public static unsafe global::Com.Nightonke.Boommenu.Animation.OrderEnum GetEnum (int value)
		{
			const string __id = "getEnum.(I)Lcom/nightonke/boommenu/Animation/OrderEnum;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.OrderEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='OrderEnum']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/nightonke/boommenu/Animation/OrderEnum;", "")]
		public static unsafe global::Com.Nightonke.Boommenu.Animation.OrderEnum ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/nightonke/boommenu/Animation/OrderEnum;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.OrderEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='OrderEnum']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/nightonke/boommenu/Animation/OrderEnum;", "")]
		public static unsafe global::Com.Nightonke.Boommenu.Animation.OrderEnum[] Values ()
		{
			const string __id = "values.()[Lcom/nightonke/boommenu/Animation/OrderEnum;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Nightonke.Boommenu.Animation.OrderEnum[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nightonke.Boommenu.Animation.OrderEnum));
			} finally {
			}
		}

	}
}
