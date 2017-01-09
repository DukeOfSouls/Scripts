using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour 
{
	public GameObject backdrop;
	public GameObject loading;
	
	void Start()
	{
		backdrop.SetActive(false);
		loading.SetActive(false);	               
	}
	
	public void Play()
	{
		StartCoroutine(LoadingScreenPlay());
	}
	
	IEnumerator LoadingScreenPlay()
	{
		backdrop.SetActive(true);
		loading.SetActive(true);
		
		AsyncOperation async = Application.LoadLevelAsync(1);
		
		
		yield return null;
	}

	public void Options()
	{
		StartCoroutine(LoadingScreenOptions());
	}
	
	IEnumerator LoadingScreenOptions()
	{
		backdrop.SetActive(true);
		loading.SetActive(true);
		
		AsyncOperation async = Application.LoadLevelAsync(2);
		
		
		yield return null;
	}
	

	
	public void Menu()
	{
		StartCoroutine(LoadingScreenMenu());
	}
	
	IEnumerator LoadingScreenMenu()
	{
		backdrop.SetActive(true);
		loading.SetActive(true);
		
		AsyncOperation async = Application.LoadLevelAsync(0);
		
		
		yield return null;
	}

	public void Exit()
	{
		Application.Quit();
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
}