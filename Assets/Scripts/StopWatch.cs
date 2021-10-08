using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StopWatch : MonoBehaviour
{

	public Text StopWatchText;
	private float StartTime;


	void Start()
	{
		StartTime = Time.time;

	}


	void Update()
	{
		float t = Time.time - StartTime;

		string min = ((int)t / 60).ToString();
		string sec = (t % 60).ToString();

		StopWatchText.text = min + ":" + sec;
	}
}
