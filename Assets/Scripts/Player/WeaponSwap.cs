using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
    public bool isStar; // bool to swap between melee and ranged

    // Start is called before the first frame update
    void Start()
    {
    	isStar = true; 
    	
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)) // Z to swap
        {
        	swap();
        }
    }
    void swap(){
    	isStar = !isStar;
    }
    
}
