using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMelee : MonoBehaviour
{
        public GameObject attack; //for image
        public GameObject enemy; //player
        public GameObject weaponSwap;
        public float attackRange; //changeable range
        // Start is called before the first frame update
        void Start()
        {
			weaponSwap =GameObject.Find("WeaponSwap");
			enemy = GameObject.Find("Enemy"); //find player
			attack = GameObject.Find("PlayerMelee"); //find this
			attackRange = 2; //range intitally 2
			attack.SetActive(false); // disappear
        }
    
        // Update is called once per frame
        void Update()
        {	
				//if distance < range
			if(Input.GetKeyDown("space"))
			{
				StartCoroutine( ShowAndHide(attack, 0.5f) );	
			}
    	}
		IEnumerator ShowAndHide( GameObject go, float delay )
		{
			go.SetActive(true);
			yield return new WaitForSeconds(delay);
			go.SetActive(false);
		 }
}
