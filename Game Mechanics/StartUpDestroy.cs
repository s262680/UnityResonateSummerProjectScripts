using UnityEngine;
using System.Collections;

public class StartUpDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject[] deads = GameObject.FindGameObjectsWithTag("deads");
		foreach(GameObject d in deads)
		{
		  GameObject.Destroy(d);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
