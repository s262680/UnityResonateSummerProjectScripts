using UnityEngine;
using System.Collections;

public class player2RespawnScript : MonoBehaviour {
	
	public bool spawnTrigger=false;
	public GameObject[] player2Fab;
	public AudioClip dead;
	
	// Use this for initialization
	void Start () {
		SpawnPlayer2();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (spawnTrigger == true) 
		{
			audio.PlayOneShot(dead);
			
			SpawnPlayer2();
			spawnTrigger=false;
		}
	}
	
	public void SpawnPlayer2()
	{
		GameObject selectionData = GameObject.Find ("SelectionData");
		Data data = selectionData.GetComponent<Data> ();
		GameObject enemyObject = (GameObject)Instantiate(player2Fab[data.p2Select], transform.position, Quaternion.identity);
		enemyObject.name = "Player2";
		enemyObject.AddComponent<player2Script>();
	}
}