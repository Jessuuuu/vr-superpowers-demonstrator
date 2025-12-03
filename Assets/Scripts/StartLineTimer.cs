using UnityEngine;

public class StartLineTimer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public static float startTime;
    public static bool startedTimer;

    private void OnTriggerEnter(Collider other)
    {
        startTime = Time.time;
        startedTimer = true;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
