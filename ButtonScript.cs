using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonScript : MonoBehaviour 
{
    public int index;
	public float count;
	private float wait;
    public Button button, BUTTON1, BUTTON2, BUTTON3, BUTTON4, BUTTON5, BUTTON6;

	public AudioClip push;
	private AudioSource sound;

    public MeshRenderer START;
	public Transform scorePos;
    public TextMesh currentScore;
	public float score;
	public AchievementScript ACHS;
	public GameObject scoreSize;
	public bool start;
    public bool grow;
	public GameObject button7;

	Vector3 pos = new Vector3 (-24f, 5f, -10f);

    public AddScript AS;
	public RandomScript RS;
	public BackgroundScript BG1;
	public BackgroundScript BG2;
	public BackgroundScript BG3;
	public BackgroundScript BG4;
	public MonsterScript monster;
	public Image image;
	public Image image1;
	public Image image2;
	public Image image3;
	public Image image4;
	public Image image5;
	public Image image6;
	public Image image7;
	public SpriteRenderer playerMoveRend;
	public SpriteRenderer playerFallRend;
	public Animator playerMoveAnim;
	public Animator PlayerFallAnim;
	public HighscoreScript HS;
	public bool button1 = false;
	public bool button2 = false;
	public bool button3 = false;
	public bool button4 = false;
	public bool button5 = false;
	public bool button6 = false;
	public bool dead = false;
	public Sprite onTexture3, onTexture2, onTexture1, offTexture, loseTexture;

	void Start()
	{
        BUTTON1.enabled = false;
        BUTTON2.enabled = false;
        BUTTON3.enabled = false;
        BUTTON4.enabled = false;
        BUTTON5.enabled = false;
        BUTTON6.enabled = false;

        index = Random.Range(0, 3);
        grow = false;
		start = true;
		wait = 0.5f;
		count = 0f;
		sound = GetComponent<AudioSource>();
		image = GetComponent<Image>();
        AS = GameObject.Find("Info").GetComponent<AddScript>();
		RS = GameObject.Find("Buttons").GetComponent<RandomScript>();
		BG1 = GameObject.Find("BG1").GetComponent<BackgroundScript>();
		BG2 = GameObject.Find("BG2").GetComponent<BackgroundScript>();
		BG3 = GameObject.Find("BG3").GetComponent<BackgroundScript>();
		BG4 = GameObject.Find("BG4").GetComponent<BackgroundScript>();
		image1 = GameObject.Find("Button1").GetComponent<Image>();
		image2 = GameObject.Find("Button2").GetComponent<Image>();
		image3 = GameObject.Find("Button3").GetComponent<Image>();
		image4 = GameObject.Find("Button4").GetComponent<Image>();
		image5 = GameObject.Find("Button5").GetComponent<Image>();
		image6 = GameObject.Find("Button6").GetComponent<Image>();
		image7 = GameObject.Find("Button7").GetComponent<Image>();
		monster = GameObject.Find("MonsterHB").GetComponent<MonsterScript>();
		HS = GameObject.Find("Score").GetComponent<HighscoreScript>();
		playerMoveRend = GameObject.Find("Player").GetComponent<SpriteRenderer>();
		playerMoveAnim = GameObject.Find("Player").GetComponent<Animator>();
		playerFallRend = GameObject.Find("player").GetComponent<SpriteRenderer>();
		PlayerFallAnim = GameObject.Find("player").GetComponent<Animator>();

	}

	IEnumerator banaan ()
	{
		for(int i = 0; i < 10 ; i++)
		{
			count++;
			i = 0;

			yield return new WaitForSeconds(wait);
		}
	}

	public void Button1()
	{
		if(button1 == true)
		{
			sound.PlayOneShot(push, 0.8f);
			RS.loop = true;
			button1 = false;
			score += 1f;
			wait -= 0.01f;
			count = 0f;
			BG1.speed += 0.005f;
			BG2.speed += 0.005f;
			BG3.speed += 0.005f;
			BG4.speed += 0.005f;
		}

		else

		{
			dead = true;
            playerMoveRend.enabled = false;
			playerMoveAnim.enabled = false;
			playerFallRend.enabled = true;
			PlayerFallAnim.enabled = true;
			monster.speed = 50f;
			BG1.alive = false;
			BG2.alive = false;
			BG3.alive = false;
			BG4.alive = false;
			image1.enabled = false;
			image2.enabled = false;
			image3.enabled = false;
			image4.enabled = false;
			image5.enabled = false;
			image6.enabled = false;
            dead = false;
        }
	}

	public void Button2()
	{
		if(button2 == true)
		{
			sound.PlayOneShot(push, 0.8f);
			RS.loop = true;
			button2 = false;
			score += 1f;
			wait -= 0.01f;
			count = 0f;
			BG1.speed += 0.005f;
			BG2.speed += 0.005f;
			BG3.speed += 0.005f;
			BG4.speed += 0.005f;
		}
		
		else
			
		{
			dead = true;
			playerMoveRend.enabled = false;
			playerMoveAnim.enabled = false;
			playerFallRend.enabled = true;
			PlayerFallAnim.enabled = true;
			monster.speed = 50f;
			BG1.alive = false;
			BG2.alive = false;
			BG3.alive = false;
			BG4.alive = false;
			image1.enabled = false;
			image2.enabled = false;
			image3.enabled = false;
			image4.enabled = false;
			image5.enabled = false;
			image6.enabled = false;
            dead = false;
        }
	}

	public void Button3()
	{
		if(button3 == true)
		{
			sound.PlayOneShot(push, 0.8f);
			RS.loop = true;
			button3 = false;
			score += 1f;
			wait -= 0.01f;
			count = 0f;
			BG1.speed += 0.005f;
			BG2.speed += 0.005f;
			BG3.speed += 0.005f;
			BG4.speed += 0.005f;
		}
		
		else
			
		{
			dead = true;
			playerMoveRend.enabled = false;
			playerMoveAnim.enabled = false;
			playerFallRend.enabled = true;
			PlayerFallAnim.enabled = true;
			monster.speed = 50f;
			BG1.alive = false;
			BG2.alive = false;
			BG3.alive = false;
			BG4.alive = false;
			image1.enabled = false;
			image2.enabled = false;
			image3.enabled = false;
			image4.enabled = false;
			image5.enabled = false;
			image6.enabled = false;
            dead = false;
        }
	}

	public void Button4()
	{
		if(button4 == true)
		{
			sound.PlayOneShot(push, 0.8f);
			RS.loop = true;
			button4 = false;
			score += 1f;
			wait -= 0.01f;
			count = 0f;
			BG1.speed += 0.005f;
			BG2.speed += 0.005f;
			BG3.speed += 0.005f;
			BG4.speed += 0.005f;

		}
		
		else
			
		{
			dead = true;
			playerMoveRend.enabled = false;
			playerMoveAnim.enabled = false;
			playerFallRend.enabled = true;
			PlayerFallAnim.enabled = true;
			monster.speed = 50f;
			BG1.alive = false;
			BG2.alive = false;
			BG3.alive = false;
			BG4.alive = false;
			image1.enabled = false;
			image2.enabled = false;
			image3.enabled = false;
			image4.enabled = false;
			image5.enabled = false;
			image6.enabled = false;
            dead = false;
        }
	}

	public void Button5()
	{
		if(button5 == true)
		{
			sound.PlayOneShot(push, 0.8f);
			RS.loop = true;
			button5 = false;
			score += 1f;
			wait -= 0.01f;
			count = 0f;
			BG1.speed += 0.005f;
			BG2.speed += 0.005f;
			BG3.speed += 0.005f;
			BG4.speed += 0.005f;
			
		}
		
		else
			
		{
			dead = true;
			playerMoveRend.enabled = false;
			playerMoveAnim.enabled = false;
			playerFallRend.enabled = true;
			PlayerFallAnim.enabled = true;
			monster.speed = 50f;
			BG1.alive = false;
			BG2.alive = false;
			BG3.alive = false;
			BG4.alive = false;
			image1.enabled = false;
			image2.enabled = false;
			image3.enabled = false;
			image4.enabled = false;
			image5.enabled = false;
			image6.enabled = false;
            dead = false;
        }
	}

	public void Button6()
	{
		if(button6 == true)
		{
			sound.PlayOneShot(push, 0.8f);
			RS.loop = true;
			button6 = false;
			score += 1f;
			wait -= 0.01f;
			count = 0f;
			BG1.speed += 0.005f;
			BG2.speed += 0.005f;
			BG3.speed += 0.005f;
			BG4.speed += 0.005f;
		}
		
		else
			
		{
			dead = true;
			playerMoveRend.enabled = false;
			playerMoveAnim.enabled = false;
			playerFallRend.enabled = true;
			PlayerFallAnim.enabled = true;
			monster.speed = 50f;
			BG1.alive = false;
			BG2.alive = false;
			BG3.alive = false;
			BG4.alive = false;
			image1.enabled = false;
			image2.enabled = false;
			image3.enabled = false;
			image4.enabled = false;
			image5.enabled = false;
			image6.enabled = false;
            dead = false;
        }
	}

	public void Button7()
	{
		if(start == true);
		{
            button.enabled = false;
			image7.sprite = onTexture2;
			Invoke("waitStart", 0.5f);
		}
	}

	void waitStart ()
	{
		image7.sprite = onTexture1;
		Invoke("waitStart2", 0.5f);
	}

	void waitStart2 ()
	{
		button7.SetActive(false);
        START.enabled = false;
		RS.enabled = true;
		StartCoroutine (banaan());
        BUTTON1.enabled = true;
        BUTTON2.enabled = true;
        BUTTON3.enabled = true;
        BUTTON4.enabled = true;
        BUTTON5.enabled = true;
        BUTTON6.enabled = true;
    }

    void Grow()
    {
        grow = true;
    }

	void FixedUpdate ()
	{
        if(dead == true)
        {
            button7.SetActive(false);
            Invoke("Grow", 0.5f);
        }

		currentScore.text = "" + score;

		if(wait <= 0.15f) wait = 0.15f;
		if(BG1.speed >= 0.185f) BG1.speed = 0.185f;
		if(BG2.speed >= 0.185f) BG2.speed = 0.185f;
		if(BG3.speed >= 0.185f) BG3.speed = 0.185f;
		if(BG4.speed >= 0.185f) BG4.speed = 0.185f;

        if (grow == true)
        {
            grow = false;

            if (score > InfoScript.info.highscore)
            {
                InfoScript.info.highscore = score;
            }

            ACHS.enabled = true;

            switch (index)
            {
                case 0:
                    Debug.Log("appel");
                    break;
                case 1:
                    AS.showAdd = true;
                    break;
                case 2:
                    Debug.Log("banaan");
                    break;
            }

            InfoScript.info.Save();
            this.enabled = false;

        }

        if (button1 == true)
		{
			if(count == 1) image1.sprite = onTexture3;
			if(count == 2) image1.sprite = onTexture2;
			if(count == 3) image1.sprite = onTexture1;
			if(count == 4) image1.sprite = loseTexture;
		}

		else
		{
			image1.sprite = offTexture;
		}

		
		if(button2 == true)
		{
			if(count == 1) image2.sprite = onTexture3;
			if(count == 2) image2.sprite = onTexture2;
			if(count == 3) image2.sprite = onTexture1;
			if(count == 4) image2.sprite = loseTexture;
		}

		else
		{
			image2.sprite = offTexture;
		}

		
		if(button3 == true)
		{
			if(count == 1) image3.sprite = onTexture3;
			if(count == 2) image3.sprite = onTexture2;
			if(count == 3) image3.sprite = onTexture1;
			if(count == 4) image3.sprite = loseTexture;
		}

		else
		{
			image3.sprite = offTexture;
		}
		
		if(button4 == true)
		{
			if(count == 1) image4.sprite = onTexture3;
			if(count == 2) image4.sprite = onTexture2;
			if(count == 3) image4.sprite = onTexture1;
			if(count == 4) image4.sprite = loseTexture;
		}

		else
		{
			image4.sprite = offTexture;
		}

		if(button5 == true)
		{
			if(count == 1) image5.sprite = onTexture3;
			if(count == 2) image5.sprite = onTexture2;
			if(count == 3) image5.sprite = onTexture1;
			if(count == 4) image5.sprite = loseTexture;
		}
		
		else
		{
			image5.sprite = offTexture;
		}

		if(button6 == true)
		{
			if(count == 1) image6.sprite = onTexture3;
			if(count == 2) image6.sprite = onTexture2;
			if(count == 3) image6.sprite = onTexture1;
			if(count == 4) image6.sprite = loseTexture;
		}
		
		else
		{
			image6.sprite = offTexture;
		}

		if(image1.sprite == loseTexture || image2.sprite == loseTexture || image3.sprite == loseTexture || image4.sprite == loseTexture || image5.sprite == loseTexture || image6.sprite == loseTexture)
		{
			Invoke ("Die", 0.1f);
		}
	}

	void Die ()
	{
		dead = true;
		playerMoveRend.enabled = false;
		playerMoveAnim.enabled = false;
		playerFallRend.enabled = true;
		PlayerFallAnim.enabled = true;
		monster.speed = 50f;
		BG1.alive = false;
		BG2.alive = false;
		BG3.alive = false;
		BG4.alive = false;
		image1.enabled = false;
		image2.enabled = false;
		image3.enabled = false;
		image4.enabled = false;
		image5.enabled = false;
		image6.enabled = false;
	}







}