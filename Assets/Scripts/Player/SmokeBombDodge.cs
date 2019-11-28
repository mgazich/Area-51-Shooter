using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SmokeBombDodge : MonoBehaviour
{
	private Camera cam;
	private Vector3 teleportDirection;
	private float teleportRate = 2f;
	public float nextTeleport = 0f;
	public Tilemap walls;
	Vector3Int v3int;
	PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
       cam = Camera.main;
	   playerMovement = gameObject.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 v3 = (cam.ScreenToWorldPoint(Input.mousePosition));
		v3int = walls.WorldToCell(v3);
		if (Input.GetButton ("Fire2") && Time.time > nextTeleport && walls.GetTile(v3int) == null)
		{
			nextTeleport = Time.time + teleportRate;
			teleportDirection = cam.ScreenToWorldPoint(Input.mousePosition);
			teleportDirection.z = 0.0f;
			this.transform.position = (teleportDirection);
			StartCoroutine(ExampleCoroutine());
		}
		
    }
	
	IEnumerator ExampleCoroutine()
	{
		float temp = playerMovement.speed;
		playerMovement.speed = 0.0f;
		yield return new WaitForSeconds(.001f);
		playerMovement.speed = temp;
	}
	

	
}
