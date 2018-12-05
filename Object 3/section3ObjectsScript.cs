using UnityEngine;
using System.Collections;

public class section3ObjectsScript : MonoBehaviour {

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
		//if (!Gmanager.Instance.Paused) {
			transform.Translate (Vector3.up * movementRate * Time.deltaTime);
		//}
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == ("Player1")) {
			Destroy (other.gameObject);
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();	
			sms.p4Score += 2; 
		}
		if (other.gameObject.name == ("Player2")) {
			Destroy (other.gameObject);
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();	
			sms.p4Score += 2; 
		}
		if (other.gameObject.name == ("Player3")) {
			Destroy (other.gameObject);
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();	
			sms.p4Score += 2; 
		}
		if (other.gameObject.tag == ("minions")) {
			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}
	}
	
	void OnTriggerStay(Collider other)
	{

		
		GameObject Control3 = GameObject.Find("ControlSection3");
		dictatorControlScript3 dictator3=Control3.GetComponent<dictatorControlScript3>();
		
		if (other.gameObject.tag==("controlSection"))
		{
			if(!fadeTrigger)
			{
				tempSpeedHolder=movementRate;
				if(dictator3.speedUpTrigger3==true)
				{
					movementRate=20;
				}
				else if (dictator3.speedUpTrigger3==false)
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
