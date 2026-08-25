using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour
{
    
    public TMP_Text scoreText;

    int myScore = 00;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = myScore.ToString();
    }


    public void AddScore(int scoreToAdd)
    {
        myScore += scoreToAdd;
    }

    public int GetScore()
    {
        return myScore;
    }

    public void SetScore(int score)
    {
        myScore = score;
    }


}
