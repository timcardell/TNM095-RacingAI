using UnityEngine;
using UnityEngine.UI;

public class Stone : MonoBehaviour
{
    public Text StoneText;
    public Player CurrentPlayer;

    // Update is called once per frame
    void Update()
    {
        StoneText.text = "Stone: " + CurrentPlayer.Stone;
    }
}
