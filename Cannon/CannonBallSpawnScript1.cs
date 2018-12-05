using UnityEngine;
using System.Collections;

public class CannonBallSpawnScript1 : MonoBehaviour {
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
	void Update () 
	{
		
		GameObject cooldownDataObject = GameObject.Find("CooldownDataObject");
		CooldownData cdData=cooldownDataObject.GetComponent<CooldownData>();
		
		
//		if (Input.GetKey ("[7]") & cdData.cannonCooldown1<=0||(Input.GetAxis("LeftJoystickY4")>0&Input.GetButtonDown("B4")&cdData.cannonCooldown1<=0))
		if (Input.GetKey ("[7]") & cdData.cannonCooldown1<=0||(Input.GetButtonDown("Y4")&cdData.cannonCooldown1<=0))
		{
			SpawnCannonBall();
			audio.PlayOneShot(fire);
			cdData.cannonCooldown1 = 10.0f;
			
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
		enemyObject.name = "CannonBall";
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
//	}
}
