using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
	public int score;
	public static Score instance = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	void Awake()
	{
		score = 0;
		instance = this;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
