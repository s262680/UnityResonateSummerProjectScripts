using UnityEngine;
using System.Collections;

public class dictatorObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		GameObject selectionData = GameObject.Find ("SelectionData");
		Data data = selectionData.GetComponent<Data> ();
		
		if (other.gameObject.tag == "Player") 
		{
			data.level+=1;
			Application.LoadLevel("Round1Score");
		}

		if (other.gameObject.name == "Player1") 
		{
			data.winnerTrigger=1;
			
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();
			sms.p1Score+=50;
	
		}
		if (other.gameObject.name == "Player2") 
		{
			data.winnerTrigger=2;
			
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();
			sms.p2Score+=50;
		
			
		}
		if (other.gameObject.name == "Player3") 
		{
			data.winnerTrigger=3;
			
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();
			sms.p3Score+=50;
	
			
		}
		
	}
}
