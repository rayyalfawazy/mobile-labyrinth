using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] Coin coin;
    int score = 0;

    private void Start()
    {
        scoreText.text = $"Score : {score}";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            score += coin.GetScoreAddition;
            scoreText.text = $"Score : {score}";
        }
    }

    public int GetScore()
    {
        return score;
    }
}
