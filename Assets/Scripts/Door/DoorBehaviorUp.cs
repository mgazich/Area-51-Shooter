using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//For comments please see DoorBehaviorRight

public class DoorBehaviorUp : MonoBehaviour
{
	GameObject MainCamera;
	public bool locked = false;
	public Sprite lockedSprite;
	public Sprite openSprite;
	public Vector3 EnemySpawn;
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
				other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y+12, 0);
				MainCamera.transform.Translate(0,26,0);
		}
		GameObject Enemy = EnemyPooler.SharedInstance.GetPooledEnemy();
		if(Enemy != null){
		       		Enemy.transform.position = EnemySpawn;
		       		Enemy.SetActive(true);
      		}

	}
}
