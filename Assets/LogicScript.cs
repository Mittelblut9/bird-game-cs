using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameOverPanel;
    public PipeSpawner spawner;
    public bool isDead = false;

    void start() {
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<PipeSpawner>();
    }

    [ContextMenu("Increase score")]
    public void addScore(int amount = 1) {
        if(isDead) return;
        score += amount;
        scoreText.text = score.ToString();
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        gameOverPanel.SetActive(true);
        addScore(0);
        isDead = true;
    }

    public bool getDead() {
        return isDead;
    }
}
