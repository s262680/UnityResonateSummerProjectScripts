using UnityEngine;
using System.Collections;

public class CharSelectScript : MonoBehaviour {
	bool guiTrigger1=false;
	bool guiTrigger2=false;
	bool guiTrigger3=false;
	bool guiTrigger4=false;
	public GUISkin PlayButton;
	public GUISkin SelectButton;

	public Texture2D fox;
	public Texture2D owl;
	public Texture2D pen;
	public Texture2D bear;
	public Texture2D bunny;
	public Texture2D efox;
	public Texture2D eowl;
	public Texture2D epen;
	public Texture2D ebear;
	public Texture2D ebunny;
	public Texture2D[] charList;
	public Texture2D[] echarList;
	bool rayCheck=false;
	public int p1=5;
	public int p2=5;
	public int p3=5;
	public int p4=5;
	public Data data;
	public AudioClip buttonClick;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("Fire1")) 
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit= new RaycastHit();
			
			if (Physics.Raycast(ray, out hit)&&rayCheck==false)
			{
				if(hit.collider.gameObject.tag=="selection1")
				{
					audio.PlayOneShot(buttonClick);
				//Debug.Log ("abc");
				guiTrigger1=true;
					rayCheck=true;
				}
				if(hit.collider.gameObject.tag=="selection2")
				{
					audio.PlayOneShot(buttonClick);
					guiTrigger2=true;
					rayCheck=true;
				}
				if(hit.collider.gameObject.tag=="selection3")
				{
					audio.PlayOneShot(buttonClick);
					guiTrigger3=true;
					rayCheck=true;
				}
				if(hit.collider.gameObject.tag=="selection4")
				{
					audio.PlayOneShot(buttonClick);
					guiTrigger4=true;
					rayCheck=true;
				}
			}
	
		}
		data.p1Select=p1;
		data.p2Select=p2;
		data.p3Select=p3;
		data.p4Select=p4;
	}
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(Screen.width/5.5f,Screen.height/12,Screen.width/6,Screen.height/1.2f),charList[p1]);
		GUI.DrawTexture(new Rect(Screen.width/2.6f,Screen.height/12,Screen.width/6,Screen.height/1.2f),charList[p2]);
		GUI.DrawTexture(new Rect(Screen.width/1.7f,Screen.height/12,Screen.width/6,Screen.height/1.2f),charList[p3]);
		GUI.DrawTexture(new Rect(Screen.width/1.25f,Screen.height/12,Screen.width/6,Screen.height/1.2f),echarList[p4]);
		
		if(guiTrigger1==true)
		{
			
			GUI.Box(new Rect(0,0,Screen.width,Screen.height),"");
			GUI.DrawTexture(new Rect(Screen.width/14,Screen.height/10,Screen.width/6,Screen.height/1.5f),fox);
			GUI.DrawTexture(new Rect(Screen.width/4,Screen.height/10,Screen.width/6,Screen.height/1.5f),owl);
			GUI.DrawTexture(new Rect(Screen.width/2.3f,Screen.height/10,Screen.width/6,Screen.height/1.5f),bear);
			GUI.DrawTexture(new Rect(Screen.width/1.6f,Screen.height/10,Screen.width/6,Screen.height/1.5f),pen);
			GUI.DrawTexture(new Rect(Screen.width/1.25f,Screen.height/10,Screen.width/6,Screen.height/1.5f),bunny);

			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/7,Screen.height/1.2f,100,100),""))
			{	
				audio.PlayOneShot(buttonClick);
				p1=0;
				guiTrigger1=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/3.4f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p1=1;
				guiTrigger1=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/2.1f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p1=2;
				guiTrigger1=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/1.48f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p1=3;
				guiTrigger1=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/1.19f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p1=4;
				guiTrigger1=false;
				rayCheck=false;
			}
		}
		
		if(guiTrigger2==true)
		{
			GUI.Box(new Rect(0,0,Screen.width,Screen.height),"");
			GUI.DrawTexture(new Rect(Screen.width/14,Screen.height/10,Screen.width/6,Screen.height/1.5f),fox);
			GUI.DrawTexture(new Rect(Screen.width/4,Screen.height/10,Screen.width/6,Screen.height/1.5f),owl);
			GUI.DrawTexture(new Rect(Screen.width/2.3f,Screen.height/10,Screen.width/6,Screen.height/1.5f),bear);
			GUI.DrawTexture(new Rect(Screen.width/1.6f,Screen.height/10,Screen.width/6,Screen.height/1.5f),pen);
			GUI.DrawTexture(new Rect(Screen.width/1.25f,Screen.height/10,Screen.width/6,Screen.height/1.5f),bunny);

			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/7,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p2=0;
				guiTrigger2=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/3.4f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p2=1;
				guiTrigger2=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/2.1f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p2=2;
				guiTrigger2=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/1.48f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p2=3;
				guiTrigger2=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/1.19f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p2=4;
				guiTrigger2=false;
				rayCheck=false;
			}
		}
		
		if(guiTrigger3==true)
		{

			GUI.Box(new Rect(0,0,Screen.width,Screen.height),"");
			GUI.DrawTexture(new Rect(Screen.width/14,Screen.height/10,Screen.width/6,Screen.height/1.5f),fox);
			GUI.DrawTexture(new Rect(Screen.width/4,Screen.height/10,Screen.width/6,Screen.height/1.5f),owl);
			GUI.DrawTexture(new Rect(Screen.width/2.3f,Screen.height/10,Screen.width/6,Screen.height/1.5f),bear);
			GUI.DrawTexture(new Rect(Screen.width/1.6f,Screen.height/10,Screen.width/6,Screen.height/1.5f),pen);
			GUI.DrawTexture(new Rect(Screen.width/1.25f,Screen.height/10,Screen.width/6,Screen.height/1.5f),bunny);


			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/7,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p3=0;
				guiTrigger3=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/3.4f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p3=1;
				guiTrigger3=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/2.1f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p3=2;
				guiTrigger3=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/1.48f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p3=3;
				guiTrigger3=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/1.19f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p3=4;
				guiTrigger3=false;
				rayCheck=false;
			}
		}
		
		if(guiTrigger4==true)
		{
			GUI.Box(new Rect(0,0,Screen.width,Screen.height),"");
			GUI.DrawTexture(new Rect(Screen.width/14,Screen.height/10,Screen.width/6,Screen.height/1.5f),efox);
			GUI.DrawTexture(new Rect(Screen.width/4,Screen.height/10,Screen.width/6,Screen.height/1.5f),eowl);
			GUI.DrawTexture(new Rect(Screen.width/2.3f,Screen.height/10,Screen.width/6,Screen.height/1.5f),ebear);
			GUI.DrawTexture(new Rect(Screen.width/1.6f,Screen.height/10,Screen.width/6,Screen.height/1.5f),epen);
			GUI.DrawTexture(new Rect(Screen.width/1.25f,Screen.height/10,Screen.width/6,Screen.height/1.5f),ebunny);

			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/7,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p4=0;
				guiTrigger4=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/3.4f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p4=1;
				guiTrigger4=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/2.1f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p4=2;
				guiTrigger4=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/1.48f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p4=3;
				guiTrigger4=false;
				rayCheck=false;
			}
			GUI.skin = SelectButton;
			if(GUI.Button(new Rect(Screen.width/1.19f,Screen.height/1.2f,100,100),""))
			{
				audio.PlayOneShot(buttonClick);
				p4=4;
				guiTrigger4=false;
				rayCheck=false;
			}
		}
		if (guiTrigger1 == false && guiTrigger2== false && guiTrigger3== false && guiTrigger4== false) 
		{
			GUI.skin = PlayButton;
			
			if (GUI.Button (new Rect (Screen.width /15, Screen.height / 1.26f, 150, 150), " ")) 
			{
				audio.PlayOneShot(buttonClick);
				StartCoroutine(buttonClickPlay());
			
			}
		}
		
		
	}
               IEnumerator buttonClickPlay()
               {
					yield return new WaitForSeconds(buttonClick.length);
					Application.LoadLevel ("DictatorScene");
				}
}
