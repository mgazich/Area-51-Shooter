using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AlienCollection : MonoBehaviour
{
	public int Aliens; //Number of Aliens Collected
	GameObject alienCollection; // Game Object to find AlienCollection
	Text text; // Text
	
    void Start()
    {
    	alienCollection = GameObject.Find("Canvas/AlienCollection"); //find AlienCollection Script
	text = alienCollection.GetComponent<Text>(); //get text component set to text
    }

    void Update()
    {
	text.text = "Aliens Collected: " + Aliens; // update text;
    }
    public void Collect(){
    	Aliens++; // Increment Alien Collected
    }
}
