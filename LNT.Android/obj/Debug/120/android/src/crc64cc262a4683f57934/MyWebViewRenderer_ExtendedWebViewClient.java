package crc64cc262a4683f57934;


public class MyWebViewRenderer_ExtendedWebViewClient
	extends android.webkit.WebViewClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPageFinished:(Landroid/webkit/WebView;Ljava/lang/String;)V:GetOnPageFinished_Landroid_webkit_WebView_Ljava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("LNT.Droid.MyWebViewRenderer+ExtendedWebViewClient, LNT.Android", MyWebViewRenderer_ExtendedWebViewClient.class, __md_methods);
	}


	public MyWebViewRenderer_ExtendedWebViewClient ()
	{
		super ();
		if (getClass () == MyWebViewRenderer_ExtendedWebViewClient.class)
			mono.android.TypeManager.Activate ("LNT.Droid.MyWebViewRenderer+ExtendedWebViewClient, LNT.Android", "", this, new java.lang.Object[] {  });
	}


	public void onPageFinished (android.webkit.WebView p0, java.lang.String p1)
	{
		n_onPageFinished (p0, p1);
	}

	private native void n_onPageFinished (android.webkit.WebView p0, java.lang.String p1);

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
