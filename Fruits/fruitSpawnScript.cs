using UnityEngine;
using System.Collections;

public class fruitSpawnScript : MonoBehaviour {

	public GameObject[] fruitFab;
	float delay;
	
	// Use this for initialization
	void Start () {
		delay = Random.Range(1.0f, 5.0f);
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		
		if (delay <= 0) 
		{
			SpawnFruits ();
			delay = Random.Range (2.0f, 6.0f);
		} 
		else 
		{
			delay -= Time.deltaTime;
		}
		
	}
	
	public void SpawnFruits()
	{
		GameObject coinObject = (GameObject)Instantiate(fruitFab[Random.Range (0,5)],new Vector3(Random.Range(-42,42),Random.Range(-24,13),-1), Quaternion.identity);
		coinObject.name = "fruit";
	}
}