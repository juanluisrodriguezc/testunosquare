using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='ButtonEnum']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/ButtonEnum", DoNotGenerateAcw=true)]
	public sealed partial class ButtonEnum : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='ButtonEnum']/field[@name='Ham']"
		[Register ("Ham")]
		public static global::Com.Nightonke.Boommenu.ButtonEnum Ham {
			get {
				const string __id = "Ham.Lcom/nightonke/boommenu/ButtonEnum;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.ButtonEnum> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='ButtonEnum']/field[@name='SimpleCircle']"
		[Register ("SimpleCircle")]
		public static global::Com.Nightonke.Boommenu.ButtonEnum SimpleCircle {
			get {
				const string __id = "SimpleCircle.Lcom/nightonke/boommenu/ButtonEnum;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.ButtonEnum> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='ButtonEnum']/field[@name='TextInsideCircle']"
		[Register ("TextInsideCircle")]
		public static global::Com.Nightonke.Boommenu.ButtonEnum TextInsideCircle {
			get {
				const string __id = "TextInsideCircle.Lcom/nightonke/boommenu/ButtonEnum;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.ButtonEnum> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='ButtonEnum']/field[@name='TextOutsideCircle']"
		[Register ("TextOutsideCircle")]
		public static global::Com.Nightonke.Boommenu.ButtonEnum TextOutsideCircle {
			get {
				const string __id = "TextOutsideCircle.Lcom/nightonke/boommenu/ButtonEnum;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.ButtonEnum> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='ButtonEnum']/field[@name='Unknown']"
		[Register ("Unknown")]
		public static global::Com.Nightonke.Boommenu.ButtonEnum Unknown {
			get {
				const string __id = "Unknown.Lcom/nightonke/boommenu/ButtonEnum;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.ButtonEnum> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/ButtonEnum", typeof (ButtonEnum));
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

		internal ButtonEnum (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='ButtonEnum']/method[@name='getValue' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='ButtonEnum']/method[@name='getEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getEnum", "(I)Lcom/nightonke/boommenu/ButtonEnum;", "")]
		public static unsafe global::Com.Nightonke.Boommenu.ButtonEnum GetEnum (int value)
		{
			const string __id = "getEnum.(I)Lcom/nightonke/boommenu/ButtonEnum;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.ButtonEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='ButtonEnum']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/nightonke/boommenu/ButtonEnum;", "")]
		public static unsafe global::Com.Nightonke.Boommenu.ButtonEnum ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/nightonke/boommenu/ButtonEnum;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.ButtonEnum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu']/class[@name='ButtonEnum']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/nightonke/boommenu/ButtonEnum;", "")]
		public static unsafe global::Com.Nightonke.Boommenu.ButtonEnum[] Values ()
		{
			const string __id = "values.()[Lcom/nightonke/boommenu/ButtonEnum;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Nightonke.Boommenu.ButtonEnum[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Nightonke.Boommenu.ButtonEnum));
			} finally {
			}
		}

	}
}
