using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//For comments please see DoorBehaviorRight

public class DoorBehaviorUp : MonoBehaviour
{
	GameObject MainCamera;
	GameObject scoreSprite;
	ScoreAdder scoreAdder;
    // Start is called before the first frame update
    void Start()
    {
       MainCamera = GameObject.Find("Camera");
			 scoreSprite = GameObject.Find("Canvas/Score");
			 scoreAdder = scoreSprite.GetComponent<ScoreAdder>();
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
				scoreAdder.score += 20;//TEMPORARY to test score
		}

	}
}
