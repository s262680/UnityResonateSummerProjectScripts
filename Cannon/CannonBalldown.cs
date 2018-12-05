using UnityEngine;
using System.Collections;

public class CannonBalldown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
	{
		transform.Translate(Vector3.left*30*Time.deltaTime);
		transform.Translate(Vector3.down*10*Time.deltaTime);
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == ("Player")) 
		{
	
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag == ("minions")) 
		{
			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}
		if (other.gameObject.tag == ("fadeBorder")) 
		{
			
			Destroy (this.gameObject);
		}
	}
}