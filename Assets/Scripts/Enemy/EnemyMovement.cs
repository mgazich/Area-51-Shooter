using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 playerPos;
    public Vector3 enemyPos;
    public float enemySpeed = 3.0f; //Adjust float as needed. Higher numbers = faster
    public bool damaged = false;
    public float stunTime = 0.10f;
    public Sprite damagedSprite, normalSprite;
    Enemy enemy;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemy = gameObject.GetComponent<Enemy>();
        StartCoroutine(movement());
    }

    IEnumerator movement()
    {
        enemy.alive = true;

        if (damaged)
        {
            GetComponent<SpriteRenderer>().sprite = damagedSprite;
            yield return new WaitForSeconds(stunTime);
            damaged = false;
            GetComponent<SpriteRenderer>().sprite = normalSprite;
        }
        else
        {
            playerPos = GameObject.Find("Player").transform.position;
            enemyPos = this.transform.position;
            this.transform.position = Vector3.MoveTowards(enemyPos, playerPos, (enemySpeed * Time.deltaTime));
        }
    }
}
