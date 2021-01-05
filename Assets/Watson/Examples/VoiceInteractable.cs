using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IBM.Watsson.Examples;

public class VoiceInteractable : MonoBehaviour
{
    private VoiceComandProcessor comandProcessor;

    void Start()
    {
        comandProcessor = VoiceComandProcessor.Instance;
        comandProcessor.onVoiceComand += VoiceInteract;
    }

    public virtual void VoiceInteract(string action)
    {
        Debug.Log("Interactuando por voz, accion es " + action);
    }
}
