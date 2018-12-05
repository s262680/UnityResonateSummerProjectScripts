using UnityEngine;
using System.Collections;

public class IntroTrigger : MonoBehaviour {

	Animator animator;
	// Use this for initialization
	void Start () {
		animator=GetComponent<Animator>();
		animator.enabled=false;
		animator.enabled=true;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
