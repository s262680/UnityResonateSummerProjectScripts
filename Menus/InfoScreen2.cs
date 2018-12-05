using UnityEngine;
using System.Collections;

public class InfoScreen2 : MonoBehaviour 
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
		
		if(GUI.Button(new Rect(Screen.width - 120,Screen.height/2 + 350, 100, 100)," "))
		{
			Application.LoadLevel("InfoScene3");
		}
		
	}

	public void Menu(string SceneToChange)
	{
		Application.LoadLevel(SceneToChange);
	}
}
