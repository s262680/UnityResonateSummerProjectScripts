using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {
	public AudioClip speedUP;
	public AudioClip hit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void PlaySpeedSound(int i)
	{
		if (i == 1) 
		{
			audio.PlayOneShot(speedUP);

		}
		if (i == 2) 
		{
			audio.PlayOneShot(hit);
		}
	}


	void OnEnable()
	{
		player1Script.OnEventHappen += PlaySpeedSound;
		player2Script.OnEventHappen += PlaySpeedSound;
		player3Script.OnEventHappen += PlaySpeedSound;
	}

	void OnDisable()
	{
		player1Script.OnEventHappen -= PlaySpeedSound;
		player2Script.OnEventHappen -= PlaySpeedSound;
		player3Script.OnEventHappen -= PlaySpeedSound;
	}
}
