using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAdder : MonoBehaviour
{
    public static float score;

    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ("Score: " + score);
    }
}
