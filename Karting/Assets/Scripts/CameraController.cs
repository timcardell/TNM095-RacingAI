using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject camera1;
    public GameObject camera2;


    private void Start()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
        }
        if (Input.GetKey("2"))
        {
            camera1.SetActive(false);
            camera2.SetActive(true);

        }

    }
}
