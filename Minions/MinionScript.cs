using UnityEngine;
using System.Collections;

public class MinionScript : MonoBehaviour {
	public float movementRate;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * movementRate * Time.deltaTime);
	}
}
