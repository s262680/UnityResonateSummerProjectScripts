using UnityEngine;
using System.Collections;

public class InfoScreen3 : MonoBehaviour 
{
	
	public GUISkin NextButton;
	
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
		GUI.skin = NextButton;
		
		if(GUI.Button(new Rect(Screen.width - 260,Screen.height/2 + 280, 200, 200)," "))
		{
			Application.LoadLevel("GameScene");
		}
		
	}
	
	public void Menu(string SceneToChange)
	{
		Application.LoadLevel(SceneToChange);
	}
}
