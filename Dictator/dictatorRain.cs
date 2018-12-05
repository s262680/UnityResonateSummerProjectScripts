using UnityEngine;
using System.Collections;

public class dictatorRain : MonoBehaviour {
float timer=1f;
float speed=15f;
public GameObject holeFab;
public GameObject hitEffectFab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	timer-=Time.deltaTime;
		if(timer>0)
		{
			transform.Translate(Vector3.down*Time.deltaTime*speed);
		}
		else if(timer<0)
		{
				GameObject enemyObject = (GameObject)Instantiate(holeFab,transform.position, Quaternion.identity);
				enemyObject.name = "hole";
				GameObject effectObject = (GameObject)Instantiate(hitEffectFab,transform.position, Quaternion.identity);
				effectObject.name = "hitEffect";
				Destroy(this.gameObject);
		}
	}
}
