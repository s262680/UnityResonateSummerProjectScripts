using UnityEngine;
using System.Collections;

public class CannonBallScript1 : MonoBehaviour {

//	float ct=0;
//	float tt=500f;
//
//	Vector3 startPos;
//
//	// Use this for initialization
//	void Start () {
//		startPos=GameObject.Find ("Cannon1").transform.position;
//	}
//	
//	// Update is called once per frame
//	void Update () 
//	{
//		StartCoroutine (Lerp ());
//	}
//
//	IEnumerator Lerp()
//	{
//		while (ct<tt)
//		{
//			ct += Time.deltaTime;
//			transform.position = Vector3.Lerp (startPos,GameObject.Find ("Player1").transform.position, ct / tt);
//			yield return 0;
//			//GameObject.Find ("test").transform.position, GameObject.Find ("Player1").transform.position
//		}
//	}

	void Update()
	{
		transform.Translate(Vector3.left*30*Time.deltaTime);
	}
	
    void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag == ("Player")) 
		{
//			GameObject sm = GameObject.Find ("ScoreManager");
//			ScoreManager sms = sm.GetComponent<ScoreManager> ();	
//			sms.p4Score += 5; 
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag == ("minions")) 
		{
			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}
		if (other.gameObject.tag == ("fadeBorder")) 
		{
			
			Destroy (this.gameObject);
		}
	}
}
