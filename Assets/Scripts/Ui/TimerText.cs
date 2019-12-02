using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerText : MonoBehaviour
{
	public float minutes; //Allows minutes and seconds to be changed by outside code
	public float seconds;

	Text text; //Start a text object called text

    void Start()
    {
		text = GetComponent<Text>();//Gets Text component from Timer object in scene
		minutes = 0;
		seconds = 59;//Initialize amount of time
    }

	void awake()
	{

	}

    void Update()
    {
		if(seconds > 60)
		{
			minutes += 1;
			seconds -= 60;
		}
		seconds -= Time.deltaTime;//Counts seconds down in framerate
		string s = seconds.ToString("00");//Converts seconds from long float to 2 digit seconds(EG 44.54643 to 44)
		if(s.Equals("-01"))//Checks if seconds is past 0, changes minutes down one and puts seconds back to 59
		{
			minutes -= 1;
			seconds = 59;
			s = seconds.ToString("00");
		}
		text.text = ("Timer: " + minutes + ":" + s);//Print the current time to the text box in Text
		if(s.Equals("00") && minutes == (0))//Checks if Time is 0, if so, game over scene is played
		{
			SceneManager.LoadScene("GameOver");
		}
    }
}
