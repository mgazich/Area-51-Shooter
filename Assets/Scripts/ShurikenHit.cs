using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenHit : MonoBehaviour
{
	public float damageAmount = 1f;
    public LayerMask collisionLayers;
	GameObject MainCamera;
    // Start is called before the first frame update
    void Start()
    {
        MainCamera = GameObject.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
		/*if((transform.position.x > (MainCamera.transform.position.x)+12) || (transform.position.x < (MainCamera.transform.position.x)-12) || (transform.position.y > (MainCamera.transform.position.y)+10) || (transform.position.y < (MainCamera.transform.position.y)-10))
		{
			Debug.Log(transform.position.x + " : " + MainCamera.transform.position.x);
			Destroy(gameObject);
		}	*/
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
        
        if (collision.CompareTag("Enemy"))
	    {
	    	Enemy enemy = collision.GetComponent<Enemy>();
	    	enemy.Damage(damageAmount);
			Destroy(gameObject);
	    }

        if (1 << collision.gameObject.layer == collisionLayers.value)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       // Debug.Log("Hello");
        if (collision.gameObject.layer == collisionLayers)
        {
            Destroy(this.gameObject);
        }
    }
}
