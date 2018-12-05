using UnityEngine;
using System.Collections;

public class objectsKillBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "enemyObject") 
		{

			Destroy(other.gameObject);
		}
		
		if (other.gameObject.tag == "abilityObject") 
		{
			
			Destroy(other.gameObject);
		}

	}
}
