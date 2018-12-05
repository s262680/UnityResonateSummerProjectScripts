using UnityEngine;
using System.Collections;

public class InfoUI2 : MonoBehaviour 
{
	
	public GUISkin BadGuys;
	
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
		if (GUI.Button (new Rect (Screen.width / 1.8f, Screen.height / 1.65f, 50, 50), " ")) 
		{
			
			Application.LoadLevel("InfoScene3");
			
		}
		GUI.skin = BadGuys;
		GUI.Button (new Rect (Screen.width / 2.6f, Screen.height / 3, 500, 500), "");
	}
	
}