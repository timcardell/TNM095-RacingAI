using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playOnW : MonoBehaviour
{

    public AudioSource someSound;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!someSound.isPlaying)
            {
                someSound.Play();
            }
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            someSound.Stop();
        }
    }
}