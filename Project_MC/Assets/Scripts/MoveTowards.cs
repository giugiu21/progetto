using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{

    public Transform otherPlanet;

    public float speed;

    // Update is called once per frame
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, otherPlanet.position, speed * Time.deltaTime);
    }
}
