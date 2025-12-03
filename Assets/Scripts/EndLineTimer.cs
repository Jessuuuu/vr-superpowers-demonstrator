using System;
using System.IO;
using UnityEngine;

public class EndLineTimer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public static float Endtime;
    private string usedPower;

    private void OnTriggerEnter(Collider other)
    {
        if(StartLineTimer.startedTimer) {
            Endtime = Time.time - StartLineTimer.startTime;
             //Debug.Log(Endtime);
            StartLineTimer.startedTimer = false;

            if(Activate_no_power.flying_selected){
                usedPower = "Flying";
            }
            else if(Activate_no_power.super_speed_selected){
                usedPower = "Superspeed";
            }
            else {
                usedPower = "No power";
            }

            File.AppendAllText("FinishedTimes.csv", 
                   DateTime.UtcNow.ToString("dd/MM/yyyy") + "," + DateTime.UtcNow.ToString("HH:mm:ss") + ","+ Endtime + ","+ usedPower + Environment.NewLine);

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
