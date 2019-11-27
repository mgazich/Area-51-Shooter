using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//For comments please see DoorBehaviorRight

public class DoorBehavior : MonoBehaviour
{
	GameObject MainCamera;

    // Start is called before the first frame update
    void Start()
    {
       MainCamera = GameObject.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
    }

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name == "Player")
		{
			if(other.transform.position.x < MainCamera.transform.position.x && other.transform.position.y > MainCamera.transform.position.y-3 && other.transform.position.y < MainCamera.transform.position.y+3)
			{
				other.transform.position = new Vector3(other.transform.position.x-10, other.transform.position.y, 0);
				MainCamera.transform.Translate(-29,0,0);
			}
			else if(other.transform.position.x > MainCamera.transform.position.x && other.transform.position.y > MainCamera.transform.position.y-3 && other.transform.position.y < MainCamera.transform.position.y+3)
			{
				other.transform.position = new Vector3(other.transform.position.x+10, other.transform.position.y, 0);//Moves the player 12 units to the right
				MainCamera.transform.Translate(29,0,0);
			}
			else if(other.transform.position.y > MainCamera.transform.position.y)
			{
				other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y+10, 0);
				MainCamera.transform.Translate(0,26,0);
			}
			else if(other.transform.position.y < MainCamera.transform.position.y)
			{
				other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y-10, 0);
				MainCamera.transform.Translate(0,-26,0);
			}
		}

	}
}
