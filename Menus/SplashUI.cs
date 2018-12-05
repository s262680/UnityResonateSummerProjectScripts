using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SplashUI : MonoBehaviour 
{
	public GUISkin Splash;

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
		GUI.skin = Splash;

			if(GUI.Button(new Rect(Screen.width/3,Screen.height/3.6f,700,500),""))
		{
			Application.LoadLevel("IntroScene");
		}
	}
}
