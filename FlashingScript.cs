using UnityEngine;
using System.Collections;

public class FlashingScript : MonoBehaviour {
	public SpriteRenderer area;
	float rate=1f;
	bool trigger=true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(rate>=1)
	{
	trigger=true;
	}
	if(rate<=0)
	{
	trigger=false;
	}
	if(trigger)
	{
	rate-=Time.deltaTime;
	}
	if(!trigger)
	{
	rate+=Time.deltaTime;
	}
	area.color = new Color (1f, 1f, 1f, rate);	}
}
