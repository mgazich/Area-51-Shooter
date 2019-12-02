using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMelee : MonoBehaviour
{
        public GameObject attack; //for image
        public GameObject enemy; //player
        public GameObject weaponSwap;
	public WeaponSwap WeaponGun;
        public float attackRange; //changeable range
        private float slashRate = 1.5f;
      	public float nextSlash = 0f;
        // Start is called before the first frame update
        void Start()
        {
			weaponSwap = GameObject.Find("Player");
			WeaponGun = weaponSwap.GetComponent<WeaponSwap>();
			enemy = GameObject.Find("Enemy"); //find player
			attack = GameObject.Find("PlayerMelee"); //find this
			attackRange = 2; //range intitally 2
			attack.SetActive(false); // disappear
        }

        // Update is called once per frame
        void Update()
        {
				//if distance < range
			if(Input.GetButton("Fire1") && WeaponGun.isStar == false && Time.time > nextSlash)
			{
        nextSlash = Time.time + slashRate;
				StartCoroutine( ShowAndHide(attack, 0.25f) );
			}
    	}
    	//function to handle timing
	IEnumerator ShowAndHide( GameObject go, float delay )
	{
		go.SetActive(true);
		yield return new WaitForSeconds(delay);
		go.SetActive(false);
	 }
}
