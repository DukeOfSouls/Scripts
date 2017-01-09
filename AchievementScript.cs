using UnityEngine;
using System.Collections;

public class AchievementScript : MonoBehaviour 
{
	public SpriteRenderer ACH0;
	public SpriteRenderer ACH1;
	public SpriteRenderer ACH2;
	public SpriteRenderer ACH3;
	public SpriteRenderer ACH4;
	public SpriteRenderer ACH5;

	void Start () 
	{
		ACH0 = GameObject.Find("ACH0").GetComponent<SpriteRenderer>();
		ACH1 = GameObject.Find("ACH1").GetComponent<SpriteRenderer>();
		ACH2 = GameObject.Find("ACH2").GetComponent<SpriteRenderer>();
		ACH3 = GameObject.Find("ACH3").GetComponent<SpriteRenderer>();
		ACH4 = GameObject.Find("ACH4").GetComponent<SpriteRenderer>();
		ACH5 = GameObject.Find("ACH5").GetComponent<SpriteRenderer>();
	}

	void Update()
	{
		if(InfoScript.info.achievement1 == false && InfoScript.info.achievement2 == false && InfoScript.info.achievement3 == false && InfoScript.info.achievement4 == false && InfoScript.info.achievement5 == false)
		{
			ACH0.enabled = true;
			ACH1.enabled = false;
			ACH2.enabled = false;
			ACH3.enabled = false;
			ACH4.enabled = false;
			ACH5.enabled = false;
		}

		if(InfoScript.info.achievement1 == true && InfoScript.info.achievement2 == false && InfoScript.info.achievement3 == false && InfoScript.info.achievement4 == false && InfoScript.info.achievement5 == false)
		{
			ACH0.enabled = false;
			ACH1.enabled = true;
			ACH2.enabled = false;
			ACH3.enabled = false;
			ACH4.enabled = false;
			ACH5.enabled = false;
		}

		if(InfoScript.info.achievement1 == true && InfoScript.info.achievement2 == true && InfoScript.info.achievement3 == false && InfoScript.info.achievement4 == false && InfoScript.info.achievement5 == false)
		{
			ACH0.enabled = false;
			ACH1.enabled = false;
			ACH2.enabled = true;
			ACH3.enabled = false;
			ACH4.enabled = false;
			ACH5.enabled = false;
		}

		if(InfoScript.info.achievement1 == true && InfoScript.info.achievement2 == true && InfoScript.info.achievement3 == true && InfoScript.info.achievement4 == false && InfoScript.info.achievement5 == false)
		{
			ACH0.enabled = false;
			ACH1.enabled = false;
			ACH2.enabled = false;
			ACH3.enabled = true;
			ACH4.enabled = false;
			ACH5.enabled = false;
		}

		if(InfoScript.info.achievement1 == true && InfoScript.info.achievement2 == true && InfoScript.info.achievement3 == true && InfoScript.info.achievement4 == true && InfoScript.info.achievement5 == false)
		{
			ACH0.enabled = false;
			ACH1.enabled = false;
			ACH2.enabled = false;
			ACH3.enabled = false;
			ACH4.enabled = true;
			ACH5.enabled = false;
		}

		if(InfoScript.info.achievement1 == true && InfoScript.info.achievement2 == true && InfoScript.info.achievement3 == true && InfoScript.info.achievement4 == true && InfoScript.info.achievement5 == true)
		{
			ACH0.enabled = false;
			ACH1.enabled = false;
			ACH2.enabled = false;
			ACH3.enabled = false;
			ACH4.enabled = false;
			ACH5.enabled = true;
		}
	}

}
