using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerProto2 : MonoBehaviour
{
    //private variables
    public float speed = 10.0f;
    //private float turnSpeed = 30.0f;
    private float horizontalInput;
    //private float for player movements range
    private float xRange = 10f;


    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //launch projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        //check and limit player movements
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }
        //we are getting input
        horizontalInput = Input.GetAxis("Horizontal");
        //verticalInput = Input.GetAxis("Vertical");

        //move player left right
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        //rotates car based on hor input
        //transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
