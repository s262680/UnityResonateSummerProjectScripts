using UnityEngine;
using System.Collections;

public class MinionSpawnScript : MonoBehaviour {
	public GameObject[] minionFab;
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
				SpawnMinions ();
				delay = Random.Range (5.0f, 10.0f);
			} 
			else 
			{
				delay -= Time.deltaTime;
			}

	}
	
	public void SpawnMinions()
	{
		GameObject enemyObject = (GameObject)Instantiate(minionFab[Random.Range (0,5)], new Vector3(transform.position.x,transform.position.y+Random.Range(-2,2),transform.position.z), Quaternion.identity);
		enemyObject.name = "minion";
	}
}