using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreBoardScore : MonoBehaviour 
	{

	public int p1Score=0;
	public int p2Score=0;
	public int p3Score=0;
	public int p4Score=0;

	public GUISkin TextUI;

//	public static int Score;
//
//	Text text;


	void Start()
	{
		DontDestroyOnLoad(this);
	}

	
	// Update is called once per frame
	void Update () 
	{
		if (p1Score <= 0) 
		{
			p1Score = 0;
		}
		if (p2Score <= 0) 
		{
			p2Score = 0;
		}
		if (p3Score <= 0) 
		{
			p3Score = 0;
		}
		if (p4Score <= 0) 
		{
			p4Score = 0;
		}
	}

	void OnGUI()
	{
		GUI.skin = TextUI;
		GUI.Box (new Rect (Screen.width/9.2f, Screen.height/100, 100, 100), p1Score.ToString ());
		GUI.skin = TextUI;
		GUI.Box (new Rect (Screen.width/3.3f, Screen.height/25, 100, 100), p2Score.ToString ());
		GUI.skin = TextUI;
		GUI.Box (new Rect (Screen.width/1.6f, Screen.height/25, 100, 100), p3Score.ToString ());
		GUI.skin = TextUI;
		GUI.Box (new Rect (Screen.width/1.23f, Screen.height/25, 100, 100), p4Score.ToString ());
	}
}
