using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour 
{

	//	public GUISkin PauseSplash;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	if (Input.GetKey ("p")) 
		{
			Time.timeScale = 0;
//			OnGUI();

		} 
		else if (Input.GetKey ("o")) 
		{
			Time.timeScale=1;
		}
	}

//	void OnGUI()
//	{
//
//		GUI.Label(new Rect(Screen.width/2,Screen.height/2, 400, 400),PauseSplash);
//	
//	}

}
