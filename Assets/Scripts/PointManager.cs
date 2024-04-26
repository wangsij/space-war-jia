using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    //the score of the player
    public int score;
    //the score text for UI
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    //Keep track of the score, and update the UI as it goes
    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }


}
