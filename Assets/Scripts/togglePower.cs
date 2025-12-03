using UnityEngine;
using Unity.XR.CoreUtils;
using UnityEngine.Assertions;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Movement;

public class togglePower : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(StartLineTimer.flying_selected);
        if(Activate_no_power.flying_selected){
            GetComponent<ContinuousMoveProvider>().moveSpeed = 30;
            GetComponent<ContinuousMoveProvider>().enableFly= true;
        }
        else if(Activate_no_power.super_speed_selected){
            GetComponent<ContinuousMoveProvider>().moveSpeed = 40;
            GetComponent<ContinuousMoveProvider>().enableFly= false;
        }
        else{
            GetComponent<ContinuousMoveProvider>().moveSpeed = 10;
            GetComponent<ContinuousMoveProvider>().enableFly= false;
        }
        
    }
}
