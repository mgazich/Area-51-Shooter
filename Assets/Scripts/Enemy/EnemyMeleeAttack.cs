// This make the monster's melee attack appear disappear
// The mechanics is made with a range or circle
// distance to the monster
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeleeAttack : MonoBehaviour
{

    public GameObject attack; //for image
    public GameObject player; //player
    public float attackRange; //changeable range
    private float attackRate = .75f;
    public float nextAttack = 0f;
    // Start is called before the first frame update
    void Start()
    {
	player = GameObject.Find("Player"); //find player
	attack = GameObject.Find("MeleeAttack"); //find this
	attackRange = 2; //range intitally 2
	attack.SetActive(false); // disappear
    }

    // Update is called once per frame
    void Update()
    {
    	//if distance < range
	if(Vector2.Distance(transform.position, player.transform.position) < attackRange && Time.time > nextAttack)
  {
    nextAttack = Time.time + attackRate;
		attack.SetActive(true); //appear
	}
  else
  {
    
		attack.SetActive(false); //disappear
	}
    }
}
