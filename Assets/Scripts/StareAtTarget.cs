//rotates towards the player
//might need to fix later
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StareAtTarget : MonoBehaviour
{
    public float speed = 5; //speed of rotate
    GameObject player; // get player
    public bool instant; //instant
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player"); //find player
    }

    // Update is called once per frame
    void Update()
    {
	float playerAngle = Mathf.Atan2(gameObject.transform.position[1] - player.transform.position[1], gameObject.transform.position[0] - player.transform.position[0]) * Mathf.Rad2Deg; // math geo tan(change y/change x) * rad (all in degrees)
	Quaternion desiredRotation = Quaternion.AngleAxis(playerAngle - 90, Vector3.forward); //rotate based off of angle and then the axial
	
	if (instant)
	{
		transform.rotation = desiredRotation; // no speed
	}
	else
	{
		transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, speed * Time.deltaTime * Mathf.Rad2Deg ); //rotate off speed
	}
    }
}
