using UnityEngine;
using System.Collections;

public class IntroScript : MonoBehaviour {

	public GUISkin PlaySkin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		
		GUI.skin = PlaySkin;
		
		if (GUI.Button (new Rect (Screen.width / 1.1f, Screen.height / 1.15f, Screen.width / 15f, Screen.height / 10f), " ")) 
		{
			Application.LoadLevel ("MenuScene");
		}
	}
}
