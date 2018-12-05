using UnityEngine;
using System.Collections;

public class SkullPopupScript : MonoBehaviour {
	public SpriteRenderer skull;
	float rate=1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rate-=Time.deltaTime*0.5f;
		skull.color = new Color (1f, 1f, 1f, rate);
		transform.Translate(Vector3.up * 1.0f *Time.deltaTime);
		
		if(rate<=0)
		{
		Destroy(this.gameObject);
		}
	}
}
