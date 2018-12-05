using UnityEngine;
using System.Collections;

public class CannonBallSpawnScript2 : MonoBehaviour {
	public GameObject CannonBallFab;
	public GameObject CannonBallFabUp;
	public GameObject CannonBallFabDown;
	public GameObject boomFab;
	
	public bool CoolD = false;
	float timeCD = 10;
	public AudioClip fire;

	public GUISkin TextUI;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		GameObject cooldownDataObject = GameObject.Find("CooldownDataObject");
		CooldownData cdData=cooldownDataObject.GetComponent<CooldownData>();
		
		
//		if (Input.GetKey ("[8]") & cdData.cannonCooldown2<=0||(Input.GetAxis("LeftJoystickX4")<0&Input.GetButtonDown("B4")&cdData.cannonCooldown2<=0)) 
		if (Input.GetKey ("[8]") & cdData.cannonCooldown2<=0||(Input.GetButtonDown("X4")&&cdData.cannonCooldown2<=0)) 
		{
			SpawnCannonBall();
			audio.PlayOneShot(fire);
			cdData.cannonCooldown2 = 10.0f;

			CoolD = true;
			
			//OnGUI ();
		}
		if (CoolD == true & timeCD > 0) 
		{
			timeCD -= Time.deltaTime;
		}
	}
	
	public void SpawnCannonBall()
	{
		GameObject enemyObject = (GameObject)Instantiate(CannonBallFab, transform.position, Quaternion.identity);
		enemyObject.name = "CannonBall2";
		GameObject enemyObjectUp = (GameObject)Instantiate(CannonBallFabUp, transform.position, Quaternion.identity);
		enemyObject.name = "CannonBall";
		GameObject enemyObjectDown = (GameObject)Instantiate(CannonBallFabDown, transform.position, Quaternion.identity);
		enemyObject.name = "CannonBall";
		
		GameObject boom = (GameObject)Instantiate(boomFab, transform.position+new Vector3(-1.5f,0,0), Quaternion.identity);
		boom.name = "boomEffect";
	}

//	public void OnGUI ()
//	{
//		
//		if (timeCD > 0 & CoolD == true) 
//		{
//			GUI.skin = TextUI;
//			GUI.Label (new Rect (Screen.width/1.195f, Screen.height/9f, 100, 40), "" + timeCD.ToString("F0"));
//			//GUI.Box(new Rect (Screen.width-140, Screen.height/2+55, 100, 25)," ");
//		} 
//		else if (timeCD <= 0)
//		{
//			CoolD = false;
//			timeCD = 20;
//		}
//		
//	}
}
