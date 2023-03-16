using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWithGravity : MonoBehaviour
{
    public Rigidbody myRB;

    public float speed = 1; 

    
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
    // This is to trigger gameobject to do something when button is pressed ingame,
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {   
            myRB.AddForce(Vector3.up * speed);
        }

    }

    // This is useful to control Rigidbody physics to move gameobject!
    private void FixedUpdate()
    {
        myRB.velocity = Vector3.up * speed;
    }

}

