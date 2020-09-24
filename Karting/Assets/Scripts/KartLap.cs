using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;

public class KartLap : MonoBehaviour
{
    // Start is called before the first frame update
    public int lapNumber;
    public int checkPointIndex;

    private void Start()
    {
        lapNumber = 0;
        checkPointIndex = 0;
    }

     private void Update()
    {
        if(lapNumber == 3|| Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
