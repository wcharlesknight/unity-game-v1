using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using System;
using System.Timers;
using TMPro;

public class TimerC : MonoBehaviour
{   
    public GameObject words; 
    private System.Timers.Timer GameTimer;
    int nEventsFired = 0; 
    
    void Start()
    {   
        GameTimer = new System.Timers.Timer();
        GameTimer.Interval = 1000; 
        GameTimer.Start();
        GameTimer.Elapsed += AddTime;
  
    }

    void Update()
    {   
        gameObject.GetComponent<TMP_Text>().text = Convert.ToString(nEventsFired, 10);
    }
    
    public void AddTime(object source, ElapsedEventArgs e)
    {   
        Debug.Log(nEventsFired);
        nEventsFired++;
        if (nEventsFired == 7)
          {
            nEventsFired = 0; 
          }
      
    }
}
