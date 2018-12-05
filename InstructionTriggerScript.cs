using UnityEngine;
using System.Collections;

public class InstructionTriggerScript : MonoBehaviour {

	public GUISkin arrow;
	public GUISkin x;

	public Texture2D[] instructions;
	int pages=0;
	public AudioClip buttonClick;
	public Texture2D startButtonImg;
	public GUISkin yellowText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Start"))
		{
			audio.PlayOneShot(buttonClick);
			pages++;
		}
	}
	
	void OnGUI()
	{
		
		if(pages==0)
		{
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),instructions[0]);
			GUI.skin=yellowText;
			GUI.Label(new Rect(Screen.width/2.8f,Screen.height/1.1f,Screen.width/2,Screen.height/10),"Press ");
			GUI.DrawTexture(new Rect(Screen.width/2.28f,Screen.height/1.12f,Screen.width/18,Screen.width/20),startButtonImg);
			GUI.Label(new Rect(Screen.width/2f,Screen.height/1.1f,Screen.width/2,Screen.height/10)," to continue");
		}
		if(pages==1)
		{
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),instructions[1]);	
			GUI.skin=yellowText;
			GUI.Label(new Rect(Screen.width/2.8f,Screen.height/1.1f,Screen.width/2,Screen.height/10),"Press ");
			GUI.DrawTexture(new Rect(Screen.width/2.28f,Screen.height/1.12f,Screen.width/18,Screen.width/20),startButtonImg);
			GUI.Label(new Rect(Screen.width/2f,Screen.height/1.1f,Screen.width/2,Screen.height/10)," to continue");	
		}
		if(pages==2)
		{
			Destroy(this.gameObject);
		}
		
		GUI.skin=arrow;
		if(pages==0)
		{
			if (GUI.Button (new Rect (Screen.width / 1.2f, Screen.height / 1.15f, Screen.width/15,Screen.width/15), " ")) 
			{
				audio.PlayOneShot(buttonClick);
				pages=1;
			}
		}
		GUI.skin=x;
		if(pages==1)
		{
			if (GUI.Button (new Rect (Screen.width / 1.11f, Screen.height / 1.15f, Screen.width/15,Screen.width/15), " ")) 
			{
				audio.PlayOneShot(buttonClick);
				pages=2;
			}
		}
		
		
//		if(pages==0)
//		{
//			GUI.Box(new Rect(Screen.width/12f,Screen.height/12f,Screen.width/1.2f,Screen.height/1.2f),instructions[0]);
//		}
//		if(pages==1)
//		{
//			GUI.Box(new Rect(Screen.width/12f,Screen.height/12f,Screen.width/1.2f,Screen.height/1.2f),instructions[1]);		}
//		if(pages==2)
//		{
//			Destroy(this.gameObject);
//		}
//		GUI.skin=arrow;
//		if(pages==0)
//		{
//			if (GUI.Button (new Rect (Screen.width / 1.13f, Screen.height / 2f, Screen.width/15,Screen.width/15), " ")) 
//			{
//				pages=1;
//			}
//		}
//		GUI.skin=x;
//		if (GUI.Button (new Rect (Screen.width / 1.13f, Screen.height / 20f, Screen.width/15,Screen.width/15), " ")) 
//		{
//			pages=2;
//		}
	}
}
