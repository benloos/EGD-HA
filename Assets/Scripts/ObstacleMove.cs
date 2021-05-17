using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{

    public GameObject[] mover;
    int current = 0;
    public float speed = 1.0f;
    float Mradius = 1.0f;

    void Update()
    {
        if (Vector3.Distance(mover[current].transform.position, transform.position) < Mradius)
        {
            current = Random.Range(0, mover.Length);
            if (current >= mover.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, mover[current].transform.position, Time.deltaTime * speed);
    }
}