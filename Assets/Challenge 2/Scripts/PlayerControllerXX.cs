using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerXX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogRate = 0.5f;
    private float nextDog = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextDog)
        {
            nextDog = Time.time + dogRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            
        }
    }
}
