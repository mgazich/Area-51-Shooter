using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAdder : MonoBehaviour
{
    public int score;

    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
		    Score s = Score.instance;
        text.text = ("Score: " + s.score);
    }
}
