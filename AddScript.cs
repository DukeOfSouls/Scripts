using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class AddScript : MonoBehaviour
{
   [SerializeField] string AdId = "1031367";
    public bool showAdd;

    void Awake()
    {
        Advertisement.Initialize(AdId, true);
    }

	void Start ()
    {
        showAdd = false;
	}
	
	void Update ()
    {
        if (Advertisement.IsReady())
        {
           // Debug.Log("ads done");
        }
            if (Advertisement.IsReady() && showAdd == true)
        {
            Advertisement.Show();
            Add();
            showAdd = false;

        }
	}

    void Add ()
    {
        Advertisement.Initialize(AdId, true);
    }
}
