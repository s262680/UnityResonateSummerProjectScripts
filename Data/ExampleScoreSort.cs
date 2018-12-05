//using UnityEngine;
//using System.Collections;
//using UnityEngine.UI;
//using System.Collections.Generic;
//
//public class ExampleScoreSort : MonoBehaviour 
//{
//	List<ScoreManager> ScoreList;
//
//	// Use this for initialization
//	void Start () 
//	{
//	
//	}
//	
//	// Update is called once per frame
//	void Update () 
//	{
//	
//	}
//
//	List<ScoreManager> QuickSort(List<ScoreManager>
//	                                    listIn)
//	{
//		if (listIn.Count <= 1)
//		{
//			return listIn;
//		}
//		// Naive pivot selection
//		int pivotIndex = 0;
//		// Left and right lists
//		List<ScoreManager> leftList =
//			new List<ScoreManager>();List<ScoreManager> rightList =
//			new List<ScoreManager>();
//		for (int i = 1; i < listIn.Count; i++ )
//		{
//			// Compare amounts to determine list to add to
//			if (listIn[i] > listIn[pivotIndex])
//			{
//				// Greater than pivot to left list
//				leftList.Add(listIn[i]);
//			}
//			else
//			{
//				// Smaller than pivot to right list
//				rightList.Add(listIn[i]);
//			}
//		}
//		
//		// Recurse left list
//		leftList = QuickSort(leftList);
//		//Recurse right list
//		rightList = QuickSort(rightList);
//		// Concatenate lists: left + pivot + right
//		leftList.Add(listIn[pivotIndex]);
//		leftList.AddRange(rightList);
//		return leftList;
//	}
//	
//	public void StartQuickSort()
//	{
//		ScoreList = QuickSort(ScoreList);
//	}
//}
