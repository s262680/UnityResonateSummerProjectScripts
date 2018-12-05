using UnityEngine;
using System.Collections;

public class player1RespawnScript : MonoBehaviour {

	public bool spawnTrigger=false;
	public GameObject[] player1Fab;
	public AudioClip dead;
	// Use this for initialization
	void Start () {
	SpawnPlayer1();
	}
	
	// Update is called once per frame
	void Update () 
	{
	if (spawnTrigger == true) 
		{
			audio.PlayOneShot(dead);
			SpawnPlayer1();
			spawnTrigger=false;
		}
	}

	public void SpawnPlayer1()
	{
		GameObject selectionData = GameObject.Find ("SelectionData");
		Data data = selectionData.GetComponent<Data> ();
		GameObject enemyObject = (GameObject)Instantiate(player1Fab[data.p1Select], transform.position, Quaternion.identity);
		enemyObject.name = "Player1";
		
		enemyObject.AddComponent<player1Script>();
	}
}
