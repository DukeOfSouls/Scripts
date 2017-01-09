using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class AddloadScript : MonoBehaviour
{
    public GameObject Addloader;
    public GameObject AddloaderText;

	void Start ()
    {
        
	}
	
	void Update ()
    {
        if (Advertisement.IsReady())
        { 
            Addloader.SetActive(false);
            AddloaderText.SetActive(false);
        }
    }
}
