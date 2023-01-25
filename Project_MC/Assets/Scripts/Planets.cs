using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour
{
    private GameMaster gm;

    private Shake shake;

    


    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "planets" || collision.tag == "bomb" || collision.tag == "meteor")
        {
            shake.CamShake();
            FindObjectOfType<AudioManager>().Play("DeathSound");
            gm.GameOver();
            Destroy(gameObject);
        }
    }
}
