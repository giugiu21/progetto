using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour
{
    private GameMaster gm;


    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "planets" || collision.tag == "bomb" || collision.tag == "meteor")
        {
            gm.GameOver();
            Destroy(gameObject);
        }
    }
}
