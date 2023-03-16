using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraExample : MonoBehaviour
{
    public Transform target;
    public float delay = 1;
    public Camera[] cameras;
    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        cameras[1].enabled = false;
        cameras[2].enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Camera follows your target without camera change its position
        //transform.LookAt(target);

        //Adjustable position and delay to camera to follow your target
        transform.position = Vector3.Lerp(transform.position, target.position, delay * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.F9))
        {
            DisableCameras();
            cameras[0].enabled = true;
            ui.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.F10))
        {
            DisableCameras();
            cameras[1].enabled = true;
            ui.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F11))
        {
            DisableCameras();
            cameras[2].enabled = true;
            ui.SetActive(false);
        }


    }
    public void DisableCameras()
        {
     for (int i = 0; i<cameras.Length; i++)
            {
                cameras[i].enabled = false;
            }
        }



}

