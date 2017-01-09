using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighscoreScript : MonoBehaviour 
{	
	public TextMesh HS;
	
	
	void Start()
	{
		InfoScript.info.Load ();
		HS = GetComponent<TextMesh>();
		HS.text = "HIGHSCORE " + InfoScript.info.highscore;
	}
	
	
}
