using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameMaster : MonoBehaviour
{
    public GameObject restartPanel;

    public TextMeshProUGUI timerDisplay;

    public float timer;

    private bool hasLost;

    private void Update()
    {
        if (hasLost == false)
        {
            timerDisplay.text = timer.ToString("F0");
        }

        if(timer <= 0 && !hasLost)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }

    public void GameOver()
    {
        hasLost = true;
        Invoke("Delay", 1f);
        
    }

    void Delay()
    {
        restartPanel.SetActive(true);
    }

    public void GoToGameScene()
    {
        SceneManager.LoadScene("Lv-1");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToLogin()
    {
        SceneManager.LoadScene("Login");
    }
}
