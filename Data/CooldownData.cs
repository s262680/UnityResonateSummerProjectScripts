using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CooldownData : MonoBehaviour {
	public float speedUpCooldown=0;
	public float abilityObjectCooldown=0;
	public float cannonCooldown1=0;
	public float cannonCooldown2=0;
	public float cannonCooldown3=0;
	public float player1Cooldown=0;
	public float player2Cooldown=0;
	public float player3Cooldown=0;
	public float rainCooldown=0;

	public GUISkin TextUI;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (speedUpCooldown > 0) 
		{
			speedUpCooldown-=Time.deltaTime;
			
		}
		
		if (abilityObjectCooldown>0)
		{
			abilityObjectCooldown-=Time.deltaTime;
			
		}
		
		
		if (cannonCooldown1 > 0) 
		{
			cannonCooldown1-=Time.deltaTime;
			
		}
		
		if (cannonCooldown2 > 0) 
		{
			cannonCooldown2-=Time.deltaTime;
			
		}
		
		if (cannonCooldown3 > 0) 
		{
			cannonCooldown3-=Time.deltaTime;
			
		}
		
		if(player1Cooldown>0)
		{
			player1Cooldown-=Time.deltaTime;
		}
		
		if(player2Cooldown>0)
		{
			player2Cooldown-=Time.deltaTime;
		}
		
		if(player3Cooldown>0)
		{
			player3Cooldown-=Time.deltaTime;
		}
		
		if(rainCooldown>0)
		{
			rainCooldown-=Time.deltaTime;
		}
	}

	void OnGUI()
	{		
		if (cannonCooldown1 > 0) 
			{
			GUI.skin = TextUI;
			GUI.Label (new Rect (Screen.width/1.16f, Screen.height/4.6f, 100, 40), "" + cannonCooldown1.ToString("F0"));
				//GUI.Box(new Rect (Screen.width-140, Screen.height/2-110, 100, 25)," ");
			}

		if (cannonCooldown2 > 0) 
		{
			GUI.skin = TextUI;
			GUI.Label (new Rect (Screen.width/1.142f, Screen.height/4.6f, 100, 40), "" + cannonCooldown2.ToString("F0"));
			//GUI.Box(new Rect (Screen.width-140, Screen.height/2-110, 100, 25)," ");
		}

		if (cannonCooldown3 > 0) 
		{
			GUI.skin = TextUI;
			GUI.Label (new Rect (Screen.width/1.125f, Screen.height/4.6f, 100, 40), "" + cannonCooldown3.ToString("F0"));
			//GUI.Box(new Rect (Screen.width-140, Screen.height/2-110, 100, 25)," ");
		}

		if (abilityObjectCooldown > 0) 
		{
			GUI.skin = TextUI;
			GUI.Label (new Rect (Screen.width/1.165f, Screen.height/6.2f, 100, 40), "" + abilityObjectCooldown.ToString("F0"));
		
		}

		if (speedUpCooldown > 0) 
		{
			GUI.skin = TextUI;
			GUI.Label (new Rect (Screen.width/1.173f, Screen.height/8.5f, 100, 40), "" + speedUpCooldown.ToString("F0"));
			
		} 
		if (rainCooldown > 0) 
		{
			GUI.skin = TextUI;
			GUI.Label (new Rect (Screen.width/1.08f, Screen.height/4f, 100, 40), "" + rainCooldown.ToString("F0"));
			
		}
		if(player1Cooldown>0)
		{
			GUI.skin = TextUI;
			GUI.Label (new Rect (Screen.width / 7.5f, Screen.height / 11, 100, 60), "" + player1Cooldown.ToString("F0"));
		}
		
		if(player2Cooldown>0)
		{
			GUI.skin = TextUI;
			GUI.Label (new Rect (Screen.width / 3.41f, Screen.height / 11, 100, 60), "" + player2Cooldown.ToString("F0"));
		}
		
		if(player3Cooldown>0)
		{
			GUI.skin = TextUI;
			GUI.Label (new Rect (Screen.width / 2.14f, Screen.height / 11, 100, 60), "" + player3Cooldown.ToString("F0"));
		}
	}
}