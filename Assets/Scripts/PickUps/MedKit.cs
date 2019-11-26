using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedKit : MonoBehaviour
{
    GameObject player;
    PlayerHealth playerHealth;
    public float healAmount;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            playerHealth.HealDamage(healAmount);
            Destroy(gameObject); // Remove current Object
        }
    }
}
