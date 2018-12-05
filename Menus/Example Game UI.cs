using UnityEngine;
using System.Collections;

public class ExampleGameUI : MonoBehaviour 
{
	public GUISkin customSkin;
	public GUISkin PlaySkin;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		GameObject cooldownDataObject = GameObject.Find ("CooldownDataObject");
		CooldownData cdData = cooldownDataObject.GetComponent<CooldownData> ();
		
		//only display the CD when cooldown start counting
		if(cdData.player1Cooldown>0)
		{
			GUI.skin=customSkin;
		GUI.Label(new Rect(100,90,200,200),"CD: "+cdData.player1Cooldown.ToString("F0"));
			GUI.skin=null;
		}
		
		if(cdData.player2Cooldown>0)
		{
			GUI.skin=customSkin;
		GUI.Box(new Rect(Screen.width/2-100,90,100,20),"CD: "+cdData.player2Cooldown.ToString("F0"));
			GUI.skin=null;
		}
		
		//other ui such as score and avator should place here 
	}
}
