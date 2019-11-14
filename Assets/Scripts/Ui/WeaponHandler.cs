using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    public GameObject star;
    public GameObject Knife;
    public GameObject weaponSwap;
    public WeaponSwap WeaponGun;

    // Start is called before the first frame update
    void Start()
    {
    	weaponSwap = GameObject.Find("Player");
	WeaponGun = weaponSwap.GetComponent<WeaponSwap>();
	Knife = GameObject.Find("Knife");;
    	star = GameObject.Find("Star");;
    }

    // Update is called once per frame
    //Image of star appears or knife based off of the status of weapon 
    void Update()
    {
        if(WeaponGun.isStar){
            	star.SetActive(true);
            	Knife.SetActive(false);
        }else{
            	star.SetActive(false);
    		Knife.SetActive(true);
            
        }
	
    }
}
