using UnityEngine;
using System.Collections;

public class InfoUI3 : MonoBehaviour 
{
	
	public GUISkin FruitSplash;
	
	public GUISkin Next;
	
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
		

		GUI.skin = Next;
		if (GUI.Button (new Rect (Screen.width / 1.98f, Screen.height /1.3f, 50, 50), " ")) 
		{
			
			Application.LoadLevel("GameScene");
			
		}
		GUI.skin = FruitSplash;
		GUI.Button (new Rect (Screen.width / 2.6f, Screen.height / 3, 500, 500), "");

	}
	
}