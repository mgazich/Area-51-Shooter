using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorScriptUp : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
      if(other.gameObject.name == "Player")
      {
        door.GetComponent<DoorBehaviorDown>().locked = true;
      }
    }
}
