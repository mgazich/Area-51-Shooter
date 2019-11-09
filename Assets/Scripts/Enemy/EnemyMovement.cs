using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 playerPos;
    public Vector3 enemyPos;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerPos = GameObject.Find("Player").transform.position;
        enemyPos = this.transform.position;
        this.transform.position = Vector3.MoveTowards(enemyPos, playerPos, 0.02f); //Adjust float as needed. Higher numbers = faster
    }
}
