using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BraceletSocket : MonoBehaviour
{

    private UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor socket;
    private Bracelet selected;

    // Start is called before the first frame update
    void Start()
    {
        socket = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PutOnBracelet()
    {
        selected = ((UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable)(socket.firstInteractableSelected)).GetComponent<Bracelet>();
        selected.PutOn();
    }

    public void TakeOffBracelet()
    {
        selected.TakeOff();
        selected = null;
    }
}
