package mono.com.nightonke.boommenu.BoomButtons;


public class InnerOnBoomButtonClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.nightonke.boommenu.BoomButtons.InnerOnBoomButtonClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onButtonClick:(ILcom/nightonke/boommenu/BoomButtons/BoomButton;)V:GetOnButtonClick_ILcom_nightonke_boommenu_BoomButtons_BoomButton_Handler:Com.Nightonke.Boommenu.BoomButtons.IInnerOnBoomButtonClickListenerInvoker, BoomXamarinAndroid.Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Nightonke.Boommenu.BoomButtons.IInnerOnBoomButtonClickListenerImplementor, BoomXamarinAndroid.Binding", InnerOnBoomButtonClickListenerImplementor.class, __md_methods);
	}


	public InnerOnBoomButtonClickListenerImplementor ()
	{
		super ();
		if (getClass () == InnerOnBoomButtonClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Nightonke.Boommenu.BoomButtons.IInnerOnBoomButtonClickListenerImplementor, BoomXamarinAndroid.Binding", "", this, new java.lang.Object[] {  });
	}


	public void onButtonClick (int p0, com.nightonke.boommenu.BoomButtons.BoomButton p1)
	{
		n_onButtonClick (p0, p1);
	}

	private native void n_onButtonClick (int p0, com.nightonke.boommenu.BoomButtons.BoomButton p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
