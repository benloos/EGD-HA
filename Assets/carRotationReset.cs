using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carRotationReset : MonoBehaviour
{
    Rigidbody player;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            player = other.GetComponent<Rigidbody>();
            player.constraints = RigidbodyConstraints.None;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Car")) 
        {
            player = other.GetComponent<Rigidbody>();
            player.transform.rotation = Quaternion.Euler(15, 90, 0);
            player.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        }
    }
}
