using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nightonke.Boommenu.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']"
	[global::Android.Runtime.Register ("com/nightonke/boommenu/Animation/AnimationManager", DoNotGenerateAcw=true)]
	public partial class AnimationManager : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/nightonke/boommenu/Animation/AnimationManager", typeof (AnimationManager));
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

		protected AnimationManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/constructor[@name='AnimationManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnimationManager ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='animate' and count(parameter)=7 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='android.animation.TimeInterpolator'] and parameter[6][@type='android.animation.AnimatorListenerAdapter'] and parameter[7][@type='float...']]"
		[Register ("animate", "(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TimeInterpolator;Landroid/animation/AnimatorListenerAdapter;[F)Landroid/animation/ObjectAnimator;", "")]
		public static unsafe global::Android.Animation.ObjectAnimator Animate (global::Java.Lang.Object target, string property, long delay, long duration, global::Android.Animation.ITimeInterpolator interpolator, global::Android.Animation.AnimatorListenerAdapter listenerAdapter, params float[] values)
		{
			const string __id = "animate.(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TimeInterpolator;Landroid/animation/AnimatorListenerAdapter;[F)Landroid/animation/ObjectAnimator;";
			IntPtr native_property = JNIEnv.NewString (property);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [1] = new JniArgumentValue (native_property);
				__args [2] = new JniArgumentValue (delay);
				__args [3] = new JniArgumentValue (duration);
				__args [4] = new JniArgumentValue ((interpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interpolator).Handle);
				__args [5] = new JniArgumentValue ((listenerAdapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listenerAdapter).Handle);
				__args [6] = new JniArgumentValue (native_values);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ObjectAnimator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_property);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='animate' and count(parameter)=6 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='android.animation.TimeInterpolator'] and parameter[6][@type='float...']]"
		[Register ("animate", "(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TimeInterpolator;[F)Landroid/animation/ObjectAnimator;", "")]
		public static unsafe global::Android.Animation.ObjectAnimator Animate (global::Java.Lang.Object target, string property, long delay, long duration, global::Android.Animation.ITimeInterpolator interpolator, params float[] values)
		{
			const string __id = "animate.(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TimeInterpolator;[F)Landroid/animation/ObjectAnimator;";
			IntPtr native_property = JNIEnv.NewString (property);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [1] = new JniArgumentValue (native_property);
				__args [2] = new JniArgumentValue (delay);
				__args [3] = new JniArgumentValue (duration);
				__args [4] = new JniArgumentValue ((interpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interpolator).Handle);
				__args [5] = new JniArgumentValue (native_values);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ObjectAnimator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_property);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='animate' and count(parameter)=7 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='android.animation.TypeEvaluator'] and parameter[6][@type='android.animation.AnimatorListenerAdapter'] and parameter[7][@type='int...']]"
		[Register ("animate", "(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TypeEvaluator;Landroid/animation/AnimatorListenerAdapter;[I)Landroid/animation/ObjectAnimator;", "")]
		public static unsafe global::Android.Animation.ObjectAnimator Animate (global::Java.Lang.Object target, string property, long delay, long duration, global::Android.Animation.ITypeEvaluator evaluator, global::Android.Animation.AnimatorListenerAdapter listenerAdapter, params int[] values)
		{
			const string __id = "animate.(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TypeEvaluator;Landroid/animation/AnimatorListenerAdapter;[I)Landroid/animation/ObjectAnimator;";
			IntPtr native_property = JNIEnv.NewString (property);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [1] = new JniArgumentValue (native_property);
				__args [2] = new JniArgumentValue (delay);
				__args [3] = new JniArgumentValue (duration);
				__args [4] = new JniArgumentValue ((evaluator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) evaluator).Handle);
				__args [5] = new JniArgumentValue ((listenerAdapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listenerAdapter).Handle);
				__args [6] = new JniArgumentValue (native_values);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ObjectAnimator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_property);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='animate' and count(parameter)=6 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='android.animation.TypeEvaluator'] and parameter[6][@type='int...']]"
		[Register ("animate", "(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TypeEvaluator;[I)Landroid/animation/ObjectAnimator;", "")]
		public static unsafe global::Android.Animation.ObjectAnimator Animate (global::Java.Lang.Object target, string property, long delay, long duration, global::Android.Animation.ITypeEvaluator evaluator, params int[] values)
		{
			const string __id = "animate.(Ljava/lang/Object;Ljava/lang/String;JJLandroid/animation/TypeEvaluator;[I)Landroid/animation/ObjectAnimator;";
			IntPtr native_property = JNIEnv.NewString (property);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [1] = new JniArgumentValue (native_property);
				__args [2] = new JniArgumentValue (delay);
				__args [3] = new JniArgumentValue (duration);
				__args [4] = new JniArgumentValue ((evaluator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) evaluator).Handle);
				__args [5] = new JniArgumentValue (native_values);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ObjectAnimator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_property);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='animate' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='float[]'] and parameter[5][@type='android.animation.TimeInterpolator'] and parameter[6][@type='java.util.ArrayList&lt;android.view.View&gt;']]"
		[Register ("animate", "(Ljava/lang/String;JJ[FLandroid/animation/TimeInterpolator;Ljava/util/ArrayList;)V", "")]
		public static unsafe void Animate (string property, long delay, long duration, float[] values, global::Android.Animation.ITimeInterpolator interpolator, global::System.Collections.Generic.IList<global::Android.Views.View> targets)
		{
			const string __id = "animate.(Ljava/lang/String;JJ[FLandroid/animation/TimeInterpolator;Ljava/util/ArrayList;)V";
			IntPtr native_property = JNIEnv.NewString (property);
			IntPtr native_values = JNIEnv.NewArray (values);
			IntPtr native_targets = global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (targets);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_property);
				__args [1] = new JniArgumentValue (delay);
				__args [2] = new JniArgumentValue (duration);
				__args [3] = new JniArgumentValue (native_values);
				__args [4] = new JniArgumentValue ((interpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interpolator).Handle);
				__args [5] = new JniArgumentValue (native_targets);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_property);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
				JNIEnv.DeleteLocalRef (native_targets);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='calculateHideXY' and count(parameter)=8 and parameter[1][@type='com.nightonke.boommenu.Animation.BoomEnum'] and parameter[2][@type='android.graphics.PointF'] and parameter[3][@type='com.nightonke.boommenu.Animation.Ease'] and parameter[4][@type='int'] and parameter[5][@type='android.graphics.PointF'] and parameter[6][@type='android.graphics.PointF'] and parameter[7][@type='float[]'] and parameter[8][@type='float[]']]"
		[Register ("calculateHideXY", "(Lcom/nightonke/boommenu/Animation/BoomEnum;Landroid/graphics/PointF;Lcom/nightonke/boommenu/Animation/Ease;ILandroid/graphics/PointF;Landroid/graphics/PointF;[F[F)V", "")]
		public static unsafe void CalculateHideXY (global::Com.Nightonke.Boommenu.Animation.BoomEnum boomEnum, global::Android.Graphics.PointF parentSize, global::Com.Nightonke.Boommenu.Animation.Ease ease, int frames, global::Android.Graphics.PointF startPosition, global::Android.Graphics.PointF endPosition, float[] xs, float[] ys)
		{
			const string __id = "calculateHideXY.(Lcom/nightonke/boommenu/Animation/BoomEnum;Landroid/graphics/PointF;Lcom/nightonke/boommenu/Animation/Ease;ILandroid/graphics/PointF;Landroid/graphics/PointF;[F[F)V";
			IntPtr native_xs = JNIEnv.NewArray (xs);
			IntPtr native_ys = JNIEnv.NewArray (ys);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((boomEnum == null) ? IntPtr.Zero : ((global::Java.Lang.Object) boomEnum).Handle);
				__args [1] = new JniArgumentValue ((parentSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parentSize).Handle);
				__args [2] = new JniArgumentValue ((ease == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ease).Handle);
				__args [3] = new JniArgumentValue (frames);
				__args [4] = new JniArgumentValue ((startPosition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) startPosition).Handle);
				__args [5] = new JniArgumentValue ((endPosition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) endPosition).Handle);
				__args [6] = new JniArgumentValue (native_xs);
				__args [7] = new JniArgumentValue (native_ys);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (xs != null) {
					JNIEnv.CopyArray (native_xs, xs);
					JNIEnv.DeleteLocalRef (native_xs);
				}
				if (ys != null) {
					JNIEnv.CopyArray (native_ys, ys);
					JNIEnv.DeleteLocalRef (native_ys);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='calculateShowXY' and count(parameter)=8 and parameter[1][@type='com.nightonke.boommenu.Animation.BoomEnum'] and parameter[2][@type='android.graphics.PointF'] and parameter[3][@type='com.nightonke.boommenu.Animation.Ease'] and parameter[4][@type='int'] and parameter[5][@type='android.graphics.PointF'] and parameter[6][@type='android.graphics.PointF'] and parameter[7][@type='float[]'] and parameter[8][@type='float[]']]"
		[Register ("calculateShowXY", "(Lcom/nightonke/boommenu/Animation/BoomEnum;Landroid/graphics/PointF;Lcom/nightonke/boommenu/Animation/Ease;ILandroid/graphics/PointF;Landroid/graphics/PointF;[F[F)V", "")]
		public static unsafe void CalculateShowXY (global::Com.Nightonke.Boommenu.Animation.BoomEnum boomEnum, global::Android.Graphics.PointF parentSize, global::Com.Nightonke.Boommenu.Animation.Ease ease, int frames, global::Android.Graphics.PointF startPosition, global::Android.Graphics.PointF endPosition, float[] xs, float[] ys)
		{
			const string __id = "calculateShowXY.(Lcom/nightonke/boommenu/Animation/BoomEnum;Landroid/graphics/PointF;Lcom/nightonke/boommenu/Animation/Ease;ILandroid/graphics/PointF;Landroid/graphics/PointF;[F[F)V";
			IntPtr native_xs = JNIEnv.NewArray (xs);
			IntPtr native_ys = JNIEnv.NewArray (ys);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((boomEnum == null) ? IntPtr.Zero : ((global::Java.Lang.Object) boomEnum).Handle);
				__args [1] = new JniArgumentValue ((parentSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parentSize).Handle);
				__args [2] = new JniArgumentValue ((ease == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ease).Handle);
				__args [3] = new JniArgumentValue (frames);
				__args [4] = new JniArgumentValue ((startPosition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) startPosition).Handle);
				__args [5] = new JniArgumentValue ((endPosition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) endPosition).Handle);
				__args [6] = new JniArgumentValue (native_xs);
				__args [7] = new JniArgumentValue (native_ys);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (xs != null) {
					JNIEnv.CopyArray (native_xs, xs);
					JNIEnv.DeleteLocalRef (native_xs);
				}
				if (ys != null) {
					JNIEnv.CopyArray (native_ys, ys);
					JNIEnv.DeleteLocalRef (native_ys);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='getOrderIndex' and count(parameter)=2 and parameter[1][@type='com.nightonke.boommenu.Animation.OrderEnum'] and parameter[2][@type='int']]"
		[Register ("getOrderIndex", "(Lcom/nightonke/boommenu/Animation/OrderEnum;I)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> GetOrderIndex (global::Com.Nightonke.Boommenu.Animation.OrderEnum orderEnum, int size)
		{
			const string __id = "getOrderIndex.(Lcom/nightonke/boommenu/Animation/OrderEnum;I)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((orderEnum == null) ? IntPtr.Zero : ((global::Java.Lang.Object) orderEnum).Handle);
				__args [1] = new JniArgumentValue (size);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='getRotate3DAnimation' and count(parameter)=5 and parameter[1][@type='float[]'] and parameter[2][@type='float[]'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='com.nightonke.boommenu.BoomButtons.BoomButton']]"
		[Register ("getRotate3DAnimation", "([F[FJJLcom/nightonke/boommenu/BoomButtons/BoomButton;)Lcom/nightonke/boommenu/Animation/Rotate3DAnimation;", "")]
		public static unsafe global::Com.Nightonke.Boommenu.Animation.Rotate3DAnimation GetRotate3DAnimation (float[] xs, float[] ys, long delay, long duration, global::Com.Nightonke.Boommenu.BoomButtons.BoomButton bb)
		{
			const string __id = "getRotate3DAnimation.([F[FJJLcom/nightonke/boommenu/BoomButtons/BoomButton;)Lcom/nightonke/boommenu/Animation/Rotate3DAnimation;";
			IntPtr native_xs = JNIEnv.NewArray (xs);
			IntPtr native_ys = JNIEnv.NewArray (ys);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_xs);
				__args [1] = new JniArgumentValue (native_ys);
				__args [2] = new JniArgumentValue (delay);
				__args [3] = new JniArgumentValue (duration);
				__args [4] = new JniArgumentValue ((bb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bb).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Nightonke.Boommenu.Animation.Rotate3DAnimation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (xs != null) {
					JNIEnv.CopyArray (native_xs, xs);
					JNIEnv.DeleteLocalRef (native_xs);
				}
				if (ys != null) {
					JNIEnv.CopyArray (native_ys, ys);
					JNIEnv.DeleteLocalRef (native_ys);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.nightonke.boommenu.Animation']/class[@name='AnimationManager']/method[@name='rotate' and count(parameter)=5 and parameter[1][@type='com.nightonke.boommenu.BoomButtons.BoomButton'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='android.animation.TimeInterpolator'] and parameter[5][@type='float...']]"
		[Register ("rotate", "(Lcom/nightonke/boommenu/BoomButtons/BoomButton;JJLandroid/animation/TimeInterpolator;[F)V", "")]
		public static unsafe void Rotate (global::Com.Nightonke.Boommenu.BoomButtons.BoomButton boomButton, long delay, long duration, global::Android.Animation.ITimeInterpolator interpolator, params float[] degrees)
		{
			const string __id = "rotate.(Lcom/nightonke/boommenu/BoomButtons/BoomButton;JJLandroid/animation/TimeInterpolator;[F)V";
			IntPtr native_degrees = JNIEnv.NewArray (degrees);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((boomButton == null) ? IntPtr.Zero : ((global::Java.Lang.Object) boomButton).Handle);
				__args [1] = new JniArgumentValue (delay);
				__args [2] = new JniArgumentValue (duration);
				__args [3] = new JniArgumentValue ((interpolator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interpolator).Handle);
				__args [4] = new JniArgumentValue (native_degrees);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (degrees != null) {
					JNIEnv.CopyArray (native_degrees, degrees);
					JNIEnv.DeleteLocalRef (native_degrees);
				}
			}
		}

	}
}
