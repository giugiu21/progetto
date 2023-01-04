using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehavior : MonoBehaviour
{
    public Transform shotPos;

    public GameObject bomb;
    private float timeBtwShot;
    private float startTimeBtwShot;


    // Update is called once per frame
    private void Update()
    {
        if(timeBtwShot <= 0)
        {
            Instantiate(bomb, shotPos.position, Quaternion.identity);
            timeBtwShot = startTimeBtwShot;
        }
        else
        {
            timeBtwShot = Time.deltaTime;
        }
    }
}
