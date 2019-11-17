using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
    public Weapons weapon;
    public enum Weapons{Ranged, Melee}
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        weapon = Weapons.Ranged;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
