using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerScore = 0;
    //public Text;
    public void AddScore(int points)
    {
        playerScore += points;
        //text.text = "Points: " + playerScore;
        Debug.Log("Score updated: " + playerScore);
    }
}
