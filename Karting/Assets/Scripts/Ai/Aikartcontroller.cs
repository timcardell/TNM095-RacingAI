using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aikartcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float turnSpeed;

    public int score = 0;



    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float dt = Time.deltaTime;
        MoveCar(horizontal, vertical,dt);
    }



    void MoveCar(float horizantal, float vertical,float dt)
    {
        float moveDistance = speed * 0.1f;
        transform.Translate(dt * moveDistance * Vector3.forward);

        float rot = turnSpeed * horizantal * 90f;
        transform.Rotate(0, dt * rot, 0);


    }




}
