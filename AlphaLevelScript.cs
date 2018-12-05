using UnityEngine;
using System.Collections;

public class AlphaLevelScript : MonoBehaviour {
	public SpriteRenderer cover;
//	public SpriteRenderer lamp2;
//	public SpriteRenderer tree1;
//	public SpriteRenderer tree2;

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		cover.color = new Color (1f, 1f, 1f, 0.7f);
//		lamp2.color = new Color (1f, 1f, 1f, 0.5f);
//		tree1.color = new Color (1f, 1f, 1f, 0.5f);
//		tree2.color = new Color (1f, 1f, 1f, 0.5f);
		
	}
}
