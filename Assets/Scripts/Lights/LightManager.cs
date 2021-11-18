using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LightManager : MonoBehaviour
{
    public LampLight[] initialLampList;
    private Queue<LampLight> lampQueue = new Queue<LampLight>();
    public GameData gameData;

    [SerializeField] private int maxTimeDuration;
    private int lampsCounter; // counting ones that are On
    private int lLampsCounter; //left 3
    private int rLampsCounter;  // right 3
    private LampLight currentLampLight;


    private void Start()
    {
        lampsCounter = 0;
        lLampsCounter = 0;
        rLampsCounter = 0;

        //needs to be                 some kind of checker whether all of the lights are initiated

        InitialEnqueue(); //preparation of the lights at the beginning and a start of the sequence of events

    }
    #region Private Functions
    private void LampSetupper() //is called at the start and then at the event calls
    {
        currentLampLight = lampQueue.Dequeue();  
        currentLampLight.TimeDuration = Random.Range(0.5f,2f) * maxTimeDuration;
        currentLampLight.LightOn = Random.Range(0,2);
        


        if (currentLampLight.LightOn==1)
            {
                //check whether there're more than 3 lights on and  more than 2 on left/right side
                if ((lampsCounter >= 3) || ((currentLampLight.LeftLamp && lLampsCounter >= 2) ||
                                (!currentLampLight.LeftLamp && rLampsCounter >= 2)))
                {
                    CountersUpdate(-1);
                    currentLampLight.LightOn = 0;
                }

                else
                {
                    //LightOn is true here
                    CountersUpdate(1);
                    
                    currentLampLight.Flickering = Random.Range(0, 2) == 0;
                    //Debug.Log("lightOn is true, flickering is " + currentLampLight.Flickering);
                }
            }
            else
            {
                //LightOn is false here
                if (lampsCounter > 0)  CountersUpdate(-1);
            
            }

        
        StartCoroutine(currentLampLight.RunJob());
        
        // —≈…◊¿— √Œ–ﬂ“ ¬—≈ À¿ÃœŒ◊ », ¿ ƒŒÀ∆ÕŒ Õ≈ ¡ŒÀ‹ÿ≈ “–≈’
    }

    private Tuple<int, int, int> CountersUpdate(int value)  
    {
        if (value == 1 || value == -1)
        {
            lampsCounter = lampsCounter >= 0 ? lampsCounter + value : lampsCounter;
            lLampsCounter = currentLampLight.LeftLamp == true ? lLampsCounter + value : lLampsCounter;
            rLampsCounter = currentLampLight.LeftLamp == false ? rLampsCounter + value : rLampsCounter;
            return new Tuple<int, int, int>(lampsCounter, lLampsCounter, rLampsCounter);
            
        }
        else
        {
            if (lampsCounter < 0)  Debug.Log("lamps counter cannot be less then 0");
            
            else  Debug.Log("you're trying to change the value by more than 1. this is not what i was made for");
                    
            return null;
        }
    }

    void InitialEnqueue()  
    {
        //initialLampList = FindObjectsOfType<LampLight>();
        foreach (LampLight lamp in initialLampList)
        {
            LampEnqueue(lamp);           
        }
    }
    #endregion

    #region Public Functions
    public void LampEnqueue(LampLight lampLight)  //for LampLight to call it
    {
        lampQueue.Enqueue(lampLight);
        LampSetupper();
    }

    #endregion

}





