using UnityEngine;
using System.Collections;

public class SplashRemakeScript : MonoBehaviour {

	public Texture2D bg;
	public Texture2D title;	
	float rate=0;
	Color guiColor;
	float sizeX;
	float sizeY;
	float pos;
	public GUISkin empty;
	public AudioClip buttonClick;
	// Use this for initialization
	void Start () {
	sizeX=Screen.width;
	sizeY=Screen.height;
	pos=0;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(rate<1)
		{
			rate+=Time.deltaTime*0.5f;
			sizeX-=Time.deltaTime*300f;
			sizeY-=Time.deltaTime*300f;		
			pos+=Time.deltaTime*200f;
		}
		guiColor=new Color(1f,1f,1f,rate);
		
		if(Input.GetButtonDown("Start"))
		{
			audio.PlayOneShot(buttonClick);
			StartCoroutine(buttonClickPlay());
		}
	}
	
	void OnGUI()
	{
		GUI.skin=empty;
		if(GUI.Button(new Rect(0,0,Screen.width,Screen.height)," "))
		{
			audio.PlayOneShot(buttonClick);
			StartCoroutine(buttonClickPlay());
		}
		
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),bg);
		GUI.color=guiColor;
		
		GUI.DrawTexture(new Rect(Screen.width/6,Screen.height/3.5f,sizeX,sizeY),title);
		
		
		
		
	
//		GUI.skin=next;
//		if(GUI.Button(new Rect(Screen.width/1.08f,Screen.height/1.15f,Screen.width/16,Screen.width/16)," "))
//		{
//			Application.LoadLevel("GameScene");
//		}
	}
	
	IEnumerator buttonClickPlay()
	{
		yield return new WaitForSeconds(buttonClick.length);
		Application.LoadLevel ("MenuScene");
	}
}
