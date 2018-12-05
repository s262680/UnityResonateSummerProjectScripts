using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class player1Script : MonoBehaviour {
	//public GameObject deadFab;
	float movementRate=6f;
	public Vector3 direction;
	bool qutting = false ;
	public float speedUpDuration=2f;
	public bool abilityTrigger=false; 
	public Vector3 movementVector;
//	 public AudioClip speedUP;
//	 public AudioClip hit;
	//public AudioSource[] aSources;
	public bool CoolD = false;
	public float timeCD = 10;
	//public AudioClip aaa;
	
	GameObject cooldownDataObject;
	CooldownData cdData;
	
	private Animator animator;
	bool hasMoved=false;
	
	private int count;
	public Text Player1Score;
	
	public GameObject hitEffectFab;
	public GameObject skullFab;
	
	float axisX;
	float axisY;
	
	public delegate void EventPlaySound(int check);
	public static event EventPlaySound OnEventHappen;

	// Use this for initialization
	void Start () 
	{
		cooldownDataObject = GameObject.Find ("CooldownDataObject");
		cdData = cooldownDataObject.GetComponent<CooldownData> ();
		
		cdData.player1Cooldown=0;
		
		hitEffectFab = (GameObject)Resources.Load("Prefabs/HitFlashFab", typeof(GameObject));
		skullFab = (GameObject)Resources.Load("Prefabs/skullFab", typeof(GameObject));
		
		//deadFab = (GameObject)Resources.Load("Prefabs/foxDead", typeof(GameObject));
		//print ("start");
		count = 0;
		//SetCountText();
//		aSources = GetComponents<AudioSource>(); 
//		if (aSources != null) {
//			speedUP = aSources [0]; 
//			hit = aSources [1]; 
//		} else {
//			print ("audio not found "+gameObject.name);
//		}
//		aSources[0].Play();
		
		animator=GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{

		//if (!Gmanager.Instance.Paused) 
		//{
		
		animator.speed=1.0f;
		if(!hasMoved)
		{
		animator.speed=0;
		}
		if(Input.GetKey ("w")||Input.GetKey ("s")||Input.GetKey ("a")||Input.GetKey ("d")||Input.GetAxis("LeftJoystickX1")!=0||Input.GetAxis("LeftJoystickY1")!=0)
		{
			hasMoved=true;
		}
		else
		{
			hasMoved=false;
		}
		
		
		if (Input.GetKey ("w")) {
			transform.Translate (Vector3.up * movementRate * Time.deltaTime);		
		}
		if (Input.GetKey ("s")) {
			transform.Translate (Vector3.down * movementRate * Time.deltaTime);
		}
		if (Input.GetKey ("a")) {
			transform.Translate (Vector3.left * movementRate * Time.deltaTime);
			if(transform.localScale.x>0)
			{
				transform.localScale=new Vector3(-Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
			}
		}
		if (Input.GetKey ("d")) {
			transform.Translate (Vector3.right * movementRate * Time.deltaTime);
			if(transform.localScale.x<0)
			{
				transform.localScale=new Vector3(Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
			}
		}
		
		
			
		if(Input.GetAxis("LeftJoystickX1")<0)
		{
			if(transform.localScale.x>0)
			{
				transform.localScale=new Vector3(-Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
			}
		}
		if(Input.GetAxis("LeftJoystickX1")>0)
		{
			if(transform.localScale.x<0)
			{
				transform.localScale=new Vector3(Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
			}
		}
		
		
		axisX=Input.GetAxis("LeftJoystickX1");
		if(axisX>0.0f)
		{
			axisX=Mathf.Min(axisX*3f,1.0f);
		}
		else
		{
			axisX=Mathf.Max(axisX*3f,-1.0f);
		}
		
		axisY=Input.GetAxis("LeftJoystickY1");
		if(axisY>0.0f)
		{
			axisY=Mathf.Min(axisY*3f,1.0f);
		}
		else
		{
			axisY=Mathf.Max(axisY*3f,-1.0f);
		}
		
//		if(axisX/axisY<2f&axisX/axisY>0.5f||axisX/axisY>-1.5f&axisX/axisY<-0.5f)
//		{
//			if(axisX>0.0f)
//			{
//				axisX=Mathf.Min(axisX*3f,1.0f);
//			}
//			else
//			{
//				axisX=Mathf.Max(axisX*3f,-1.0f);
//			}
//			axisY=Input.GetAxis("LeftJoystickY1");
//			if(axisY>0.0f)
//			{
//				axisY=Mathf.Min(axisY*3f,1.0f);
//			}
//			else
//			{
//				axisY=Mathf.Max(axisY*3f,-1.0f);
//			}
//		}
//		
		
		movementVector.x = axisX * movementRate;
		movementVector.y = axisY * movementRate;
		                               
		movementVector.x *= Time.deltaTime;
		movementVector.y *= Time.deltaTime;
		
		transform.Translate (movementVector.x, 0, 0);
		transform.Translate (0, movementVector.y, 0);
		
		
		
		if (Input.GetKeyDown ("left shift") || Input.GetButtonDown ("A1")) 
		{
//			GameObject cooldownDataObject = GameObject.Find ("CooldownDataObject");
//			CooldownData cdData = cooldownDataObject.GetComponent<CooldownData> ();	
//		
			CoolD = true;
		
//			OnGUI ();
		
			if (CoolD == true & timeCD > 0) 
			{
				timeCD -= Time.deltaTime;
			}
		
			if (cdData.player1Cooldown <= 0) {
				OnEventHappen(1);
				abilityTrigger = true;
			}
		}
	
	if (abilityTrigger == true) 
			{
//		GameObject cooldownDataObject = GameObject.Find ("CooldownDataObject");
//		CooldownData cdData = cooldownDataObject.GetComponent<CooldownData> ();
		
		if (cdData.player1Cooldown <= 0) {
			
			movementRate = 10f;
			speedUpDuration -= Time.deltaTime;
			animator.speed=3.0f;
		}
		
		if (speedUpDuration <= 0) {
			cdData.player1Cooldown = 10f;
			movementRate = 6f;
			speedUpDuration = 2f;
			abilityTrigger = false;
		}
	}
}

//		public void OnGUI ()
//		{
//			
//			if (timeCD > 0 & CoolD == true) 
//			{
//				GUI.contentColor = Color.green;
//			GUI.Box (new Rect (Screen.width-1850, Screen.height/2-360, 100, 25)," ");
//				GUI.Label (new Rect (Screen.width-1850, Screen.height/2-360, 100, 25),"P1 Sprint CD: " + timeCD.ToString("F0"));
//			} 
//			else if (timeCD <= 0)
//			{
//				CoolD = false;
//				timeCD = 10;
//			}
//			
//		}

//	void SetCountText()
//	{
//		
//		Player1Score.text = "" + count.ToString ();
//
//	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == ("fruit")) 
		{

		}
		if (other.gameObject.tag == ("cannonBall")) 
		{

			//transform.Translate(Vector3.left*5);
			Destroy (other.gameObject);
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();	
			sms.p4Score += 5;
		}

		if (other.gameObject.name==("Player2"))
		{
			direction=GameObject.Find("Player2").transform.position-this.gameObject.transform.position;
			other.rigidbody.AddForce(direction* 100.0f);
			
			spawnHitEffect(direction);
			
			OnEventHappen(2);
			//Debug.Log("abc");
		}
		if (other.gameObject.name==("Player3"))
		{
			direction=GameObject.Find("Player3").transform.position-this.gameObject.transform.position;
			other.rigidbody.AddForce(direction* 100.0f);
			
			spawnHitEffect(direction);
		
			OnEventHappen(2);
			//Debug.Log("abc");
		}
	}
	
	void OnApplicationQuit()
	{
		qutting=true;
	}

	void spawnHitEffect(Vector3 dir)
	{
		GameObject effectOj = (GameObject)Instantiate(hitEffectFab, transform.position+dir, Quaternion.identity);
		effectOj.name = "hitEffect";
	}

	void OnDestroy()
	{
//		if(!qutting)
//		{
//		GameObject enemyObject = (GameObject)Instantiate(deadFab, transform.position, Quaternion.identity);
//		enemyObject.name = "dead";
//		}
		if(!qutting)
		{
			GameObject skull = (GameObject)Instantiate(skullFab, transform.position, Quaternion.identity);
			skull.name = "skull";
		}
		
		GameObject player1Spawn = GameObject.Find ("player1Spawn");
		player1RespawnScript player1 = player1Spawn.GetComponent<player1RespawnScript> ();
		player1.spawnTrigger = true;
		
	}
	
	
}
