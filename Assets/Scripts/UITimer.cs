using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITimer : Combat
{
	public Text TimerText;
	private bool playing;
	private float Timer;
	public static bool IsAlive;

	void Start()
	{
		IsAlive = true;
        GetComponent<Text>().text = Timer.ToString();
		if (TimerText != null)
		{
			playing = true;
		}
		else
		{
			playing = false;
		}
	}

	void Update()
	{

		if (playing == true)
		{

			Timer += Time.deltaTime;
			int minutes = Mathf.FloorToInt(Timer / 60F);
			int seconds = Mathf.FloorToInt(Timer % 60F);
			int milliseconds = Mathf.FloorToInt((Timer * 100F) % 100F);
			TimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
		}
		if (IsAlive == false)
        {
			GameManager.FinalTime = Timer;
			playing = false;
		}
	}
	
}