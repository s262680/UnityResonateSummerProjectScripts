using UnityEngine;
using System.Collections;

public class InsructionsMenu : MonoBehaviour 
{
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
		GUI.skin = HomeSkin;
		
		if (GUI.Button (new Rect (Screen.width / 120, Screen.height / 50, 150, 150), " ")) 
		{
			Application.LoadLevel ("MenuScene");
		}
	}
}
