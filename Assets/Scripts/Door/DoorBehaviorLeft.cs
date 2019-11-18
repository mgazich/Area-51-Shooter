using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//For comments please see DoorBehaviorRight

public class DoorBehaviorLeft : MonoBehaviour
{
	GameObject MainCamera;
	public bool locked = false;
	public Sprite lockedSprite;
	public Sprite openSprite;

    // Start is called before the first frame update
    void Start()
    {
       MainCamera = GameObject.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
			if(locked)
			{
				this.GetComponent<SpriteRenderer>().sprite = lockedSprite;
			}
			else
			{
				this.GetComponent<SpriteRenderer>().sprite = openSprite;
			}
    }

	void OnTriggerEnter2D(Collider2D other)
	{

		if(other.gameObject.name == "Player" && !locked)
		{

				other.transform.position = new Vector3(other.transform.position.x-12, other.transform.position.y, 0);
				MainCamera.transform.Translate(-29,0,0);
		}

	}
}
