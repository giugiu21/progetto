using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayOrGoBack : MonoBehaviour
{
   public void PlayGame()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene("Lv-1");
    }

    public void GoBack()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene("MainMenu");
    }
}
