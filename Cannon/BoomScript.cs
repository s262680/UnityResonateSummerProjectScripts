using UnityEngine;
using System.Collections;

public class BoomScript : MonoBehaviour {
float delay=0.6f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	delay-=Time.deltaTime;
	if(delay<0)
	{
		Destroy(this.gameObject);
	}
	}
}
