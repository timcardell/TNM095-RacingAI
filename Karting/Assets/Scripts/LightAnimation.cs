using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAnimation : MonoBehaviour
{
    private float DayLength = 1.0f;
    private float _rotationSpeed = 10.0f;
    //private float translation = 100.0f;

    void Update()
    {
        _rotationSpeed = Time.deltaTime / DayLength;
        transform.Rotate(0f, _rotationSpeed, 0f);
        //transform.Translate(0f, 0f, translation);
    }
}

