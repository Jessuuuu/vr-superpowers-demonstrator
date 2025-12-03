using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnlyGrabWithPower : MonoBehaviour
{

    public PowerColors Color;

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable grab;

    // Start is called before the first frame update
    void Start()
    {
        grab = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        grab.enabled = PowersManager.instance.GetPowerActive(Color);
    }
}
