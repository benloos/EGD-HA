using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField]
    Vector3 respawn = new Vector3(2.0f, 1.0f, -15.0f);
    [SerializeField] private AudioClip Teleport;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(Teleport, Camera.main.transform.position);
            other.transform.position = respawn;
        }
    }
}
