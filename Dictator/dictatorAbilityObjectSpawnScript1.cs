using UnityEngine;
using System.Collections;

public class dictatorAbilityObjectSpawnScript1 : MonoBehaviour {

	public GameObject abilityObjectFab;
	bool cdTrigger=false;
	public float delay=0;
	public AudioClip click;


	public GUISkin TextUI; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject cooldownDataObject = GameObject.Find("CooldownDataObject");
		CooldownData cdData=cooldownDataObject.GetComponent<CooldownData>();
		
//		if (Input.GetKeyDown ("[4]") & cdData.abilityObjectCooldown<=0 & delay<=0||(Input.GetAxis("LeftJoystickX4")<0&Input.GetButtonDown("A4")&cdData.abilityObjectCooldown<=0&delay<=0)) 
		if (Input.GetKeyDown ("[4]") & cdData.abilityObjectCooldown<=0 & delay<=0||(Input.GetAxis("RightJoystickX4")<-0.75&&cdData.abilityObjectCooldown<=0&delay<=0)) 
		{
			SpawnAbilityObjects();
			audio.PlayOneShot(click);
			cdTrigger=true;
			delay=2f;			
	

		}

		if(delay>0)
		{
		delay-=Time.deltaTime;
		}
		
		if (cdTrigger & delay<=0)
		{
		cdData.abilityObjectCooldown=7;
		cdTrigger=false;
		}
	}

	
	public void SpawnAbilityObjects()
	{
		GameObject enemyObject = (GameObject)Instantiate(abilityObjectFab, transform.position, Quaternion.identity);
		enemyObject.name = "Ability Object";
	}
	public void OnGUI ()
	{

//		if (timeCD > 0 & CoolD == true) 
//		{
//			GUI.skin = TextUI;
//			GUI.Label (new Rect (Screen.width/1.165f, Screen.height/15f, 100, 40), "" + timeCD.ToString("F0"));
//
//		} 
//		else if (timeCD <= 0)
//		{
//			CoolD = false;
//			timeCD = 15;
//		}

//		GUI.Box (new Rect (Screen.width-270, Screen.height/2-440, 100, 120), " ");
		
	}
}