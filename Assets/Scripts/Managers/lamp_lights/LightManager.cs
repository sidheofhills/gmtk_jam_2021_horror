using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LightManager : MonoBehaviour
{
    /*[SerializeField]*/  LampLight[] initialLampList;
    private Queue<LampLight> lampQueue = new Queue<LampLight>();
    public GameData gameData;

    [SerializeField] private int maxTimeDuration;
    private int lampsCounter; // counting ones that are On
    private int lLampsCounter; //left 3
    private int rLampCounter;  // right 3
    private LampLight currentLampLight;


    private void Start()
    {
        lampsCounter = 0;
        lLampsCounter = 0;
        rLampCounter = 0;

        InitialEnqueue();
        LampSetupper();
    }

    private void LampSetupper() //is called at the start and then at the event calls
    {
        currentLampLight = lampQueue.Dequeue();
        //check whether there're more than 3 lights on and  more than 2 on left/right side
        if ((lampsCounter >= 3) || ((currentLampLight.LeftLamp && lLampsCounter >= 2) ||
                                    (!currentLampLight.LeftLamp && rLampCounter >= 2)))
        {
            currentLampLight.LightOn = false;
        }
        else
        {
            currentLampLight.LightOn = Mathf.FloorToInt(Random.value) == 1;
            if (currentLampLight.LightOn)
            {
                currentLampLight.TimeDuration = Random.Range(0, 2) * maxTimeDuration;
                currentLampLight.CurrentShader =
                    currentLampLight.ShadersToChooseFrom[Mathf.FloorToInt(Random.value)];
                currentLampLight.gameObject.SetActive(true);
            }

        }

    }

    void InitialEnqueue()
    {
        initialLampList = FindObjectsOfType<LampLight>();
        foreach (LampLight lamp in initialLampList)
        {
            lampQueue.Enqueue(lamp);
        }
    }


    public void LampEnqueue(LampLight lampLight)
    {
        lampQueue.Enqueue(lampLight);
        EventManager.TriggerEvent(gameData.OnLampEnqueue);
    }

    private void OnDisable()
    {
        EventManager.StartListening(gameData.OnLampEnqueue,LampSetupper);
    }

    private void OnEnable()
    {
        EventManager.StopListening(gameData.OnLampEnqueue,LampSetupper);
    }
}





