using UnityEngine;
using System.Collections;

public class FlyScript : MonoBehaviour 
{

	public float speed;
	
	void Update ()
	{
		transform.position += Vector3.right * Time.deltaTime * speed;
    }

	void OnTriggerEnter (Collider col)
	{
		if(col.tag == "wall")
		{
			Destroy (gameObject);
		}
	}

}
