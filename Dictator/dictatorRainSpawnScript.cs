using UnityEngine;
using System.Collections;

public class dictatorRainSpawnScript : MonoBehaviour {
public GameObject rainFab;
//public float delay=0.1f;
bool rainSpawnTrigger=false;
int i;
public AudioClip blizzard;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject cooldownDataObject = GameObject.Find("CooldownDataObject");
		CooldownData cdData=cooldownDataObject.GetComponent<CooldownData>();
		
//		if (Input.GetKeyDown("[0]")&&cdData.rainCooldown<=0||(Input.GetButtonDown("Y4")&cdData.rainCooldown<=0))
		if (Input.GetKeyDown("[0]")&&cdData.rainCooldown<=0||(Input.GetButtonDown("B4")&cdData.rainCooldown<=0))
		{
			rainSpawnTrigger=true;
		}
		
		if(rainSpawnTrigger==true)
		{
			audio.Play();
			StartCoroutine(Rain ());
			
			rainSpawnTrigger=false;
			cdData.rainCooldown=30f;
			
		}
		
		
		
		
	}
	
	IEnumerator Rain()
	{
		
		for(int i=0;i<15;i++)
		{
		SpawnRain();
			yield return new WaitForSeconds(0.3f);
	

		}
		yield return new WaitForSeconds(1.5f);
		audio.Stop();
	
		
	}
	
	public void SpawnRain()
	{
		GameObject enemyObject = (GameObject)Instantiate(rainFab,new Vector3(Random.Range(-42,42),Random.Range(-6,26),-1), Quaternion.identity);
		enemyObject.name = "rain";
	}
}
