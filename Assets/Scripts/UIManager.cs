using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    void Start()
    {
        score = 0;   
    }
    public void ScoreUp()
    {
        score += 15;
        UpdateScoreUI();
    }
    public void ScoreDown()
    {
        score -= 15;
        UpdateScoreUI();
    }
    
    public void ScoreRandom()
    {
        int rndScore = Random.Range(20, 100);
        score = score + rndScore;
        UpdateScoreUI();
    }
    public void ScoreClear()
    {
        score = 0;
        UpdateScoreUI();
    }
    public void UpdateScoreUI()
    {
        scoreText.text = $"{score}";
    }
}
