using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartController : MonoBehaviour
{ 
    public AudioClip start;
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            GameManager.current.BeginTimer();
            AudioSource.PlayClipAtPoint(start, Camera.main.transform.position, 0.2f);
        }
    }
}
