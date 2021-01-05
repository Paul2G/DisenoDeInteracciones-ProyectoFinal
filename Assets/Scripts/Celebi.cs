using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celebi : VoiceInteractable
{
    //Rigidbody rb;

    //public Vector3 moveDirection;

    //public float moveForce = 5f;

    void Awake ()
    {
        //rb = GetComponent<Rigidbody>();
    }

    public override void VoiceInteract(string action)
    {
        base.VoiceInteract(action);

        if(action == "up")
        {
            Debug.Log("Volando");
            //rb.AddForce(moveDirection * moveForce, ForceMode.Force);
        } else if (action == "down"){
            Debug.Log("Cayendo");
            //rb.AddForce(-1 * moveDirection * moveForce, ForceMode.Force);
        }
    }
}
