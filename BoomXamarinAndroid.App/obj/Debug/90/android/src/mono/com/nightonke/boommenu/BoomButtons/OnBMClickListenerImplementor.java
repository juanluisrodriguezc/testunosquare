package mono.com.nightonke.boommenu.BoomButtons;


public class OnBMClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.nightonke.boommenu.BoomButtons.OnBMClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBoomButtonClick:(I)V:GetOnBoomButtonClick_IHandler:Com.Nightonke.Boommenu.BoomButtons.IOnBMClickListenerInvoker, BoomXamarinAndroid.Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Nightonke.Boommenu.BoomButtons.IOnBMClickListenerImplementor, BoomXamarinAndroid.Binding", OnBMClickListenerImplementor.class, __md_methods);
	}


	public OnBMClickListenerImplementor ()
	{
		super ();
		if (getClass () == OnBMClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Nightonke.Boommenu.BoomButtons.IOnBMClickListenerImplementor, BoomXamarinAndroid.Binding", "", this, new java.lang.Object[] {  });
	}


	public void onBoomButtonClick (int p0)
	{
		n_onBoomButtonClick (p0);
	}

	private native void n_onBoomButtonClick (int p0);

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
