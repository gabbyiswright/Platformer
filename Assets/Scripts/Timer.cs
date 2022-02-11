using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIimer : MonoBehaviour
{
	public Text TimerText;
	public bool playing;
	private float Timer;

	void Start()
	{

		GetComponent<TextMesh>().text = Timer.ToString();
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

	}

}