using UnityEngine;
using System.Collections;

public class WinnerOfTheRoundScript : MonoBehaviour {
	public Texture2D[] playerWinner;
	public Texture2D[] evilWinner;
	public Texture2D bg;
	public int winner;
	public GUISkin TextUI;
	public GUISkin next;
	public AudioClip buttonClick;
	GameObject selectionData;
	Data data;
	public Texture2D startButtonImg;
	public GUISkin yellowText;
	// Use this for initialization
	void Start () {
		selectionData = GameObject.Find ("SelectionData");
	 data = selectionData.GetComponent<Data> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Start"))
		{
			audio.PlayOneShot(buttonClick);
			StartCoroutine(buttonClickPlay());
		}
	}
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),bg);
		
		GUI.skin=yellowText;
		GUI.Label(new Rect(Screen.width/2.8f,Screen.height/1.1f,Screen.width/2,Screen.height/10),"Press ");
		GUI.DrawTexture(new Rect(Screen.width/2.28f,Screen.height/1.12f,Screen.width/18,Screen.width/20),startButtonImg);
		GUI.Label(new Rect(Screen.width/2f,Screen.height/1.1f,Screen.width/2,Screen.height/10)," to continue");
		
		GUI.skin=TextUI;
		GUI.Box(new Rect(Screen.width/4.8f,Screen.height/2,Screen.width/5,Screen.width/5),"+100");
		
		
	
		if(data.winnerTrigger==1)
		{
			GUI.DrawTexture (new Rect (Screen.width / 1.4f, Screen.height / 7f,Screen.width/4,Screen.height/1.1f), playerWinner [data.p1Select]);
		}
	
		if(data.winnerTrigger==2)
		{
			GUI.DrawTexture (new Rect (Screen.width / 1.4f, Screen.height / 7f,Screen.width/4,Screen.height/1.1f), playerWinner [data.p2Select]);
		}
		
		if(data.winnerTrigger==3)
		{
			GUI.DrawTexture (new Rect (Screen.width / 1.4f, Screen.height / 7f,Screen.width/4,Screen.height/1.1f), playerWinner [data.p3Select]);
		}
		
		if(data.winnerTrigger==4)
		{
			GUI.DrawTexture (new Rect (Screen.width / 1.4f, Screen.height / 7f,Screen.width/4,Screen.height/1.1f), evilWinner [data.p4Select]);
			
		}
		
		GUI.skin=next;
		if(GUI.Button(new Rect(Screen.width/1.08f,Screen.height/1.15f,Screen.width/16,Screen.width/16)," "))
		{
			audio.PlayOneShot(buttonClick);
			StartCoroutine(buttonClickPlay());
			
		}
	}
	
	IEnumerator buttonClickPlay()
	{
		yield return new WaitForSeconds(buttonClick.length);
			if(data.level==2)
			{
				Application.LoadLevel("GameScene2");
			}
			if(data.level==4)
			{
				Application.LoadLevel("GameScene3");
			}
		
	}
}
