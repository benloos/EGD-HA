using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    Vector3 ballSpawn = new Vector3(50f, 2.2f, -7.0f);
    Vector3 resetVelo = new Vector3(0.0f, 0.0f, 0.0f);

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            other.GetComponent<Rigidbody>().velocity = resetVelo;
            other.transform.position = ballSpawn;
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0.25f, 0.25f, 0.25f);
    }
}
