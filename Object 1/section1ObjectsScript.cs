using UnityEngine;
using System.Collections;

public class section1ObjectsScript : MonoBehaviour {

	 float movementRate=10;
	public float tempSpeedHolder;
	Animator animator;
	
	public SpriteRenderer[] fade;
	float fadeRate=1.0f;
	bool fadeTrigger=false;
	
	// Use this for initialization
	void Start () {
		animator=GetComponentInChildren<Animator>();
		animator.speed=2.0f;
		
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(fadeTrigger)
		{
			fadeRate-=Time.deltaTime;

			foreach(SpriteRenderer sr in fade)
			{
			sr.color = new Color (1f, 1f, 1f, fadeRate);
			}
			
		}
		//if (!Gmanager.Instance.Paused) 
		//{
			transform.Translate (Vector3.up * movementRate * Time.deltaTime);
		//}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == ("Player1")) 
		{
			Destroy (other.gameObject);
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();	
			sms.p4Score += 2; 
		}
		if (other.gameObject.name == ("Player2")) 
		{
			Destroy (other.gameObject);
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();	
			sms.p4Score += 2; 
		}
		if (other.gameObject.name == ("Player3")) 
		{
			Destroy (other.gameObject);
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();	
			sms.p4Score += 2; 
		}
		if (other.gameObject.tag == ("minions")) 
		{
			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}
		
		
	}

	void OnTriggerStay(Collider other)
	{
		GameObject Control1 = GameObject.Find("ControlSection1");
		dictatorControlScript1 dictator1=Control1.GetComponent<dictatorControlScript1>();

		if (other.gameObject.tag==("controlSection"))
		{
		if(!fadeTrigger)
		{
			//tempSpeedHolder=movementRate;
			if(dictator1.speedUpTrigger1==true )
			{
				movementRate=20;
			}
			else if (dictator1.speedUpTrigger1==false)
			{
			
				movementRate=10;
			}
		}

		}
		
		if (other.gameObject.tag==("fadeBorder"))
		{
			fadeTrigger=true;
			movementRate=0;
					
			if(fadeRate<=0)
			{		
				Destroy (this.gameObject);
			}
		}


	}
}
