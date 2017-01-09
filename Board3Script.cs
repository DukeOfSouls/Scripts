using UnityEngine;
using System.Collections;

public class Board3Script : MonoBehaviour 
{
	Vector3 beginPos = new Vector3 (-0.1f, 8.95f, -3.5f);
	Vector3 awayPos = new Vector3 (-0.1f, 40f, -3.5f);
	
	public ButtonScript BS;
	public Transform target;
	public float speed;
	public Animator anim;
	
	void Start()
	{
		anim = GetComponent<Animator>();
	}
	
	void Update()
	{
		if(InfoScript.info.achievement3 == false && BS.score == 100f)
		{
			StartCoroutine ( achievement() );
		}
		
		
	}
	
	IEnumerator achievement()
	{
		InfoScript.info.achievement3 = true;
		anim.enabled = true;
		
		while(transform.position.y > 9f)
		{
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target.position, step);
			yield return null;
		}
		
		target.transform.position = awayPos;
		yield return new WaitForSeconds(2f);
		
		
		while(transform.position.y < 18)
		{
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, target.position, step);
			yield return null;
		}

		target.transform.position = beginPos;
		Destroy(gameObject);
		StopCoroutine ( achievement() );
	}

}