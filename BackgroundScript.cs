using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour 
{
	public Renderer rend;
	public bool alive = true;
	private float startSpeed;
	public float speed;
	private float offset;

	void Start() 
	{
		rend = GetComponent<Renderer>();
		speed = 0.0100f;
	}
	void FixedUpdate() 
	{
		if(gameObject.tag == "BG1")
		{
			offset += 0.0010f + speed * Time.deltaTime;
			offset = offset % 1.0f;
			rend.material.mainTextureOffset = new Vector2(offset, 0f);
		}

		if(gameObject.tag == "BG2")
		{
			offset += 0.0008f + speed * Time.deltaTime;
			offset = offset % 1.0f;
			rend.material.mainTextureOffset = new Vector2(offset, 0f);
		}

		if(gameObject.tag == "BG3")
		{
			offset += 0.0006f + speed * Time.deltaTime;
			offset = offset % 1.0f;
			rend.material.mainTextureOffset = new Vector2(offset, 0f);
		}

		if(gameObject.tag == "BG4")
		{
			offset += 0.0004f + speed * Time.deltaTime;
			offset = offset % 1.0f;
			rend.material.mainTextureOffset = new Vector2(offset, 0f);
		}

		if(alive == false)
		{
			this.enabled = false;
		}

	}
}
	/* 0.10f, 0.08f, 0.06f, 0.04f */