using UnityEngine;
using System.Collections;

public class InfoUI1 : MonoBehaviour 
{

	public GUISkin GoodGuys;

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
			if (GUI.Button (new Rect (Screen.width / 1.7f, Screen.height / 1.8f, 50, 50), " ")) 
			{

				Application.LoadLevel("InfoScene2");

			}

		GUI.skin = GoodGuys;
		GUI.Button (new Rect (Screen.width / 2.6f, Screen.height / 3, 500, 500), "");
	}
	
}
