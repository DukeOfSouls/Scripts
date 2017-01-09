using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MonsterScript : MonoBehaviour 
{
	public ButtonScript BS;
	public BackgroundScript BG1;
	public BackgroundScript BG2;
	public BackgroundScript BG3;
	public BackgroundScript BG4;
	public Image image1;
	public Image image2;
	public Image image3;
	public float speed = 0f;
	public GameObject player;
	public HighscoreScript HS;
	public Image retry;
	public Image menu;
	public MeshRenderer rText;
	public MeshRenderer mText;
	public SpriteRenderer monsterMoveRend;
	public SpriteRenderer monsterFallRend;
	public Animator monsterMoveAnim;
	public Animator monsterFallAnim;
	public AudioSource bite;
	public AudioSource Music;

	void Start () 
	{
		BS = GameObject.Find ("Buttons").GetComponent<ButtonScript>();
		BG1 = GameObject.Find("BG1").GetComponent<BackgroundScript>();
		BG2 = GameObject.Find("BG2").GetComponent<BackgroundScript>();
		BG3 = GameObject.Find("BG3").GetComponent<BackgroundScript>();
		BG4 = GameObject.Find("BG4").GetComponent<BackgroundScript>();
		image1 = GameObject.Find("Button1").GetComponent<Image>();
		image2 = GameObject.Find("Button2").GetComponent<Image>();
		image3 = GameObject.Find("Button3").GetComponent<Image>();
		HS = GameObject.Find("Score").GetComponent<HighscoreScript>();
		player = GameObject.FindGameObjectWithTag("player");
		retry = GameObject.Find("Retry").GetComponent<Image>();
		rText = GameObject.Find("retry").GetComponent<MeshRenderer>();
		menu = GameObject.Find("Menu").GetComponent<Image>();
		mText = GameObject.Find("menu").GetComponent<MeshRenderer>();
		bite = GameObject.Find("monster").GetComponent<AudioSource>();
		Music = GameObject.Find("MonsterHB").GetComponent<AudioSource>();
		monsterMoveRend = GameObject.Find("Monster").GetComponent<SpriteRenderer>();
		monsterMoveAnim = GameObject.Find("Monster").GetComponent<Animator>();
		monsterFallRend = GameObject.Find("monster").GetComponent<SpriteRenderer>();
		monsterFallAnim = GameObject.Find("monster").GetComponent<Animator>();



	}

	void FixedUpdate () 
	{
		transform.position += Vector3.right * Time.deltaTime * speed;
	}



	void OnTriggerEnter(Collider col)
	{
		if(col.tag == "player")
		{
			BS.dead = true;
			Music.enabled = false;
			bite.enabled = true;
			monsterMoveRend.enabled = false;
			monsterMoveAnim.enabled = false;
			monsterFallRend.enabled = true;
			monsterFallAnim.enabled = true;
			speed = 50f;
			BG1.alive = false;
			BG2.alive = false;
			BG3.alive = false;
			BG4.alive = false;
			image1.enabled = false;
			image2.enabled = false;
			image3.enabled = false;
		}

		if(col.tag == "wall")
		{
			this.enabled = false;
			retry.enabled = true;
			rText.enabled = true;
			menu.enabled = true;
			mText.enabled = true;
		}
	}
	


}

