using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roomsetup : MonoBehaviour
{
	// KEY:
	// 1 = spawn 4 corners
	// 2 = spawn 3 center
	// 3 = spawn + map 3 entrance
	// 4 = coordor down the line
	// x = NULL
	// B = Broken
	//
	// 5| x x x x x x
	// 4| x 1 1 1 x x 1
	// 3| x 1 2 4 B x 2
	// 2| x 2 3 4 3 4 2
	// 1| 1 1 x 1 x s 1 1
	// 0| x 2 1 1 1 s x
	// y ___________________
	//  x 0 1 2 3 4 5 6 7
	//
	//
	GameObject MainCamera;
	public int[,] SpawnGrid;
	public GameObject Enemy1;
	public GameObject Enemy2;
	public GameObject Enemy3;
	public GameObject Enemy4;
	void Start()
	{
	MainCamera = GameObject.Find("Camera");
     		SpawnGrid = new int[8,6];
		SpawnGrid[0,1] = SpawnGrid[1,1] = SpawnGrid[1,3] = SpawnGrid[1,4] = SpawnGrid[2,0] = SpawnGrid[2,4] = SpawnGrid[3,0] = SpawnGrid[3,4] = SpawnGrid[4,0] = SpawnGrid[6,1] = SpawnGrid[6,4] =  SpawnGrid[7,1] = SpawnGrid[3,1] = 1;
		SpawnGrid[1,2] = SpawnGrid[1,0] = SpawnGrid[2,3] = SpawnGrid[6,2] = SpawnGrid[6,3] = SpawnGrid[5,0] = SpawnGrid[5,1] =2;
		SpawnGrid[2,2] = SpawnGrid[4,2] = 3;
		SpawnGrid[3,2] = SpawnGrid[3,3] = SpawnGrid[5,2] = 4;
     	}


	public void spawnBasedOf(int x,int y){
		//Basic Square Room
		int range = 8;
		if(SpawnGrid[x,y] == 1){
			Enemy1 = EnemyPooler.SharedInstance.GetPooledEnemy();
			if(Enemy1 != null){
				Enemy1.SetActive(true);
				Enemy1.transform.position = new Vector3(MainCamera.transform.position.x + range,MainCamera.transform.position.y + range,0);
			}
			Enemy2 = EnemyPooler.SharedInstance.GetPooledEnemy();
			if(Enemy2 != null){
				Enemy2.SetActive(true);
				Enemy2.transform.position = new Vector3(MainCamera.transform.position.x + range,MainCamera.transform.position.y - range,0);
			}
			Enemy3 = EnemyPooler.SharedInstance.GetPooledEnemy();
			if(Enemy3 != null){
				Enemy3.SetActive(true);
				Enemy3.transform.position = new Vector3(MainCamera.transform.position.x - range,MainCamera.transform.position.y + range,0);
			}
			Enemy4 = EnemyPooler.SharedInstance.GetPooledEnemy();
			if(Enemy4 != null){
				Enemy4.SetActive(true);
				Enemy4.transform.position = new Vector3(MainCamera.transform.position.x - range,MainCamera.transform.position.y - range,0);
			}
			SpawnGrid[x,y] = -1;
		}
		if(SpawnGrid[x,y] == 2){
			range = 2;
			Enemy1 = EnemyPooler.SharedInstance.GetPooledEnemy();
			if(Enemy1 != null){
				Enemy1.SetActive(true);
				Enemy1.transform.position = new Vector3(MainCamera.transform.position.x + range,MainCamera.transform.position.y + range,0);
			}
			Enemy2 = EnemyPooler.SharedInstance.GetPooledEnemy();
			if(Enemy2 != null){
				Enemy2.SetActive(true);
				Enemy2.transform.position = new Vector3(MainCamera.transform.position.x + range,MainCamera.transform.position.y - range,0);
			}
			SpawnGrid[x,y] = -1;
		}
		if(SpawnGrid[x,y] == 3){
			range = 2;
			Enemy1 = EnemyPooler.SharedInstance.GetPooledEnemy();
			if(Enemy1 != null){
				Enemy1.SetActive(true);
				Enemy1.transform.position = new Vector3(MainCamera.transform.position.x + range,MainCamera.transform.position.y + range,0);
			}
			Enemy2 = EnemyPooler.SharedInstance.GetPooledEnemy();
			if(Enemy2 != null){
			Enemy2.SetActive(true);
			Enemy2.transform.position = new Vector3(MainCamera.transform.position.x + range,MainCamera.transform.position.y - range,0);
					}
			SpawnGrid[x,y] = -1;

		}
		if(SpawnGrid[x,y] == 4){
		range = 5;
		Enemy1 = EnemyPooler.SharedInstance.GetPooledEnemy();
		if(Enemy1 != null){
			Enemy1.SetActive(true);
			Enemy1.transform.position = new Vector3(MainCamera.transform.position.x + range,MainCamera.transform.position.y,0);
		}
		Enemy2 = EnemyPooler.SharedInstance.GetPooledEnemy();
		if(Enemy2 != null){
		Enemy2.SetActive(true);
		Enemy2.transform.position = new Vector3(MainCamera.transform.position.x,MainCamera.transform.position.y - range,0);
				}
		SpawnGrid[x,y] = -1;
		}
	}
}
