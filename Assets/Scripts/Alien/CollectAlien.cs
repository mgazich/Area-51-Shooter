using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAlien: MonoBehaviour
{
    GameObject AlienSprite; // used to find AlienCollection
    AlienCollection alienCollection; // used to get AlienCollection
    GameObject scoreSprite;
    ScoreAdder scoreAdder;
    GameObject timer;
    TimerText timerText;
    public int alienScore = 50;
    public int timerScore = 20;
	Score s = Score.instance;
    // Start is called before the first frame update
    void Start()
    {
        AlienSprite = GameObject.Find("Canvas/AlienCollection"); // Find AlienCollection
        alienCollection = AlienSprite.GetComponent<AlienCollection>(); // Set alienCollection to the found gameObject
        scoreSprite = GameObject.Find("Canvas/Score");
        scoreAdder = scoreSprite.GetComponent<ScoreAdder>();
        timer = GameObject.Find("Canvas/Timer");
        timerText = timer.GetComponent<TimerText>();
    }

    // Update is called once per frame
    void Update()
    {

    }
     void OnTriggerEnter2D(Collider2D other){
     	if(other.gameObject.name == "Player"){ // Only Player
     		alienCollection.Collect(); // Increment Alien
            s.score += alienScore;
            timerText.seconds += timerScore;
     		Destroy(gameObject); // Remove current Object
     	}
     }

}
