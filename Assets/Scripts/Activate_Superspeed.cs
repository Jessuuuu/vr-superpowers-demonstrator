using UnityEngine;

public class Activate_Superspeed : MonoBehaviour
{
     private void OnTriggerEnter(Collider other)
    {
        Activate_no_power.super_speed_selected  = true;
        Activate_no_power.flying_selected = false;
    } 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
