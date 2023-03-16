using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacleScript : MonoBehaviour
{
    public float speed = 2f;
    public float timer;
    public float timetoturn;
    // Start is called before the first frame update
    void Start()
    {
        int dir = Random.Range(0, 2);
        if(dir == 0)
        {
            speed = -speed;
        }


        else
        {
            speed = speed;
        }
    
    }



    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        transform.position = transform.position + Vector3.right * speed * Time.deltaTime;

       //Use this if you want obstacles to change direction with timer
        /*
        if(timer > timetoturn)
        {
            speed = -speed;
            timer = 0f;
        }
        */
    
    }

    private void OnTriggerExit(Collider other)
    {
        speed = -speed;
    }
}
