using UnityEngine;
using System.Collections;

public class MenuUI : MonoBehaviour 
{
	public GUISkin PlaySkin;
	public GUISkin OptionSkin;
	public GUISkin QuitSkin;
	public GUISkin arrow;
	public GUISkin x;
	public Texture2D[] instructions;
	int pages=0;
	public AudioClip buttonClick;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("Start"))
		{
			audio.PlayOneShot(buttonClick);
			StartCoroutine(buttonClickPlay());
		}
	}

	public void Menu(string SceneToChange)
	{
		Application.LoadLevel(SceneToChange);
	}

	void OnGUI()
	{

			GUI.skin = PlaySkin;

			if (GUI.Button (new Rect (Screen.width / 3.7f, Screen.height / 3.2f, 250, 250), " ")) 
			{
				audio.PlayOneShot(buttonClick);
				StartCoroutine(buttonClickPlay());			
			}

			GUI.skin = OptionSkin;

			if (GUI.Button (new Rect (Screen.width / 2.28f, Screen.height / 3.2f, 250, 250), " ")) 
			{		
				audio.PlayOneShot(buttonClick);
				pages=1;
				
			}
			
	
			GUI.skin = QuitSkin;
		
			if (GUI.Button (new Rect (Screen.width / 1.65f, Screen.height / 3.2f, 250, 250), " ")) 
			{
				audio.PlayOneShot(buttonClick);
				StartCoroutine(buttonClickQuit());
			}
			
			GUI.skin=null;
		if(pages==1)
		{
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),instructions[0]);
		}
		if(pages==2)
		{
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),instructions[1]);		
		}
		
		
		GUI.skin=arrow;
		if(pages==1)
		{
			if (GUI.Button (new Rect (Screen.width / 1.2f, Screen.height / 1.15f, Screen.width/15,Screen.width/15), " ")) 
			{
				audio.PlayOneShot(buttonClick);
				pages=2;
			}
		}
		GUI.skin=x;
		if(pages==1||pages==2)
		{
			if (GUI.Button (new Rect (Screen.width / 1.11f, Screen.height / 1.15f, Screen.width/15,Screen.width/15), " ")) 
			{
				audio.PlayOneShot(buttonClick);
				pages=0;
			}
		}
		
	}
	
	IEnumerator buttonClickPlay()
	{
		yield return new WaitForSeconds(audio.clip.length);
		Application.LoadLevel ("CharSelect");
	}
	IEnumerator buttonClickQuit()
	{
		yield return new WaitForSeconds(audio.clip.length);
		Application.Quit();
	}
	



}
