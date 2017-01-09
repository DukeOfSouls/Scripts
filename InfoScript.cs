using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class InfoScript : MonoBehaviour 
{
	public static InfoScript info;
	
	public float highscore;
	public bool achievement1;
	public bool achievement2;
	public bool achievement3;
	public bool achievement4;
	public bool achievement5;
	
	
	
	void Awake()
	{
		if(info == null)
		{
			DontDestroyOnLoad(gameObject);
			info = this;
		}
		
		else if(info != this)
		{
			Destroy(gameObject);
		}
	}
	
	public void Save()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/info.dat");
		
		GameData data = new GameData();
		data.highscore = highscore;
		data.achievement1 = achievement1;
		data.achievement2 = achievement2;
		data.achievement3 = achievement3;
		data.achievement4 = achievement4;
		data.achievement5 = achievement5;

		bf.Serialize(file, data);
		file.Close();
	}
	
	
	public void Load()
	{
		if(File.Exists(Application.persistentDataPath + "/info.dat"));
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/info.dat", FileMode.Open);
			GameData data = (GameData)bf.Deserialize(file);
			file.Close();
			
			highscore = data.highscore;
			achievement1 = data.achievement1;
			achievement2 = data.achievement2;
			achievement3 = data.achievement3;
			achievement4 = data.achievement4;
			achievement5 = data.achievement5;
		}
	}
}

[Serializable]
class GameData
{
	public float highscore;
	public bool achievement1;
	public bool achievement2;
	public bool achievement3;
	public bool achievement4;
	public bool achievement5;
	
}