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
 
    void Start(){
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
}
