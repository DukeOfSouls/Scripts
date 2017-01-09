using UnityEngine;
using System.Collections;

public class RandomScript : MonoBehaviour 
{
	public GameObject[] buttons;
	private int index;
	private int lastIndex = -1;
	public bool loop = false;

	public ButtonScript BS;

	void Start () 
	{
		buttons = GameObject.FindGameObjectsWithTag("button");
		BS = GameObject.Find("Buttons").GetComponent<ButtonScript>();

		index = Random.Range (0, buttons.Length);
		lastIndex = index;

		switch (index)
		{
		case 0:
			BS.button1 = true;
			break;
		case 1:
			BS.button2 = true;
			break;
		case 2:
			BS.button3 = true;
			break;

		case 3:
			BS.button4 = true;
			break;

		case 4:
			BS.button5 = true;
			break;

		case 5:
			BS.button6 = true;
			break;
			
		}
	}
	

	void Update () 
	{
		if(loop == true)
		{
			Invoke ("random", 0f);
			loop = false;
		}
	}
	

	void random() 
	{
		do 
		{
			index = Random.Range(0, buttons.Length);
		}
		while(index == lastIndex);
		lastIndex = index;

		switch (index)
		{
		case 0:
			BS.button1 = true;
			break;
			
		case 1:
			BS.button2 = true;
			break;
			
		case 2:
			BS.button3 = true;
			break;

		case 3:
			BS.button4 = true;
			break;

		case 4:
			BS.button5 = true;
			break;
			
		case 5:
			BS.button6 = true;
			break;
			
		}

	}

}
