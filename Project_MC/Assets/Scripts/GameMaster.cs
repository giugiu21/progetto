using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameMaster : MonoBehaviour
{
    public GameObject restartPanel;

    public TextMeshProUGUI timerDisplay;

    public GameObject nextLevelPanel;

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
            Pause();
            if (SceneManager.GetActiveScene().name == "Lv-3")
            {
                Invoke("Congrats", 0.3f);
            }
            nextLevelPanel.SetActive(true);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }

    private void Congrats()
    {
        Resume();
        SceneManager.LoadScene("Congratulations");
    }
   
   
    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        hasLost = true;
        Invoke("Delay", 0.5f);

    }

    void Delay()
    {
        restartPanel.SetActive(true);
        Pause();
    }

    public void GoToGameScene()
    {
        SceneManager.LoadScene("Lv-1");
    }

    public void Restart()
    {
        Resume();
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene("Lv-1");
    }

    public void GoToMainMenu()
    {
        Resume();
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene("MainMenu");
    }

    
}
