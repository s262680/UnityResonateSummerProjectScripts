using UnityEngine;
using System.Collections;

public class dictatorHoleScript : MonoBehaviour {
public AudioClip glassBreak;
//float timer=90f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//	timer-=Time.deltaTime;
//		if(timer<0)
//		{
		Destroy(this.gameObject,45f);
		//}
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == ("Player1")) 
		{
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();
			sms.p4Score+=5;
			Destroy(other.gameObject);

		}
		if (other.gameObject.name == ("Player2")) 
		{
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();
			sms.p4Score+=5;
			Destroy(other.gameObject);
		}
		if (other.gameObject.name == ("Player3")) 
		{
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();
			sms.p4Score+=5;
			Destroy(other.gameObject);
		}
		if (other.gameObject.tag == ("minions")) {
		
			//Debug.Log("abc");
			Destroy (other.gameObject);
			
	
		}
	}
}
