using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDriver : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float gravityMult;
    private Rigidbody rB;


    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody>();
    }
 
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float dt = Time.deltaTime;
        MoveCar(horizontal, vertical, dt);
        fall();
    }



    void MoveCar(float horizantal, float vertical, float dt)
    {
        float moveDistance = speed * vertical;
        transform.Translate(dt * moveDistance * Vector3.forward);

        float rot = turnSpeed * horizantal * 90f;
        transform.Rotate(0, dt * rot, 0);


    }
    void fall()
    {
        rB.AddForce(Vector3.down * gravityMult * 10);
    }


 }
