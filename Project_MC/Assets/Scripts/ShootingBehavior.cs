using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehavior : MonoBehaviour
{
    public Transform shotPos;

    public GameObject bomb;

    public float shootingTime;

    private float timer;
    

    // Update is called once per frame
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= shootingTime)
        {
            timer = 0;
            Shoot();
        }
    }

    private void Shoot()
    {
        if (shotPos != null)
        {
            Instantiate(bomb, shotPos.position, Quaternion.identity);
        }
    }

}
