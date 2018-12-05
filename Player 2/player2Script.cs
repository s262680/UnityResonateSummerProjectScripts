using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class player2Script : MonoBehaviour
{
	//public GameObject deadFab;
	 float movementRate=6f;
	public Vector3 direction;
	bool qutting =false;
	public float speedUpDuration=2f;
	public bool abilityTrigger=false; 
//	AudioSource speedUP;
//	AudioSource hit;
	public Vector3 movementVector;
	
	private Animator animator;
	bool hasMoved=false;
	
	public bool CoolD = false;
	public float timeCD = 10;

	GameObject cooldownDataObject;
	CooldownData cdData;
	
	private int count;
	public Text Player2Score;

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
		
		cdData.player2Cooldown=0;
		
		hitEffectFab = (GameObject)Resources.Load("Prefabs/HitFlashFab", typeof(GameObject));
		skullFab = (GameObject)Resources.Load("Prefabs/skullFab", typeof(GameObject));
		
		//deadFab = (GameObject)Resources.Load("Prefabs/owlDead", typeof(GameObject));
		count = 0;
//		SetCountText();
//		AudioSource[] aSources = GetComponents<AudioSource>(); 
//		speedUP = aSources[0]; 
//		hit = aSources[1]; 

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
		if(Input.GetKey ("u")||Input.GetKey ("j")||Input.GetKey ("h")||Input.GetKey ("k")||Input.GetAxis("LeftJoystickX2")!=0||Input.GetAxis("LeftJoystickY2")!=0)
		{
			hasMoved=true;
		}
		else
		{
			hasMoved=false;
		}

		if (Input.GetKey ("u")) {
			transform.Translate (Vector3.up * movementRate * Time.deltaTime);
		}
		if (Input.GetKey ("j")) {
			transform.Translate (Vector3.down * movementRate * Time.deltaTime);
		}
		if (Input.GetKey ("h")) {
			transform.Translate (Vector3.left * movementRate * Time.deltaTime);
			if(transform.localScale.x>0)
			{
				transform.localScale=new Vector3(-Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
			}
		}
		if (Input.GetKey ("k")) {
			transform.Translate (Vector3.right * movementRate * Time.deltaTime);
			if(transform.localScale.x<0)
			{
				transform.localScale=new Vector3(Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
			}
		}
		
		
		
		if(Input.GetAxis("LeftJoystickX2")<0)
		{
			if(transform.localScale.x>0)
			{
				transform.localScale=new Vector3(-Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
			}
		}
		if(Input.GetAxis("LeftJoystickX2")>0)
		{
			if(transform.localScale.x<0)
			{
				transform.localScale=new Vector3(Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
			}
		}
		
		axisX=Input.GetAxis("LeftJoystickX2");
		if(axisX>0.0f)
		{
			axisX=Mathf.Min(axisX*3f,1.0f);
		}
		else
		{
			axisX=Mathf.Max(axisX*3f,-1.0f);
		}
		
		axisY=Input.GetAxis("LeftJoystickY2");
		if(axisY>0.0f)
		{
			axisY=Mathf.Min(axisY*3f,1.0f);
		}
		else
		{
			axisY=Mathf.Max(axisY*3f,-1.0f);
		}
		
		movementVector.x = axisX * movementRate;
		movementVector.y = axisY * movementRate;
		
		movementVector.x *= Time.deltaTime;
		movementVector.y *= Time.deltaTime;
		
		transform.Translate (movementVector.x, 0, 0);
		transform.Translate (0, movementVector.y, 0);
			
		if (Input.GetKeyDown ("space")|| Input.GetButtonDown ("A2")) 
		{
//			GameObject cooldownDataObject = GameObject.Find ("CooldownDataObject");
//			CooldownData cdData = cooldownDataObject.GetComponent<CooldownData> ();
			
			CoolD = true;
			
	//		OnGUI ();

			if (CoolD == true & timeCD > 0) 
			{
				timeCD -= Time.deltaTime;
//				print("I am Here");
			}

			if (cdData.player2Cooldown <= 0) 
			{
				OnEventHappen(1);
				//speedUP.Play();
				abilityTrigger = true;
			}
		}
		
		if (abilityTrigger == true) {
//			GameObject cooldownDataObject = GameObject.Find ("CooldownDataObject");
//			CooldownData cdData = cooldownDataObject.GetComponent<CooldownData> ();
			
			if (cdData.player2Cooldown <= 0) {
				
				movementRate = 10f;
				speedUpDuration -= Time.deltaTime;
				animator.speed=3.0f;
			}
			
			if (speedUpDuration <= 0) {
				cdData.player2Cooldown = 10f;
				movementRate = 6f;
				speedUpDuration = 2f;
				abilityTrigger = false;
			}
		}
	}


//
//	void SetCountText()
//	{
//		
//		Player2Score.text = "" + count.ToString ();
//		
//	}

	void OnTriggerEnter(Collider other)
	{
//		if (other.gameObject.tag == ("fruit")) 
//		{
//			GameObject sm = GameObject.Find ("ScoreManager");
//			ScoreManager sms = sm.GetComponent<ScoreManager> ();	
//			sms.p2Score+=1;
//		}

		if (other.gameObject.tag == ("cannonBall")) 
		{
			
			//transform.Translate(Vector3.left*5);
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();	
			sms.p4Score += 5;
		}
		if (other.gameObject.name==("Player1"))
		{
			direction=GameObject.Find("Player1").transform.position-this.gameObject.transform.position;
			other.rigidbody.AddForce(direction* 100.0f);
			
			spawnHitEffect(direction);
			//hit.Play ();
			OnEventHappen(2);
			//Debug.Log("abc");
		}
		if (other.gameObject.name==("Player3"))
		{
			direction=GameObject.Find("Player3").transform.position-this.gameObject.transform.position;
			other.rigidbody.AddForce(direction* 100.0f);
			
			spawnHitEffect(direction);
			//hit.Play ();
			OnEventHappen(2);
			//Debug.Log("abc");
		}
	}

	void spawnHitEffect(Vector3 dir)
	{
		GameObject effectOj = (GameObject)Instantiate(hitEffectFab, transform.position+dir, Quaternion.identity);
		effectOj.name = "hitEffect";
	}
	
	void OnApplicationQuit()
	{
		qutting=true;
	}

	void OnDestroy ()
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
		
		GameObject player1Spawn = GameObject.Find ("player2Spawn");
		player2RespawnScript player2 = player1Spawn.GetComponent<player2RespawnScript> ();
		player2.spawnTrigger = true;
	}
}
