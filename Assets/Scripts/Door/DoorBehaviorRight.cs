using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorBehaviorRight : MonoBehaviour
{
	GameObject MainCamera;
	
    // Start is called before the first frame update
    void Start()
    {
       MainCamera = GameObject.Find("Camera");//Gets Camera Object from scene
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter2D(Collider2D other)//When object that the script is on is collided with
	{
	
		if(other.gameObject.name == "Player")//Activate only for player collision
		{
				other.transform.position = new Vector3(other.transform.position.x+12, other.transform.position.y, 0);//Moves the player 12 units to the right
				MainCamera.transform.Translate(29,0,0);//Moves camera 29 units to the right
		}
	
	}
}
