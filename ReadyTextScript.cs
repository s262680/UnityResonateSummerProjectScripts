using UnityEngine;
using System.Collections;

public class ReadyTextScript : MonoBehaviour {
	
	
	public float fadeRate=1f;
	public SpriteRenderer fade;
	GameObject rdySpawn;
	ReadyTextSpawnScript rtss;
	// Use this for initialization
	void Start () {
	rdySpawn=GameObject.Find("RdyTextSpawn");
	rtss=rdySpawn.GetComponent<ReadyTextSpawnScript>();
	
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine(Fading ());

	}
	
	IEnumerator Fading()
	{
		fadeRate-=Time.unscaledDeltaTime*0.8f;
		fade.color=new Color(1f, 1f, 1f, fadeRate);
		
		
		if(fadeRate<=0)
		{
			rtss.stage+=1;
			rtss.spawnTrigger=true;
			Destroy(this.gameObject);
		}
		yield return null;
	}
}
