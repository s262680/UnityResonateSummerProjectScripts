using UnityEngine;
using System.Collections;

public class DictatorSceneScript : MonoBehaviour {
	Color guiColor;
	public Texture2D[] dictator;
	public GUISkin next;
	float rate=0;
	GameObject selectionData;
	Data data;
	public AudioClip buttonClick;
	public Texture2D startButtonImg;
	public GUISkin yellowText;
	// Use this for initialization
	void Start () {
	
		selectionData = GameObject.Find ("SelectionData");
		data = selectionData.GetComponent<Data> ();
		
	}
	
	// Update is called once per frame
	void Update () {
	if(rate<1)
	{
	rate+=Time.deltaTime*0.5f;
	}
	guiColor=new Color(1f,1f,1f,Mathf.Clamp(rate,0f,1f));
	
		if(Input.GetButtonDown("Start"))
		{
			audio.PlayOneShot(buttonClick);
			StartCoroutine(buttonClickPlay());
		}
	}
	
	void OnGUI()
	{
		GUI.color=guiColor;
		
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),dictator[data.p4Select]);
		
		GUI.skin=yellowText;
		GUI.Label(new Rect(Screen.width/2.8f,Screen.height/1.1f,Screen.width/2,Screen.height/10),"Press ");
		GUI.DrawTexture(new Rect(Screen.width/2.28f,Screen.height/1.12f,Screen.width/18,Screen.width/20),startButtonImg);
		GUI.Label(new Rect(Screen.width/2f,Screen.height/1.1f,Screen.width/2,Screen.height/10)," to continue");
		
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
		Application.LoadLevel ("GameScene");
	}
}
