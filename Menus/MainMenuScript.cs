using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour
{
	public GUIStyle customButton;
	public Texture2D startButton;
	public Texture2D stopButton;
	
	public float sound = 10f;
	
	//	bool mute = false;s
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	public void Menu(string SceneToChange)
	{
		Application.LoadLevel(SceneToChange);
	}

	public void Quit()
	{
		Application.Quit();
	}
	
	public void AdjustSound(float newSound)
	{
		sound = newSound;
	}
	
	//	public bool Mute()
	//	{
	//		if (mute == false) 
	//		{
	//			sound = newSound;
	//		}
	//		else
	//		{
	//			sound = 0.0f;
	//			mute == true;
	//		}
	//	}
}
