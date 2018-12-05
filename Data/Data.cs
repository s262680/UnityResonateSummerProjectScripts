using UnityEngine;
using System.Collections;

public class Data : MonoBehaviour 
{
	public int p1Select;
	public int p2Select;
	public int p3Select;
	public int p4Select;
	public int level=0;
	public int winnerTrigger;

	// Use this for initialization
	void Start () 
	{
		DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
