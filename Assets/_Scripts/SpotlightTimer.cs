using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightTimer : MonoBehaviour
{
    private float MaxTime = 5f;
    private float MinTime = 2f;
    private float time;
    private float TriggerTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void FixedUpdate()
    {
        time += Time.deltaTime;

        if(time >= TriggerTime)
        {
            TriggerTimerEvent();
            SetRandomTime();
        }
    }

   void TriggerTimerEvent()
    {
        time = MinTime;
        EventBus.Current.lightsGoToggleTrigger();
        
    }

    void SetRandomTime()
    {
        TriggerTime = Random.Range(MinTime, MaxTime);
    }

    
}
