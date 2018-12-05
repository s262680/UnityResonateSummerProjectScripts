using UnityEngine;
using System.Collections;

public class DictatorSpawnScript : MonoBehaviour {
	public GameObject[] dictatorFabs;
	public GameObject[] dictatorBg;
	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void Spawn()
	{
		GameObject selectionData = GameObject.Find ("SelectionData");
		Data data = selectionData.GetComponent<Data> ();
		GameObject enemyObject = (GameObject)Instantiate(dictatorFabs[data.p4Select], transform.position, Quaternion.identity);
		enemyObject.name = "dictator";
		GameObject enemyObjectBg = (GameObject)Instantiate(dictatorBg[data.p4Select], transform.position-new Vector3(2.15f,0,0), Quaternion.identity);
		enemyObjectBg.name = "dictatorBg";
	}
}
