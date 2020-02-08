using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // add score and update text to UI
    public void addScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score.ToString();
    }
}