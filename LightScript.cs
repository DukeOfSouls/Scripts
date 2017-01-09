using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour {
	
	
	private Vector3 rotate = new Vector3 (0f,0f,100f);
	private Vector3 moveRL = new Vector3 (15f, 0f, 0f);
	private Vector3 moveUD = new Vector3 (0f, 15f, 0f);
	
	void Update () 
	{
		if(gameObject.tag == "right")
		{
			transform.Rotate(-rotate * Time.deltaTime);
			transform.position += moveRL * Time.deltaTime;
		}

		if(gameObject.tag == "left")
		{
			transform.Rotate(rotate * Time.deltaTime);
			transform.position += -moveRL * Time.deltaTime;
		}

		if(gameObject.tag == "up")
		{
			transform.Rotate(rotate * Time.deltaTime);
			transform.position += moveUD * Time.deltaTime;
		}

		if(gameObject.tag == "down")
		{
			transform.Rotate(rotate * Time.deltaTime);
			transform.position += -moveUD * Time.deltaTime;
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.tag == "wallR")
		{
			moveRL =- moveRL;
		}

		if(col.tag == "wallL")
		{
			moveRL =- moveRL;
		}

		if(col.tag == "wallU")
		{
			moveUD =- moveUD;
		}

		if(col.tag == "wallD")
		{
			moveUD =- moveUD;
		}
	}


}
