using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//For comments please see DoorBehaviorRight

public class DoorBehavior : MonoBehaviour
{
    GameObject MainCamera;
    GridMap grid;	
    Roomsetup RoomMap;
    // Start is called before the first frame update
    void Start()
    {
       MainCamera = GameObject.Find("Camera");
       grid = MainCamera.GetComponent<GridMap>();
       RoomMap = GameObject.Find("Camera").GetComponent<Roomsetup>();
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
				grid.x--;
				other.transform.position = new Vector3(other.transform.position.x-10, other.transform.position.y, 0);
				MainCamera.transform.Translate(-29,0,0);
			}
			else if(other.transform.position.x > MainCamera.transform.position.x && other.transform.position.y > MainCamera.transform.position.y-3 && other.transform.position.y < MainCamera.transform.position.y+3)
			{
				grid.x++;
				other.transform.position = new Vector3(other.transform.position.x+10, other.transform.position.y, 0);//Moves the player 12 units to the right
				MainCamera.transform.Translate(29,0,0);
			}
			else if(other.transform.position.y > MainCamera.transform.position.y)
			{
				grid.y++;
				other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y+10, 0);
				MainCamera.transform.Translate(0,26,0);
			}
			else if(other.transform.position.y < MainCamera.transform.position.y)
			{
				grid.y--;
				other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y-10, 0);
				MainCamera.transform.Translate(0,-26,0);
			}
			GameObject Enemy = EnemyPooler.SharedInstance.GetPooledEnemy();
			if(Enemy != null){
				RoomMap.spawnBasedOf(grid.x,grid.y);
      			}
		}

	}
}
