using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public Player CurrentPlayer;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + CurrentPlayer.score;
    }
}
