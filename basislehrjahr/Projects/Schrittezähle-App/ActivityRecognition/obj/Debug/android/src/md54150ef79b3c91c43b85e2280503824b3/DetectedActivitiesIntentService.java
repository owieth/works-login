package md54150ef79b3c91c43b85e2280503824b3;


public class DetectedActivitiesIntentService
	extends mono.android.app.IntentService
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onHandleIntent:(Landroid/content/Intent;)V:GetOnHandleIntent_Landroid_content_Intent_Handler\n" +
			"";
		mono.android.Runtime.register ("ActivityRecognition.DetectedActivitiesIntentService, ActivityRecognition", DetectedActivitiesIntentService.class, __md_methods);
	}


	public DetectedActivitiesIntentService (java.lang.String p0)
	{
		super (p0);
		if (getClass () == DetectedActivitiesIntentService.class)
			mono.android.TypeManager.Activate ("ActivityRecognition.DetectedActivitiesIntentService, ActivityRecognition", "System.String, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public DetectedActivitiesIntentService ()
	{
		super ();
		if (getClass () == DetectedActivitiesIntentService.class)
			mono.android.TypeManager.Activate ("ActivityRecognition.DetectedActivitiesIntentService, ActivityRecognition", "", this, new java.lang.Object[] {  });
	}


	public void onHandleIntent (android.content.Intent p0)
	{
		n_onHandleIntent (p0);
	}

	private native void n_onHandleIntent (android.content.Intent p0);

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
