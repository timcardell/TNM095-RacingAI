using UnityEngine;
using UnityEngine.UI;

public class Bricks : MonoBehaviour
{
    public Text BrickText;
    public Player CurrentPlayer;

    // Update is called once per frame
    void Update()
    {
        BrickText.text = "Bricks: " + CurrentPlayer.Bricks;
    }
}
