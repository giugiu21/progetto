using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehavior : MonoBehaviour
{
    public Transform shotPos;

    public GameObject bomb;

    private float timer;
    

    // Update is called once per frame
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 0.75)
        {
            timer = 0;
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(bomb, shotPos.position, Quaternion.identity);
    }

}
