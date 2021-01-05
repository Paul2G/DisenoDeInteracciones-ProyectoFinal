using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    bool isInsideZone = false;

    public virtual void Interact ()
    {
        
    }

    void Update ()
    {
        //Input.GetKeyDown(KeyCode.E)
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    void OnTriggerEnter(Collider other)
    {
    	if (!other.CompareTag("Player"))
    	{
    		return;
    	}

        isInsideZone=true;
    }

        void OnTriggerExit(Collider other)
    {
    	if (!other.CompareTag("Player"))
    	{
    		return;
    	}

        isInsideZone=false;
    }
}
