package md52decd0e31f6b971e5a2b852f7079f788;


public class RemoveOnFailureListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.tasks.OnFailureListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFailure:(Ljava/lang/Exception;)V:GetOnFailure_Ljava_lang_Exception_Handler:Android.Gms.Tasks.IOnFailureListenerInvoker, Xamarin.GooglePlayServices.Tasks\n" +
			"";
		mono.android.Runtime.register ("ActivityRecognition.Listeners.RemoveOnFailureListener, ActivityRecognition", RemoveOnFailureListener.class, __md_methods);
	}


	public RemoveOnFailureListener ()
	{
		super ();
		if (getClass () == RemoveOnFailureListener.class)
			mono.android.TypeManager.Activate ("ActivityRecognition.Listeners.RemoveOnFailureListener, ActivityRecognition", "", this, new java.lang.Object[] {  });
	}


	public void onFailure (java.lang.Exception p0)
	{
		n_onFailure (p0);
	}

	private native void n_onFailure (java.lang.Exception p0);

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
