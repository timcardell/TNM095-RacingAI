using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sheep : MonoBehaviour
{
    public Text SheepText;
    public Player CurrentPlayer;

    // Update is called once per frame
    void Update()
    {
        SheepText.text = "Sheep: " + CurrentPlayer.Sheep;
    }
}
