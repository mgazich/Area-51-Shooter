using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPooler : MonoBehaviour
{
    public List<GameObject> pooledEnemys;
    public GameObject EnemyToPool;
    public int amountToPool;
    public static EnemyPooler SharedInstance;
    
    void Awake(){
    	SharedInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
    	pooledEnemys = new List<GameObject>();
    	for(int i = 0; i < amountToPool; i++){
    	    GameObject obj = (GameObject)Instantiate(EnemyToPool);
    	    obj.SetActive(false);
    	    pooledEnemys.Add(obj);
    	}
    }
    public GameObject GetPooledEnemy(){
    	for(int i = 0; i < pooledEnemys.Count;i++){
    	    if(!pooledEnemys[i].activeInHierarchy){
    	    	return pooledEnemys[i];
    	    }
    	}
    	return null;
    }
}
