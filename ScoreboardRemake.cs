using UnityEngine;
using System.Collections;

public class ScoreboardRemake : MonoBehaviour {

	public GUISkin TextUI;
	public GUISkin Home;
	public int[] scoreList = new int[4];
	public int[] avatarList = new int[4];
	public int[] playerList = new int[4];
	public Texture2D[] avatars;
	public Texture2D[] winner;
	public Texture2D[] players;
	public Texture2D[] eAvatars;
	public Texture2D[] eWinners;
	public AudioClip buttonClick;
	GameObject selectionData;
	Data data;
	public Texture2D startButtonImg;
	public GUISkin yellowText;
	// Use this for initialization
	void Start () {
		GameObject sm = GameObject.Find ("ScoreManager");
		ScoreManager sms = sm.GetComponent<ScoreManager> ();
		scoreList[0]=sms.p1Score;
		scoreList[1]=sms.p2Score;
		scoreList[2]=sms.p3Score;
		scoreList[3]=sms.p4Score;
		selectionData = GameObject.Find ("SelectionData");
		data = selectionData.GetComponent<Data> ();
		avatarList[0]=data.p1Select;
		avatarList[1]=data.p2Select;
		avatarList[2]=data.p3Select;
		avatarList[3]=data.p4Select;
		playerList[0]=0;
		playerList[1]=1;		
		playerList[2]=2;	
		playerList[3]=3;
		
	}
	
	// Update is called once per frame
	void Update () {
		BubbleSort();
		clearData();
		if(Input.GetButtonDown("Start"))
		{
			audio.PlayOneShot(buttonClick);
			StartCoroutine(buttonClickPlay());
		}
	}
	
	
	public void BubbleSort()
	{
		int STempHolder;
		int ATempHolder;
		int PTempHolder;
		bool keepGoing=true;
		while (keepGoing == true)
		{
			keepGoing=false;
			for (int i =0; i<scoreList.Length-1; i++) 
			{
				if (scoreList [i + 1] > scoreList [i]) 
				{
					STempHolder = scoreList [i];
					ATempHolder	= avatarList[i];
					PTempHolder = playerList[i];
					scoreList [i] = scoreList [i+1];
					avatarList[i] = avatarList[i+1];
					playerList[i] = playerList[i+1];
					scoreList [i+1] = STempHolder;
					avatarList[i+1] = ATempHolder;
					playerList[i+1] = PTempHolder;
					keepGoing=true;
				}
			}
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
	
	void OnGUI()
	{
	
		GUI.skin = TextUI;
		GUI.Box (new Rect (Screen.width / 25f, Screen.height / 1.6f, 200, 150),scoreList[0].ToString());
		GUI.Box (new Rect (Screen.width / 4.9f, Screen.height / 1.6f, 200, 150),scoreList[1].ToString());
		GUI.Box (new Rect (Screen.width / 2.8f, Screen.height / 1.6f, 200, 150),scoreList[2].ToString());
		GUI.Box (new Rect (Screen.width / 1.9f, Screen.height / 1.6f, 200, 150),scoreList[3].ToString());
		
		if(avatarList[0]==data.p4Select)
		{
		GUI.DrawTexture (new Rect (Screen.width / 35, Screen.height / 2.58f, 230, 230), eAvatars [avatarList[0]]);
		}
		else
		{
		GUI.DrawTexture (new Rect (Screen.width / 35, Screen.height / 2.58f, 230, 230), avatars [avatarList[0]]);
		}	
		
		if(avatarList[1]==data.p4Select)
		{
		GUI.DrawTexture (new Rect (Screen.width / 5, Screen.height / 2.58f, 230, 230), eAvatars [avatarList[1]]);
		}
		else
		{
		GUI.DrawTexture (new Rect (Screen.width / 5, Screen.height / 2.58f, 230, 230), avatars [avatarList[1]]);
		}
		
		if(avatarList[2]==data.p4Select)
		{
		GUI.DrawTexture (new Rect (Screen.width / 2.8f, Screen.height / 2.58f, 230, 230), eAvatars [avatarList[2]]);
		}
		else
		{	
		GUI.DrawTexture (new Rect (Screen.width / 2.8f, Screen.height / 2.58f, 230, 230), avatars [avatarList[2]]);	
		}
		
		if(avatarList[3]==data.p4Select)
		{
		GUI.DrawTexture (new Rect (Screen.width / 1.91f, Screen.height / 2.58f, 230, 230), eAvatars [avatarList[3]]);
		}
		else
		{
		GUI.DrawTexture (new Rect (Screen.width / 1.91f, Screen.height / 2.58f, 230, 230), avatars [avatarList[3]]);
		}
		
		GUI.DrawTexture (new Rect (Screen.width / 35, Screen.height / 2.8f, 100, 100), players [playerList[0]]);	
		GUI.DrawTexture (new Rect (Screen.width / 5, Screen.height / 2.8f, 100, 100), players [playerList[1]]);	
		GUI.DrawTexture (new Rect (Screen.width / 2.8f, Screen.height / 2.8f, 100, 100), players [playerList[2]]);	
		GUI.DrawTexture (new Rect (Screen.width / 1.91f, Screen.height / 2.8f, 100, 100), players [playerList[3]]);
		
		
		if(avatarList[0]==data.p4Select)
		{
		GUI.DrawTexture (new Rect (Screen.width / 1.4f, Screen.height / 7f,Screen.width/4,Screen.height/1.1f), eWinners [avatarList[0]]);
		}
		else
		{
		GUI.DrawTexture (new Rect (Screen.width / 1.4f, Screen.height / 7f,Screen.width/4,Screen.height/1.1f), winner [avatarList[0]]);
		}	
		
		GUI.skin=yellowText;
		GUI.Label(new Rect(Screen.width/2.8f,Screen.height/1.1f,Screen.width/2,Screen.height/10),"Press ");
		GUI.DrawTexture(new Rect(Screen.width/2.28f,Screen.height/1.12f,Screen.width/18,Screen.width/20),startButtonImg);
		GUI.Label(new Rect(Screen.width/2f,Screen.height/1.1f,Screen.width/2,Screen.height/10)," to continue");
		
		GUI.skin = Home;
		if (GUI.Button (new Rect (Screen.width / 120, Screen.height / 50, 150, 150), " ")) {
			audio.PlayOneShot(buttonClick);
			StartCoroutine(buttonClickPlay());
			
		}
		
		
		
	}
	
	IEnumerator buttonClickPlay()
	{
		yield return new WaitForSeconds(buttonClick.length);
		Application.LoadLevel ("MenuScene");
	}
}
