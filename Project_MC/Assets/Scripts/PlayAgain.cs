using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public GameObject confettiEffect;
    public GameObject confetti2Effect;
    public GameObject confetti3Effect;


    public void Start()
    {
        Instantiate(confettiEffect,transform.position, Quaternion.identity);
        Instantiate(confetti2Effect, transform.position, Quaternion.identity);
        Instantiate(confetti3Effect, transform.position, Quaternion.identity);

    }
    public void GoToGameScene()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene("Lv-1");
    }
}
