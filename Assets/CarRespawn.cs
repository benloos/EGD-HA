using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRespawn : MonoBehaviour
{
    [SerializeField] private Transform Car;
    [SerializeField] private Transform Respawn;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Car.transform.position = Respawn.transform.position;
        }
    }
}
