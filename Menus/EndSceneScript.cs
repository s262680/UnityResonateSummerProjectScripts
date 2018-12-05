using UnityEngine;
using System.Collections;

public class EndSceneScript : MonoBehaviour {

	public Texture backgroundTexture;
	public GUIStyle customButton;
	public Texture2D stopButton;
	public GUISkin TextUI;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GameObject selectionData = GameObject.Find ("SelectionData");
		Data data = selectionData.GetComponent<Data> ();
		
		if (GUI.Button (new Rect (Screen.width/2,Screen.height / 2,100,100),stopButton, customButton)) 
		{
			Application.Quit();
		}

		GameObject sm = GameObject.Find ("ScoreManager");
		ScoreManager sms = sm.GetComponent<ScoreManager> ();
	
		GUI.skin = TextUI;
		GUI.Box (new Rect (Screen.width / 9.2f, Screen.height / 12, 100, 100),sms.p1Score.ToString());	
		GUI.Box (new Rect (Screen.width / 3.4f, Screen.height / 3, 100, 100),sms.p2Score.ToString());	
		GUI.Box (new Rect (Screen.width / 2.2f, Screen.height / 3, 100, 100),sms.p3Score.ToString());
		GUI.Box (new Rect (Screen.width / 1.65f, Screen.height / 3, 100, 100),sms.p4Score.ToString());
	
	
	}
}
