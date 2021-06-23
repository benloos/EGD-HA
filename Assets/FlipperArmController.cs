using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperArmController : MonoBehaviour
{
   public float restPos = 0f;
   public float pressedPos = 45f;
   public float hitStrength = 100f;
   public float damper = 150f;
   public HingeJoint hinge;
    public PhysicMaterial boden;
 
    void Start(){
        boden.staticFriction = 0.6f;
        boden.dynamicFriction = 0.6f;
    }

    void Update() {
        JointSpring spring = new JointSpring();
        spring.spring = this.hitStrength;
        spring.damper = this.damper;
        
        if(Input.GetKey(KeyCode.K))
            spring.targetPosition = pressedPos;
        else
            spring.targetPosition = restPos;
        
        hinge.spring = spring;
        hinge.useLimits = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Car") && Input.GetKey(KeyCode.K))
        {
            Rigidbody player = other.gameObject.GetComponent<Rigidbody>();
            player.mass = 10f;
            boden.staticFriction = 0f;
            boden.dynamicFriction = 0f;
            player.AddForce(-300, 0, 0);
            player.mass = 1000f;
        }
    }

    IEnumerator delayedFriction()
    {
        yield return new WaitForSeconds(1);
        boden.staticFriction = 0.6f;
        boden.dynamicFriction = 0.6f;
    }
}
