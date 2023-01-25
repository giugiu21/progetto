using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLogin : MonoBehaviour
{
    public void Login()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene("Login");
    }
}
