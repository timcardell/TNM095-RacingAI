using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCheckpoint : MonoBehaviour
{

    public int index;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<KartLap>())
        {
            KartLap kart = other.GetComponent<KartLap>();

            if(kart.checkPointIndex == index + 1 || kart.checkPointIndex == index - 1)
            {
                kart.checkPointIndex = index;
                Debug.Log(index);
            }


        }
    }
}
