using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LightManager : MonoBehaviour
{
    [SerializeField] private LampLight[] initialLampArray;
    [SerializeField] private LampLight[] noFlickeringArray;    
    private readonly Queue<LampLight> BlinkingLampQueue = new Queue<LampLight>();
    [SerializeField] GameData gameData;

    [SerializeField] private int maxTimeDuration;
    private LampLight currentLampLight;

    // a bit obsolete after i deciced to keep the closest lamps on 
    private int lampsCounter; // counting ones that are On
    private int lLampsCounter; //left 2
    private int rLampsCounter;  // right 2


    private void Start()
    {
        lampsCounter = 0;
        lLampsCounter = 0;
        rLampsCounter = 0;
        
    }

    #region Private Functions
    

    private void EnqueueAfterSpawn() //preparation of the lights 
    {
        foreach (LampLight lamp in noFlickeringArray)
        {
            lamp.NoFlickering();
        }
        foreach (LampLight lamp in initialLampArray)
        {
            BlinkingLampEnqueue(lamp);           // this one keeps rolling because throughout the game lamps keep queuing
        }
    }

    private void LampSetupper() //is called at the start spawn and then when lamp enqueues
    {
        currentLampLight = BlinkingLampQueue.Dequeue();  
        currentLampLight.TimeDuration = Random.Range(0.5f,2f) * maxTimeDuration;
        currentLampLight.LightOn = Random.Range(0,2);
        


        if (currentLampLight.LightOn==1)
            {                
                  //LightOn is true here
                    CountersUpdate(1);                    
                    currentLampLight.Flickering = Random.Range(0, 2) == 0;                                  
            }
            else
            {
                //LightOn is false here
                if (lampsCounter > 0)  CountersUpdate(-1);
                currentLampLight.TimeDuration /= 2;
            }

        
        StartCoroutine(currentLampLight.RunJobBlinking());        
        
    }

    private void CountersUpdate(int value)  
    {
        if (value == 1 || value == -1)
        {
            lampsCounter = lampsCounter >= 0 ? lampsCounter + value : lampsCounter;
            lLampsCounter = currentLampLight.LeftLamp == true ? lLampsCounter + value : lLampsCounter;
            rLampsCounter = currentLampLight.LeftLamp == false ? rLampsCounter + value : rLampsCounter;
            
            
        }
        else
        {
            if (lampsCounter < 0)  Debug.Log("lamps counter cannot be less then 0");
            
            else  Debug.Log("you're trying to change the value by more than 1. this is not what i was made for");
        }
    }


    #endregion

    #region Public Functions
    // it's probably no good that lightManager and lampLights call out each others functions
    public void BlinkingLampEnqueue(LampLight lampLight)  //for LampLight to call it
    {
        BlinkingLampQueue.Enqueue(lampLight);
        LampSetupper();
    }
    

    #endregion

    private void OnEnable()
    {
        EventManager.StartListening(gameData.MonstersSpawn, EnqueueAfterSpawn);
    }
    private void OnDisable()
    {
        EventManager.StopListening(gameData.MonstersSpawn, EnqueueAfterSpawn);
        

    }
}





