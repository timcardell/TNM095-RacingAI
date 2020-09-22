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
    public List<GameObject> Roads;
    public List<GameObject> Towns;
    public List<GameObject> Settlements;

    // Start is called before the first frame update
    void Start()
    {
        
        Wheat = 0;
        Sheep = 0;
        Stone = 0;
        Bricks = 0;
        score = 0;
    }

   
    // Update is called once per frame
    void Update()
    {
        score = (Settlements.Count * 2) + Towns.Count;
        if (turnCounter == 1)
        {
           
            if (score == 10)
            {
                Console.Write("You won!");
                return;
            }
        }
      
    }
}
