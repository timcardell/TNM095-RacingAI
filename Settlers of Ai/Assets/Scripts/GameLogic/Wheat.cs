using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wheat : MonoBehaviour
{
    public Text WheatText;
    public Player CurrentPlayer;

    // Update is called once per frame
    void Update()
    {
        WheatText.text = "Wheat: " + CurrentPlayer.Wheat;
    }
}
