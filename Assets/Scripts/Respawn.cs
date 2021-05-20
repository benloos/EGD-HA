using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField]
    Vector3 respawn = new Vector3(2.0f, 1.0f, -15.0f);
    Vector3 ballSpawn = new Vector3(50f, 2.2f, -7.0f);
    [SerializeField] private AudioClip Teleport;
    public ParticleSystem respawnParticles;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(Teleport, Camera.main.transform.position);
            other.transform.position = respawn;
            respawnParticles.Play();
        }
        else if (other.CompareTag("Ball"))
        {

            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.transform.position = ballSpawn;
        }
    }
}
