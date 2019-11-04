using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAlien: MonoBehaviour
{
    GameObject AlienSprite; // used to find AlienCollection
    AlienCollection alienCollection; // used to get AlienCollection
    // Start is called before the first frame update
    void Start()
    {
    	
        AlienSprite = GameObject.Find("Canvas/AlienCollection"); // Find AlienCollection
        alienCollection = AlienSprite.GetComponent<AlienCollection>(); // Set alienCollection to the found gameObject
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D other){
     	if(other.gameObject.name == "Player"){ // Only Player
     		alienCollection.Collect(); // Incriment Alien
     		Destroy(gameObject); // Remove current Object 
     	}
     }
    
}
