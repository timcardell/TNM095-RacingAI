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
        move();
        turn();
        fall();

    }




    void move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rB.AddRelativeForce(new Vector3(Vector3.forward.x,0,Vector3.forward.z) * speed * 10);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rB.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * -speed * 10);
        }
    }

    void turn()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rB.AddTorque(Vector3.up * turnSpeed * 8);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rB.AddTorque(-(Vector3.up * turnSpeed * 8));
        }
    }
    void fall()
    {
        rB.AddForce(Vector3.down * gravityMult * 10);
    }


 }
