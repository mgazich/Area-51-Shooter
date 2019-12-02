using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    float maxHealth;
    GameObject scoreSprite;
    ScoreAdder scoreAdder;
    public bool alive;
	  Score s = Score.instance;
    // Update is called once per frame
    private void Start()
    {
        scoreSprite = GameObject.Find("Canvas/Score");
        scoreAdder = scoreSprite.GetComponent<ScoreAdder>();
        maxHealth = health;
        alive = false;
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
            alive = false;
            gameObject.SetActive(false);
            health = maxHealth;
        }
    }
}
