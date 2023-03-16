using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pallotesti : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Pallo";
        transform.position = new Vector3(-6, 9, 16);
        print("Pallo on pomppiva");
    }

    // Update is called once per frame
    void Update()
    {
        // This line moves the ball forward, with speed from unity editor
        // transform.position = transform.position + Vector3.forward * speed * Time.deltaTime;

        // This is another code to do same thing!
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
           
       
    }
}
