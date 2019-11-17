using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeBombDodge : MonoBehaviour
{
	private Camera cam;
	private Vector3 teleportDirection;
	private float teleportRate = 2f;
	public float nextTeleport = 0f;
	public LayerMask collisionLayers;
    // Start is called before the first frame update
    void Start()
    {
       cam = Camera.main; 
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButton ("Fire2") && Time.time > nextTeleport)
		{
			nextTeleport = Time.time + teleportRate;
			teleportDirection = cam.ScreenToWorldPoint(Input.mousePosition);
			teleportDirection.z = 0.0f;
			this.transform.position = (teleportDirection);

		}
		
    }
	
	
}
