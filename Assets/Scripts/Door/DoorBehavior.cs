using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
//For comments please see DoorBehaviorRight

public class DoorBehavior : MonoBehaviour
{
    GameObject MainCamera;
    GridMap grid;
    Roomsetup RoomMap;
    EnemyPooler enemyPooler;
    public Tile Door, Locked, DoubleDoor, Lockeddouble;
    Tilemap doors;
    bool locked;

    // Start is called before the first frame update
    void Start()
    {
      locked = false;
      doors = gameObject.GetComponent<Tilemap>();
      MainCamera = GameObject.Find("Camera");
      grid = MainCamera.GetComponent<GridMap>();
      RoomMap = GameObject.Find("Camera").GetComponent<Roomsetup>();
      enemyPooler = GameObject.Find("EnemyPooler").GetComponent<EnemyPooler>();
    }

    // Update is called once per frame
    void Update()
    {
      for(int i = 0; i < enemyPooler.amountToPool;i++)
      {
        if(enemyPooler.pooledEnemys[i].GetComponent<Enemy>().alive)
        {
          locked = true;
          break;
        }
        else if(i == enemyPooler.amountToPool - 1 )
        {
          locked = false;
        }
      }
      if(locked)
      {
        doors.SwapTile(Door, Locked);
        doors.SwapTile(DoubleDoor, Lockeddouble);
      }
      else
      {
        doors.SwapTile(Locked, Door);
        doors.SwapTile(Lockeddouble, DoubleDoor);
      }
    }

	void OnTriggerEnter2D(Collider2D other)
	{

    if(!locked)
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
}
