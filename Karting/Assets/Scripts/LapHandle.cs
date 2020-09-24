using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapHandle : MonoBehaviour
{
    int checkPointAmt;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<KartLap>())
        {
            KartLap kart = other.GetComponent<KartLap>();

            if (kart.checkPointIndex == checkPointAmt)
            {
                kart.checkPointIndex = 0;
                kart.lapNumber++;
                Debug.Log(kart.lapNumber);
            }


        }
    }
}
