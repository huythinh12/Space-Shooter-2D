using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour
{
    public Health playerHealth;
    public GameObject gameOverPanel;
    public Text scoreText;
    public GameObject backgroundMusic;

    private void Start()
    {
        Time.timeScale = 1f;
        gameOverPanel.SetActive(false);
        playerHealth.OnPlayerDied += OnPlayerDied;
    }

    private void OnPlayerDied()
    {
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
        backgroundMusic.SetActive(false);
    }

    public void OnTryAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Battle");
    }
}
