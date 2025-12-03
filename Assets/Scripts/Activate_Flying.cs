using UnityEngine;

public class Activate_Flying : MonoBehaviour
{

     private void OnTriggerEnter(Collider other)
    {
        Activate_no_power.super_speed_selected  = false;
        Activate_no_power.flying_selected = true;
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
