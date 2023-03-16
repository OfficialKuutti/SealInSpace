using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

    //T‰ss‰ on muuttujat, float = desimaalilukuja! public= muuttujat tulee s‰‰dett‰v‰ksi Unity editoriin.
{
    public float speed = 5;
    public float originalspeed;
    public float boostspeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        originalspeed = speed;   
    }

    // Update is called once per frame
    void Update()
    {
        //If button Jump is pressed gameobject moves boostspeed, elsewhere it moves originalspeed!

        if (Input.GetButton("Jump"))
        {
            speed = boostspeed;   
        }

        else
        {
            speed = originalspeed;
        }
        
        transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
        
    }
}
