using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{   

    // Start is called before the first frame update
    void Start()
    {
        EventBus.Current.eventName += FunctionToRun;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("q"))
        {
            Destroy(gameObject);
            EventBus.Current.ReduceLives();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(Input.GetKeyDown("e"))
        {
            
            print(EventBus.Current.ReturnPrivateLives());
        }

      //  if(Input.GetKeyDown("1"))
       // {
       //     EventBus.Current.lightsGoOnTrigger();
            
        //}
       // if(Input.GetKeyDown("2"))
       // {
        //    EventBus.Current.lightsGoOffTrigger();
            
       // }

    }
    
    public void FunctionToRun()
    {
        print("You paid respect!!!");
    }

    
}
