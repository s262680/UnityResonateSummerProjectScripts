using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class dictatorAbilityObject3Script : MonoBehaviour {
	 float movementRate=15f;

	private int count;
	public Text DictatorScore;
	// Use this for initialization
	void Start () 
	{
		count = 0;
		SetCountText();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (Vector3.down * movementRate * Time.deltaTime);
	}

	void SetCountText()
	{
		
		DictatorScore.text = "" + count.ToString ();
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == ("Player1")) 
		{
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();;
			sms.p4Score+=10;
			Destroy(other.gameObject);
		}
		if (other.gameObject.name == ("Player2")) 
		{
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();
			sms.p4Score+=10;
			Destroy(other.gameObject);
		}
		if (other.gameObject.name == ("Player3")) 
		{
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();
			sms.p4Score+=10;
			Destroy(other.gameObject);
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
