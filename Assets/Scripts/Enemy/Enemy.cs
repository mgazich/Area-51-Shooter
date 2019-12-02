using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    GameObject scoreSprite;
    ScoreAdder scoreAdder;
	Score s = Score.instance;
    // Update is called once per frame
    private void Start()
    {
        scoreSprite = GameObject.Find("Canvas/Score");
        scoreAdder = scoreSprite.GetComponent<ScoreAdder>();
    }
    void Update()
    {
        
    }

   public void Damage(float amount)
    {
        health -= amount;

        if(health <= 0)
        {
            s.score += 10;
            gameObject.SetActive(false);
        }
    }
}
