using UnityEngine;
using System.Collections;

public class section3ObjectsSpawnScript : MonoBehaviour {

	public GameObject section3ObjectsFab;
	float delay;
	
	// Use this for initialization
	void Start () {
		delay = Random.Range(1.0f, 3.0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
			if (delay <= 0) {
				SpawnEnemyObjects ();
				delay = Random.Range (1.0f, 3.0f);
			} else {
				delay -= Time.deltaTime;
			}
		
	}
	public void SpawnEnemyObjects()
	{
		GameObject enemyObject = (GameObject)Instantiate(section3ObjectsFab, transform.position, Quaternion.identity);
		enemyObject.name = "Enemy Object";
	}
}