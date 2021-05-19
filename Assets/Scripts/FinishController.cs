using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishController : MonoBehaviour
{
    public AudioClip rejoice;
    


  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.current.EndTimer();
            AudioSource.PlayClipAtPoint(rejoice, Camera.main.transform.position);
            

        }
    }
}
