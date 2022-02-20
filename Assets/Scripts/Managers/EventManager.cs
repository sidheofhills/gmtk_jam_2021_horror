using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;



public class EventManager : MonoBehaviour
{
    //this event system is made with unity learn https://learn.unity.com/tutorial/create-a-simple-messaging-system-with-events#5cf5960fedbc2a281acd21fa
    // and i'm not fully understand some of the syntaxes yet

    private Dictionary<string, Action> eventDictionary; //библиотека ивентов

    private static EventManager eventManager;  //способ управлением данными - создавая класс приватно, его инстанс мы делаем публичным, задавая свои условия управлениями данными
    public static EventManager instanceEventManager // class constructor
    {
        get  
        {
            if (!eventManager)  //if we don't have an event manager we go and get it
            {
                eventManager = FindObjectOfType(typeof(EventManager))as EventManager; // note to self read more about typeof and as 

                if (!eventManager)
                {
                    Debug.Log("There needs to be an active Event Manager script on a GameObject in your scene");
                }
                else
                {
                    eventManager.DicInitializer();  //after you got it you have to initialize it. it's done only once
                }
            }
            return eventManager;
        }
    }
        
    private void DicInitializer()
    { 
        if(eventDictionary is null)
        {
            eventDictionary = new Dictionary<string, Action>();
        }
    }
    ///_____________________________________________________________________________________________
    public static void StartListening(string eventName, Action listener)
    {
               
        if (instanceEventManager.eventDictionary.ContainsKey(eventName))
        {
            instanceEventManager.eventDictionary[eventName] += listener; // add more events to the existing one            
        }
        
        else //when dictionary is fresh and new
        {                       
            instanceEventManager.eventDictionary.Add(eventName, listener);           
        }
    }

    public static void StopListening(string eventName, Action listener)
    {
        if (eventManager == null) return; //if we somehow destroyed the event manager at this stage and when we're doing some cleaning up
        if (instanceEventManager.eventDictionary.ContainsKey(eventName))
        {
            instanceEventManager.eventDictionary[eventName] -= listener; // substract more events from the existing one
                                                                         //update the dictionary
        }
    }


    public static void TriggerEvent(string eventName)
    {
        Action thisEvent = null;
        if (instanceEventManager.eventDictionary.TryGetValue(eventName, out thisEvent))
        {
            //Debug.Log("invoking " + eventName);
            thisEvent.Invoke();
        }
    }

    

}
