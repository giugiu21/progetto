using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class CountDown : MonoBehaviour
{
    public float countdown;
    public TextMeshProUGUI countDownDisplay;


    // Update is called once per frame
    void Update()
    {
        if (countdown < 0)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        else
        {
            countdown -= Time.unscaledDeltaTime;
        }

        countDownDisplay.text = countdown.ToString("F0");
    }

    void timesUp()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
