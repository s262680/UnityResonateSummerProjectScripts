using UnityEngine;
using System.Collections;

public class ReadyTextSpawnScript : MonoBehaviour {
	
	
	public GameObject[] rdyText;

	//bool timeTrigger=false;
	public int stage;
	public bool spawnTrigger=true;
	GameObject remadeUI;
	InGameUIRemake uir;
	// Use this for initialization
	void Start () {
	
		remadeUI = GameObject.Find ("UIRemake");
		uir = remadeUI.GetComponent<InGameUIRemake> ();
		uir.timeTrigger=true;
	}
	
	// Update is called once per frame
	void Update () {

		StartCoroutine(SpawnStage());
		

	}
	
	IEnumerator SpawnStage()
	{
		if(!GameObject.Find("Instruction"))
		{
			if(stage==0&spawnTrigger)
			{
				Spawn3();
				spawnTrigger=false;
			}
			if(stage==1&spawnTrigger)
			{
				Spawn2();
				spawnTrigger=false;
			}
			if(stage==2&spawnTrigger)
			{
				Spawn1();
				spawnTrigger=false;
				
			}
			if(stage==3&spawnTrigger)
			{
				SpawnStart();
				spawnTrigger=false;
				
			}
			if(stage==4&spawnTrigger)
			{
				spawnTrigger=false;
				uir.timeTrigger=false;
				Destroy(this.gameObject);
			}
		}
		yield return null;
	}
	
	public void Spawn3()
	{
		GameObject thirdObject = (GameObject)Instantiate(rdyText[0], transform.position, Quaternion.identity);
		thirdObject.name = "3text";
	}
	public void Spawn2()
	{
		GameObject secObject = (GameObject)Instantiate(rdyText[1], transform.position, Quaternion.identity);
		secObject.name = "2text";
	}
	public void Spawn1()
	{
		GameObject firstObject = (GameObject)Instantiate(rdyText[2], transform.position, Quaternion.identity);
		firstObject.name = "1text";
	}
	public void SpawnStart()
	{
		GameObject startObject = (GameObject)Instantiate(rdyText[3], transform.position, Quaternion.identity);
		startObject.name = "startText";
	}
}
