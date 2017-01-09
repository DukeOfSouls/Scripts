using UnityEngine;
using System.Collections;

public class FadeScript : MonoBehaviour 
{
	public Color color;
	public bool In = false;
	public bool Out = true;
	
	void Start ()
	{
		color = GetComponent<Renderer>().material.color;
	}
	
	void Update ()
	{
		if(Out == true)
		{
			color.a -= 0.005f;
			GetComponent<Renderer>().material.color = color;
			Invoke("fadeIn", 3.5f);
		}

		if(In == true)
		{
			color.a += 0.005f;
			GetComponent<Renderer>().material.color = color;
			Invoke("fadeOut", 3.5f);
		}
	}

	void fadeIn ()
	{
		Out = false;
		In = true;
	}

	void fadeOut ()
	{
		Out = true;
		In = false;
	}


	
	
	
}