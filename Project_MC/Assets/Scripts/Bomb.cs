using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private GameObject[] planets;

    private Vector2 target;

    public float speed;

    private GameMaster gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        planets = GameObject.FindGameObjectsWithTag("planets");

        int rand = Random.Range(0, planets.Length);
        target = planets[rand].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, target) < 0.2f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("planets"))
        {
            gm.GameOver();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
