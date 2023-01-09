using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score = 0;

    public void AddScore(int amount) {
        score += amount;
        Debug.Log("Score: " + score);
    }

    public void SubtractScore(int amount) {
        score -= amount;
        Debug.Log("Score: " + score);
    }

    public void ResetScore() {
        score = 0;
        Debug.Log("Score: " + score);
    }
}
