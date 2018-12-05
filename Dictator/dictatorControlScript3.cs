using UnityEngine;
using System.Collections;

public class dictatorControlScript3 : MonoBehaviour {
	
	public bool speedUpTrigger3=false;
	bool speedUpKeydown=false;
	public float speedUpDuration=3;
	
	public bool CoolD = false;
	public float timeCD = 10;
	public AudioClip click;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
		
	{
		
		GameObject cooldownDataObject = GameObject.Find("CooldownDataObject");
		CooldownData cdData=cooldownDataObject.GetComponent<CooldownData>();
		
		///////speed up control
		
//		if (Input.GetKey ("[3]") & cdData.speedUpCooldown<=0||(Input.GetAxis("LeftJoystickX4")>0&Input.GetButtonDown("X4")&cdData.speedUpCooldown<=0)) 
		if (Input.GetKey ("[3]") & cdData.speedUpCooldown<=0||(Input.GetAxis("LeftJoystickX4")>0.75f&cdData.speedUpCooldown<=0)) 
		{
			audio.PlayOneShot(click);
			
			speedUpKeydown = true;
			CoolD = true;
			
		;
		}
		if (CoolD == true & timeCD > 0) 
		{
			timeCD -= Time.deltaTime;
		}
		
		if (speedUpKeydown==true   & speedUpDuration > 0) 
		{
			
			speedUpTrigger3 = true;
			
			speedUpDuration -= Time.deltaTime;
			
			cdData.speedUpCooldown = 7.0f;
		} 
		
		
		else if (speedUpDuration <= 0) 
		{
			
			speedUpTrigger3=false;
			speedUpDuration=3;
			speedUpKeydown=false;
		}
	}
	
}