using UnityEngine;
using System.Collections;
using System;
public class InGameUIRemake : MonoBehaviour {

	public Texture2D clock;
	float timeRemaining = 121;
	public string DisplayTime;
	public Texture2D[] avatars;
	public GUISkin TextUI;
	public GUISkin option;
	public GUISkin instruction;
	public GUISkin home;
	public GUISkin quit;
	public Texture2D[] abilities;
	public Texture2D[] instructionImage;
	public bool timeTrigger=false;
	public GUISkin arrow;
	public GUISkin x;
	int pages=0;
	public AudioClip buttonClick;
	public AudioClip laugh;
	bool audioTrigger=true;
	TimeSpan timeSpan;
	string timeText;
	
	//public bool p1Popup=false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(timeTrigger)
		{
			Time.timeScale=0;
		}
		if(!timeTrigger)
		{
			Time.timeScale=1;
		}
		timeSpan = TimeSpan.FromSeconds(timeRemaining);
		timeText = string.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
		
//		float minutes = timeRemaining / 60;
//		float seconds = timeRemaining % 60;
//		
		//DisplayTime = string.Format ("{0:0}:{1:00}", minutes, seconds);
		
		timeRemaining -= Time.deltaTime; 
	}
	void OnGUI()
	{
//		if(p1Popup)
//		{
//			GUI.Box(new Rect(GameObject.Find ("Player1").transform.position.x,GameObject.Find ("Player1").transform.position.y,100,100),"10");
//			
//		}
		GameObject selectionData = GameObject.Find ("SelectionData");
		Data data = selectionData.GetComponent<Data> ();
		
		GameObject sm = GameObject.Find ("ScoreManager");
		ScoreManager sms = sm.GetComponent<ScoreManager> ();
		
		
		if(!GameObject.Find("Instruction"))
		{

		if(timeRemaining<60&audioTrigger)
		{
				audio.PlayOneShot(laugh);
				audioTrigger=false;
		}
		

		if (timeRemaining > 0) 
		{

			GUI.Label (new Rect (Screen.width /1.55f, Screen.height / 50, 150, 150), clock);
			
			GUI.skin = TextUI;
			GUI.Box (new Rect (Screen.width /1.52f, Screen.height / 10, 100, 100), timeText);
			
		} 
		else 
		{
			sms.p4Score += 100;
			data.winnerTrigger=4;
			data.level+=1;			
		}
		
		if(data.level==1&timeRemaining<0)
		{
			data.level+=1;
			Application.LoadLevel("Round1Score");
			timeRemaining=121;		
		}
		if(data.level==3&timeRemaining<0)
		{
			data.level+=1;
			Application.LoadLevel("Round2Score");
			timeRemaining=121;		
			
		}
		if(data.level==5&timeRemaining<0)
		{
			Application.LoadLevel("ScoreBoard");			
		}
		
		GUI.Label (new Rect (Screen.width /1.15f, Screen.height / 9f, 40, 40),abilities[0]);			
		GUI.Label (new Rect (Screen.width / 1.142f, Screen.height / 6.5f, 50, 50),abilities[1]);			
		GUI.Label (new Rect (Screen.width / 1.11f, Screen.height / 5.05f, 60, 60),abilities[2]);			
		GUI.Label (new Rect (Screen.width / 1.06f, Screen.height / 4.8f, 70, 70),abilities[3]);
			
	
		
		GUI.DrawTexture (new Rect (Screen.width / 15, Screen.height / 26, 160, 100), avatars [data.p1Select]);
		GUI.DrawTexture (new Rect (Screen.width / 4.4f, Screen.height / 26, 160, 100), avatars [data.p2Select]);
		GUI.DrawTexture (new Rect (Screen.width / 2.5f, Screen.height / 26, 160, 100), avatars [data.p3Select]);
	
	
		
		GUI.skin = TextUI;
		GUI.Box (new Rect (Screen.width / 9.2f, Screen.height / 21.5f, 100, 80), sms.p1Score.ToString ());
		GUI.Box (new Rect (Screen.width / 3.7f, Screen.height / 21.5f, 100, 80), sms.p2Score.ToString ());
		GUI.Box (new Rect (Screen.width / 2.25f, Screen.height / 21.5f, 100, 80), sms.p3Score.ToString ());
		GUI.Box (new Rect (Screen.width / 1.18f, Screen.height / 18, 100, 80), sms.p4Score.ToString ());
		
	
		if(pages==0)
		{
		GUI.skin=option;
		
			if(GUI.Button(new Rect(Screen.width/1.08f,Screen.height/1.15f,Screen.width/16,Screen.width/16)," "))
			{
				audio.PlayOneShot(buttonClick);
				timeTrigger=true;
				pages=1;
			
			}
		}
			
		else if(pages==1)
		{
			GUI.skin=null;
			GUI.Box(new Rect(0,0,Screen.width,Screen.height),"");
			
			GUI.skin = instruction;
		
		if (GUI.Button (new Rect (Screen.width / 3.7f, Screen.height / 3.2f, Screen.width/10,Screen.width/10), " ")) 
			{
				audio.PlayOneShot(buttonClick);
				pages=2;
			}
			
			GUI.skin = home ;
			
		if (GUI.Button (new Rect (Screen.width / 2.25f, Screen.height / 3.2f, Screen.width/10,Screen.width/10), " ")) 
			{
				audio.PlayOneShot(buttonClick);
				clearData();
				timeTrigger=false;
				Application.LoadLevel ("MenuScene");
			}
			
			GUI.skin = quit;
			
		if (GUI.Button (new Rect (Screen.width / 1.65f, Screen.height / 3.2f, Screen.width/10,Screen.width/10), " ")) 
			{
				audio.PlayOneShot(buttonClick);
				Application.Quit();
			}
		
		
			GUI.skin=option;
		if(GUI.Button(new Rect(Screen.width/1.08f,Screen.height/1.15f,Screen.width/16,Screen.width/16)," "))
			{
				audio.PlayOneShot(buttonClick);
				pages=0;
				timeTrigger=false;
			}
		}	
		
//		else if(pages==2)
//		{
//			GUI.skin=null;
//			GUI.Box(new Rect(0,0,Screen.width,Screen.height),"");
//			GUI.Label(new Rect(Screen.width/12,Screen.height/12,Screen.width/1.2f,Screen.height/1.2f),instructionImage[0]);
//			

			if(pages==2)
			{
				GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),instructionImage[0]);
			}
			if(pages==3)
			{
				GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),instructionImage[1]);		
			}
				
//			GUI.skin=option;
//			if(GUI.Button(new Rect(Screen.width/1.08f,Screen.height/1.15f,Screen.width/16,Screen.width/16)," "))
//			{
//				pages=0;
//				timeTrigger=false;
//			}
			
			GUI.skin=arrow;
			if(pages==2)
			{
				if (GUI.Button (new Rect (Screen.width / 1.2f, Screen.height / 1.15f, Screen.width/15,Screen.width/15), " ")) 
				{
					audio.PlayOneShot(buttonClick);
					pages=3;
				}
			}
			GUI.skin=x;
			if(pages==2||pages==3)
			{
				if (GUI.Button (new Rect (Screen.width / 1.11f, Screen.height / 1.15f, Screen.width/15,Screen.width/15), " ")) 
				{
					audio.PlayOneShot(buttonClick);
					pages=1;
				}
			}
//		}
		}
	}
	
	public void clearData()
	{
		GameObject[] selectionData = GameObject.FindGameObjectsWithTag ("data");
		foreach(GameObject oj in selectionData)
		{
			Destroy(oj);
		}
	}
}
