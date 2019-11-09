using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//For comments please see DoorBehaviorRight

public class DoorBehaviorUp : MonoBehaviour
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
				other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y+12, 0);
				MainCamera.transform.Translate(0,26,0);
		}

	}
}
