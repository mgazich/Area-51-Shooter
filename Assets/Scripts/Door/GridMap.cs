using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMap: MonoBehaviour
{
    //Assumes grid starts at 1 x y axises.
    public int x, y;	
    // Start is called before the first frame update
    void Start()
    {
	//player starts in this room
        x = 3;
        y = 0;
    }
}
