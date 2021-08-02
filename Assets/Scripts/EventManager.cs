using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;



public class EventManager : MonoBehaviour
{
    private Dictionary<string, Action> eventDictionary; //библиотека ивентов

    private static EventManager eventManager;  //способ управлением данными - создавая класс приватно, его инстанс мы делаем публичным, задавая свои условия управлениями данными
    public static EventManager instanceEventManager
    {
        get  
        {
            if (!eventManager)  //if we don't have an event manager we go and get it
            {
                eventManager = FindObjectOfType(typeof(EventManager))as EventManager;
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
        
    void DicInitializer()
    { 
        if(eventDictionary == null)
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
                                                                         //update the dictionary
            Debug.Log("subscribed" + eventName);
            }
        
        else //when dictionary is fresh and new
        {
                       
            instanceEventManager.eventDictionary.Add(eventName, listener);
            Debug.Log("subscribed new" + eventName);
        }
    }

    public static void StopListening(string eventName, Action listener)
    {
        if (eventManager == null) return; //if we somehow destroyed the event manager at this stage ad when we're doing some cleaning up
        if (instanceEventManager.eventDictionary.ContainsKey(eventName))
        {

            instanceEventManager.eventDictionary[eventName] -= listener; // substract more events from the existing one
                                                                         //update the dictionary
            Debug.Log("unsubscribed" + eventName);
        }
    }


    public static void TriggerEvent(string eventName)
    {
        Action thisEvent = null;
        if (instanceEventManager.eventDictionary.TryGetValue(eventName, out thisEvent))
        {
            thisEvent.Invoke();
        }
    }

    

}
