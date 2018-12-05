using UnityEngine;
using System.Collections;

public class player3RespawnScript : MonoBehaviour {
	
	public bool spawnTrigger=false;
	public GameObject[] player3Fab;
	public AudioClip dead;
	
	// Use this for initialization
	void Start () {
		SpawnPlayer3();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (spawnTrigger == true) 
		{
			audio.PlayOneShot(dead);
			
			SpawnPlayer3();
			spawnTrigger=false;
		}
	}
	
	public void SpawnPlayer3()
	{
		GameObject selectionData = GameObject.Find ("SelectionData");
		Data data = selectionData.GetComponent<Data> ();
		GameObject enemyObject = (GameObject)Instantiate(player3Fab[data.p3Select], transform.position, Quaternion.identity);
		enemyObject.name = "Player3";
		enemyObject.AddComponent<player3Script>();
	}
}