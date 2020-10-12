using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceManager : MonoBehaviour
{
    public GameObject[] carObjects;
    public CarDriver[] allCars;
    public CarDriver[] carOrder;

    public void Start()
    {
        // set up the car objects
        allCars = new CarDriver[carObjects.Length];
        carOrder = new CarDriver[carObjects.Length];

        for (int i = 0; i < carObjects.Length; i++)
        {
            allCars[i] = carObjects[i].GetComponent<CarDriver>();
        }
    }

    // this gets called every frame
    public void Update()
    {
        foreach (CarDriver car in allCars)
        {
            carOrder[car.GetCarPosition(allCars) - 1] = car;
        }
    }
}