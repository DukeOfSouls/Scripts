using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour 
{
	public GameObject Bird;
	private float wait;
	private int index;


	void Start () 
	{
		index = Random.Range (1,4);

		switch (index)
		{
		case 1:
			StartCoroutine ( spawnBird1() );
			break;

		case 2:
			StartCoroutine ( spawnBird2() );
			break;

		case 3:
			StartCoroutine ( spawnBird3() );
			break;
		}
	}
	
	IEnumerator spawnBird1()
	{
		wait = Random.Range (5f, 10f);
		yield return new WaitForSeconds (wait);
		Debug.Log ("spawn1");
		Vector3 spawnPosition = new Vector3 (-50f, Random.Range (8f, 25f) ,8f);
		Bird.transform.localScale = new Vector3(2f, 2f, Bird.transform.localScale.z);
		Instantiate (Bird, spawnPosition , Quaternion.identity);
		index = Random.Range (1,4);

		switch (index)
		{
		case 1:
			StartCoroutine ( spawnBird1() );
			break;
			
		case 2:
			StartCoroutine ( spawnBird2() );
			break;
			
		case 3:
			StartCoroutine ( spawnBird3() );
			break;
		}

	}

	IEnumerator spawnBird2()
	{
		wait = Random.Range (5f, 10f);
		yield return new WaitForSeconds (wait);
		Debug.Log ("spawn2");
		Vector3 spawnPosition = new Vector3 (-50f, Random.Range (8f, 25f) ,18f);
		Bird.transform.localScale = new Vector3(1.5f, 1.5f, Bird.transform.localScale.z);
		Instantiate (Bird, spawnPosition , Quaternion.identity);
		index = Random.Range (1,4);
		
		switch (index)
		{
		case 1:
			StartCoroutine ( spawnBird1() );
			break;
			
		case 2:
			StartCoroutine ( spawnBird2() );
			break;
			
		case 3:
			StartCoroutine ( spawnBird3() );
			break;
		}
		
	}

	IEnumerator spawnBird3()
	{
		wait = Random.Range (5f, 10f);
		yield return new WaitForSeconds (wait);
		Debug.Log ("spawn3");
		Vector3 spawnPosition = new Vector3 (-50f, Random.Range (8f, 25f) ,30f);
		Bird.transform.localScale = new Vector3(1f, 1f, Bird.transform.localScale.z);
		Instantiate (Bird, spawnPosition , Quaternion.identity);
		index = Random.Range (1,4);
		
		switch (index)
		{
		case 1:
			StartCoroutine ( spawnBird1() );
			break;
			
		case 2:
			StartCoroutine ( spawnBird2() );
			break;
			
		case 3:
			StartCoroutine ( spawnBird3() );
			break;
		}
		
	}
}