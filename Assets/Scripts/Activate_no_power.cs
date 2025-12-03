using UnityEngine;

public class Activate_no_power : MonoBehaviour
{
    public static bool flying_selected = false;
    public static bool super_speed_selected = false;

    private void OnTriggerEnter(Collider other)
    {
        super_speed_selected  = false;
        flying_selected = false;
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
