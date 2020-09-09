package crc64ffbe2dd02abdeb3d;


public class ValidateEntryRenderer
	extends crc643f46942d9dd1fff9.EntryRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DemoApp.Droid.CustomRenderer.ValidateEntryRenderer, DemoApp.Android", ValidateEntryRenderer.class, __md_methods);
	}


	public ValidateEntryRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == ValidateEntryRenderer.class)
			mono.android.TypeManager.Activate ("DemoApp.Droid.CustomRenderer.ValidateEntryRenderer, DemoApp.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public ValidateEntryRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == ValidateEntryRenderer.class)
			mono.android.TypeManager.Activate ("DemoApp.Droid.CustomRenderer.ValidateEntryRenderer, DemoApp.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public ValidateEntryRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == ValidateEntryRenderer.class)
			mono.android.TypeManager.Activate ("DemoApp.Droid.CustomRenderer.ValidateEntryRenderer, DemoApp.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
