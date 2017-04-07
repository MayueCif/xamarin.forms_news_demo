package md5fa3be16b83ce3acd3be83265686c14de;


public class DefaultTransformer
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.support.v4.view.ViewPager.PageTransformer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_transformPage:(Landroid/view/View;F)V:GetTransformPage_Landroid_view_View_FHandler:Android.Support.V4.View.ViewPager/IPageTransformerInvoker, Xamarin.Android.Support.Core.UI\n" +
			"";
		mono.android.Runtime.register ("CarouselView.FormsPlugin.Android.DefaultTransformer, CarouselView.FormsPlugin.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DefaultTransformer.class, __md_methods);
	}


	public DefaultTransformer () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DefaultTransformer.class)
			mono.android.TypeManager.Activate ("CarouselView.FormsPlugin.Android.DefaultTransformer, CarouselView.FormsPlugin.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void transformPage (android.view.View p0, float p1)
	{
		n_transformPage (p0, p1);
	}

	private native void n_transformPage (android.view.View p0, float p1);

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
