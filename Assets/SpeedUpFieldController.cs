using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpFieldController : MonoBehaviour
{
    public float _x = 1000f;
    public float _y = 1000f;
    public float _z = 0f;

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Car"){
            other.gameObject.GetComponent<Rigidbody>().mass = 10f;
            other.gameObject.GetComponent<Rigidbody>().AddForce(_x,_y,_z);
            other.gameObject.GetComponent<Rigidbody>().mass = 1000f;
        }
    }
}
