using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
	public ButtonScript BS;
	public float speed;

	void Start ()
	{
		BS = GameObject.Find("Buttons").GetComponent<ButtonScript>();
	}

	void Stop ()
	{
		this.enabled = false;
	}

	void Update ()
	{
		if(BS.dead == true)
		{
			transform.position += Vector3.right * Time.deltaTime * speed;
			Invoke ("Stop", 0.5f);
		}
	}
}
