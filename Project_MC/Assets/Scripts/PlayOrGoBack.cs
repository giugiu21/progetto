using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayOrGoBack : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("Lv-1");
    }

    public void GoBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
