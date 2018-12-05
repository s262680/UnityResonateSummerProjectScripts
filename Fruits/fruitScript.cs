using UnityEngine;
using System.Collections;

public class fruitScript : MonoBehaviour 
{

	public AudioClip coin;

	public int scoreValue = 10;
	public GameObject popupFab;
//	GameObject reUI;
//	InGameUIRemake inGameUIRemake;
	// Use this for initialization
	void Start () 
	{
//		reUI=GameObject.Find("UIRemake");
//		inGameUIRemake=reUI.GetComponent<InGameUIRemake>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator CoinDestroy()
	{
		audio.PlayOneShot(coin);
		yield return new WaitForSeconds (audio.clip.length);
		Destroy(this.gameObject);
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == ("Player1")) 
		{
			GameObject popup = (GameObject)Instantiate(popupFab, GameObject.Find("Player1").transform.position+new Vector3(0,2,0), Quaternion.identity);
			popup.name = "popupScore";
			//inGameUIRemake.p1Popup=true;
			renderer.enabled=false;
			
			//ScoreManager.Score += scoreValue;
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();	
			sms.p1Score+=5;
		
			StartCoroutine(CoinDestroy());
			
			
		}
		if (other.gameObject.name == ("Player2")) 
		{
			GameObject popup = (GameObject)Instantiate(popupFab, GameObject.Find("Player2").transform.position+new Vector3(0,2,0), Quaternion.identity);
			popup.name = "popupScore";
			
			renderer.enabled=false;
			
			//ScoreManager.Score += scoreValue;
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();	
			sms.p2Score+=5;
			
			StartCoroutine(CoinDestroy());
			
		}
		if (other.gameObject.name == ("Player3")) 
		{
			GameObject popup = (GameObject)Instantiate(popupFab, GameObject.Find("Player3").transform.position+new Vector3(0,2,0), Quaternion.identity);
			popup.name = "popupScore";
			
			renderer.enabled=false;
			
			//ScoreManager.Score += scoreValue;
			GameObject sm = GameObject.Find ("ScoreManager");
			ScoreManager sms = sm.GetComponent<ScoreManager> ();	
			sms.p3Score+=5;
			
			StartCoroutine(CoinDestroy());
			
		}
	}
	
	

}
