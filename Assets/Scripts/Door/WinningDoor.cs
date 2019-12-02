using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningDoor : MonoBehaviour
{
    Score s;
    GameObject timer;
    TimerText timerText;
    // Start is called before the first frame update
    void Start()
    {
      timer = GameObject.Find("Canvas/Timer");
      timerText = timer.GetComponent<TimerText>();
      s = Score.instance;
    }

    // Update is called once per frame
    void Update()
    {

    }

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name == "Player")
		{
      s.score += (int)(timerText.seconds*5 + (timerText.minutes*60)*5);
			SceneManager.LoadScene("EscapeScreen");
		}

	}
}
