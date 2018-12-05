using UnityEngine;
using System.Collections;

public class ScorePopupScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	transform.Translate(Vector3.up * 1.0f *Time.deltaTime);
	Destroy(this.gameObject,2.0f);
	}
}
