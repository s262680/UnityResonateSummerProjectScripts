using UnityEngine;
using System.Collections;

public class section1ObjectsSpawnScript : MonoBehaviour {
	public GameObject section1ObjectsFab;
	float delay;
	
	// Use this for initialization
	void Start () {
		delay = Random.Range(1.0f, 3.0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if (!Gmanager.Instance.Paused) {
		
			if (delay <= 0) {
				SpawnEnemyObjects ();
				delay = Random.Range (1.0f, 3.0f);
			} else {
				delay -= Time.deltaTime;
			}
		//}
	}
	
	public void SpawnEnemyObjects()
	{
		GameObject enemyObject = (GameObject)Instantiate(section1ObjectsFab, transform.position, Quaternion.identity);
		enemyObject.name = "Enemy Object";
	}
}