using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public int Wheat, Sheep, Stone, Bricks, score;
    int turnCounter;
    public int[] Roads;
    public int[] Towns;
    public int[] Settlements;

    // Start is called before the first frame update
    void Start()
    {
        Wheat = 0;
        Sheep = 0;
        Stone = 0;
        Bricks = 0;
        score = 10;
    }

   
    // Update is called once per frame
    void Update()
    {
        if(turnCounter == 1)
        {
            if (score == 10)
            {
                Console.Write("You won!");
            }
        }
      
    }
}
