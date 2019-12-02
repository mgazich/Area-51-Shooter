using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowShuriken : MonoBehaviour
{
	public GameObject shuriken;
	public float shurikenSpeed = 5f;
	private Vector3 shootDirection;
	private float fireRate = .75f;
	public float nextFire = 0f;
	public GameObject gun;
	public WeaponSwap WeaponGun;
    public AudioSource shurikenSound;
    // Start is called before the first frame update
    void Start()
    {
    	gun = GameObject.Find("Player");
			WeaponGun = gun.GetComponent<WeaponSwap>();
    }

    // Update is called once per frame
    void Update()
    {
			shootDirection = Input.mousePosition;
			shootDirection.z = 0.0f;
			shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
			shootDirection = shootDirection-transform.position;
      if (Input.GetButton ("Fire1") && Time.time > nextFire && WeaponGun.isStar == true && (shootDirection.x != 0 || shootDirection.y != 0))
			{
				nextFire = Time.time + fireRate;
				shoot();
			}
    }
	void shoot()
	{
		GameObject shurikenInitial = Instantiate(shuriken, transform.position, Quaternion.Euler(new Vector2(0, 0)));
		Rigidbody2D rb = shurikenInitial.GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2((shootDirection.x), (shootDirection.y)).normalized;
		rb.velocity = rb.velocity * shurikenSpeed;
        shurikenSound.Play();

	}

}
