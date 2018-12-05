using UnityEngine;
using System.Collections;

public class QuitUI : MonoBehaviour 
{
	
	public GUISkin QuitSkin;
	public GUISkin HomeSkin;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnGUI()
	{
	
	GUI.skin = QuitSkin;
	
	if(GUI.Button(new Rect(Screen.width/1.8f,Screen.height/1.8f, 200, 200)," "))
	{
		Quit();
	}
		GUI.skin = HomeSkin;
		
		if(GUI.Button(new Rect(Screen.width/3,Screen.height/1.8f, 200, 200)," "))
		{
			Application.LoadLevel("MenuScene");
		}
	
	}
	public void Quit()
	{
		Application.Quit();
	}

}
