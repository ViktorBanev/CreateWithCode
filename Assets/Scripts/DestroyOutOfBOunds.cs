﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBOunds : MonoBehaviour
{
    private float topBound = 30;
    private float bottomBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if an object goes pat the player remove that object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBound)
        {
            Debug.Log("Game over!");
            Destroy(gameObject);
        }
        
    }
}
