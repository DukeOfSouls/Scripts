using UnityEngine;
using System.Collections;

public class ResolutionScript : MonoBehaviour {
	
	void Start () 
	{
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		
		if (Screen.height>= 800 && Screen.height <= 1023 ) 
		{
			Screen.SetResolution (800,480,true);
		}

		if (Screen.height >= 1024 && Screen.height <= 1279) 
		{
			Screen.SetResolution (1024,600,true);
		}

		if (Screen.height >= 1279  && Screen.height <= 1919 ) 
		{
			Screen.SetResolution (1280,800,true);
		}

		if (Screen.height >= 1920 ) 
		{
			Screen.SetResolution (1280,800,true);
		}
	}
}
