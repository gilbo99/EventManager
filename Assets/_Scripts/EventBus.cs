using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventBus : MonoBehaviour {
    private static EventBus _current;
    //Makes an Event 
    
    public static EventBus Current { get { return _current; } }
    private int Lives = 5;

    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(this.gameObject);
        } else {
            _current = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public int ReturnPrivateLives()
    {
        return Lives;
    }

    public void ReduceLives()
    {
        Lives--;
    }
    public event Action eventName;
    public void eventNameTrigger()
    {
        eventName();
    }

    public event Action lightsGoOn;
    public void lightsGoOnTrigger()
    {
        lightsGoOn();
    }
    public event Action lightsGoOff;
    public void lightsGoOffTrigger()
    {
        lightsGoOff();
    }

    public event Action lightsGoToggle;
    public void lightsGoToggleTrigger()
    {
        lightsGoToggle();
    }
    
    


}