package mono.com.nightonke.boommenu;


public class OnBoomListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.nightonke.boommenu.OnBoomListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBackgroundClick:()V:GetOnBackgroundClickHandler:Com.Nightonke.Boommenu.IOnBoomListenerInvoker, BoomXamarinAndroid.Binding\n" +
			"n_onBoomDidHide:()V:GetOnBoomDidHideHandler:Com.Nightonke.Boommenu.IOnBoomListenerInvoker, BoomXamarinAndroid.Binding\n" +
			"n_onBoomDidShow:()V:GetOnBoomDidShowHandler:Com.Nightonke.Boommenu.IOnBoomListenerInvoker, BoomXamarinAndroid.Binding\n" +
			"n_onBoomWillHide:()V:GetOnBoomWillHideHandler:Com.Nightonke.Boommenu.IOnBoomListenerInvoker, BoomXamarinAndroid.Binding\n" +
			"n_onBoomWillShow:()V:GetOnBoomWillShowHandler:Com.Nightonke.Boommenu.IOnBoomListenerInvoker, BoomXamarinAndroid.Binding\n" +
			"n_onClicked:(ILcom/nightonke/boommenu/BoomButtons/BoomButton;)V:GetOnClicked_ILcom_nightonke_boommenu_BoomButtons_BoomButton_Handler:Com.Nightonke.Boommenu.IOnBoomListenerInvoker, BoomXamarinAndroid.Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Nightonke.Boommenu.IOnBoomListenerImplementor, BoomXamarinAndroid.Binding", OnBoomListenerImplementor.class, __md_methods);
	}


	public OnBoomListenerImplementor ()
	{
		super ();
		if (getClass () == OnBoomListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Nightonke.Boommenu.IOnBoomListenerImplementor, BoomXamarinAndroid.Binding", "", this, new java.lang.Object[] {  });
	}


	public void onBackgroundClick ()
	{
		n_onBackgroundClick ();
	}

	private native void n_onBackgroundClick ();


	public void onBoomDidHide ()
	{
		n_onBoomDidHide ();
	}

	private native void n_onBoomDidHide ();


	public void onBoomDidShow ()
	{
		n_onBoomDidShow ();
	}

	private native void n_onBoomDidShow ();


	public void onBoomWillHide ()
	{
		n_onBoomWillHide ();
	}

	private native void n_onBoomWillHide ();


	public void onBoomWillShow ()
	{
		n_onBoomWillShow ();
	}

	private native void n_onBoomWillShow ();


	public void onClicked (int p0, com.nightonke.boommenu.BoomButtons.BoomButton p1)
	{
		n_onClicked (p0, p1);
	}

	private native void n_onClicked (int p0, com.nightonke.boommenu.BoomButtons.BoomButton p1);

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
