using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment2.Events;

public class ScoreManager : MonoBehaviour
{
    public int CurrentScore = 0;

    void OnEnable()
    {
        // الاشتراك في الحدث (Event Subscription)
        EventManager.OnScoreChanged += AddScore;
    }

    void OnDisable()
    {
        EventManager.OnScoreChanged -= AddScore;
    }

    void AddScore(int points)
    {
        CurrentScore += points;
        Debug.Log("Score Updated: " + CurrentScore);
    }
}