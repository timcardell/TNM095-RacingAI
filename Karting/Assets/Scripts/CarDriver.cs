using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class CarDriver : MonoBehaviour
{
    public Rigidbody RB;

    public float forwardAcceleration = 8.0f, reverseAcceleration = 4.0f;
    public float maxSpeed = 50f, turnStrenght = 100;
    public float gravityForce = 9.82f;
    private float speedInput, turnInput;
    private bool grounded;
    public float dragCoeff = 3.0f;

    [Header("Animations")]

    public Transform LeftFrontWheel, RightFrontWheel;
    public Transform LeftBackWheel, RightBackWheel;
    public Transform steeringWheel;

    [Header("GroundDetection")]

    public LayerMask whatIsGroudn;
    public float groundRayLenght = 0.5f;
    public Transform groundRayPoint;

    private void Start()
    {
        RB.transform.parent = null;
    }

    private void Update()
    {
        speedInput = 0.0f;

        if(Input.GetAxis("Vertical") > 0)
        {
            speedInput = Input.GetAxis("Vertical") * forwardAcceleration * 100f;
        }
        else if(Input.GetAxis("Vertical") < 0)
        {
            speedInput = Input.GetAxis("Vertical") * reverseAcceleration * 100f;
        }

        turnInput = Input.GetAxis("Horizontal");
        if (grounded)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnStrenght * Time.deltaTime * Input.GetAxis("Vertical"), 0f));

        }


        transform.position = RB.transform.position;
    
        //Animations
        LeftFrontWheel.localEulerAngles = new Vector3(0, 90+(Input.GetAxis("Horizontal") * 15), 0);
        RightFrontWheel.localEulerAngles = new Vector3(0, 90+(Input.GetAxis("Horizontal") * 15), 0);
     

        if (Input.GetAxis("Vertical") > 0)
        {
            LeftFrontWheel.localEulerAngles += new Vector3(0, 0, -RB.velocity.magnitude / 2);
            RightFrontWheel.localEulerAngles += new Vector3(0, 0, RB.velocity.magnitude / 2);

            LeftBackWheel.localEulerAngles += new Vector3(0, 0, 2 * (-RB.velocity.magnitude / 2));
            RightBackWheel.localEulerAngles += new Vector3(0, 0, 2 * (RB.velocity.magnitude / 2));
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            LeftFrontWheel.localEulerAngles += new Vector3(0, 0, RB.velocity.magnitude / 2);
            RightFrontWheel.localEulerAngles += new Vector3(0, 0, -RB.velocity.magnitude / 2);

            LeftBackWheel.localEulerAngles += new Vector3(0, 0, 2 * (RB.velocity.magnitude / 2));
            RightBackWheel.localEulerAngles += new Vector3(0, 0, 2 * (-RB.velocity.magnitude / 2));
        }
  
        steeringWheel.localEulerAngles = new Vector3(45,0, -Input.GetAxis("Horizontal") * 15);

    }

    private void FixedUpdate()
    {
        grounded = false;
        RaycastHit hit;

        if(Physics.Raycast(groundRayPoint.position, -transform.up,out hit,groundRayLenght,whatIsGroudn))
        {
            grounded = true;
        }

        if (grounded)
        {
            RB.drag = dragCoeff;
            if (Mathf.Abs(speedInput) > 0)
            {
                RB.AddForce(transform.forward * speedInput);
            }
        }
        else
        {
            RB.drag = 0.1f;
            RB.AddForce(Vector3.up * -gravityForce * 100f);
        }

    }

}