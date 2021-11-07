using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    //public static Action onMinuteEvent;
    //public static Action onTenMinuteEvent;
    //public static Action onHourEvent;
    public GameData gameData;

    public static int Minute { get; private set; }
    public static int Hour { get; private set; }

    [SerializeField] private float minuteToRealTimeRatio = 0.5f;
    private float clockTimer;  //local time iterator that counts down minuteToRealTimeRatio
    [SerializeField] float hangOnTimer;
    public float TimeLeftToHangOn { get; private set; }

    [SerializeField] private float firstStageTimer;
    [SerializeField] private float secondStageTimer;
    [SerializeField] private float thirdStageTimer;
    
    void Awake()
    {
        Minute = 2;
        Hour = 3; // можно поставить в преролле 23.59, стук,  а потом в полночь они вылезают. а можно оставить так
        clockTimer = minuteToRealTimeRatio;
        TimeLeftToHangOn = hangOnTimer;

        gameData.firstStageOn = false;
        gameData.secondStageOn = false;
        gameData.thirdStageOn = false;
    }

    void FixedUpdate()
    {
        if(KnockUI.HeKnocked)
        {
            TimeLeftToHangOn -= Time.deltaTime;
            if(TimeLeftToHangOn<=0)
            {
                EventManager.TriggerEvent(gameData.GameWin);  // 'they gonna get here in an hour!'  and make notifications like 30 min left, 15 min left, 10 min left
            }
        }
        clockTimer -= Time.deltaTime;
        if (clockTimer <= 0)
        {
            
            Minute++;  //+1
            EventManager.TriggerEvent(gameData.OnMinute);
            if (Minute >=60)
            {
                Hour++;    //+1
                Minute = 0;
                EventManager.TriggerEvent(gameData.OnHour);
            }
            else if (Minute%2==0 && KnockUI.HeKnocked)
            {
                EventManager.TriggerEvent(gameData.OnTwoMinutes);  // MAYBE TEN IS WAY TOo SLOW AND A MINUTE WILL DO
            }

            clockTimer = minuteToRealTimeRatio;
        }
        
        if (Minute >= firstStageTimer)  //minute is TMP better use handOnTimer 
        {
            gameData.firstStageOn = true;
            //if(Time.frameCount%24==0) Debug.Log("firstStageOn");

            if (Minute >= secondStageTimer)
            {
                gameData.secondStageOn = true;
                gameData.firstStageOn = false;
                //if (Time.frameCount % 24 == 0) Debug.Log("secondStageOn");

                if (Minute >= thirdStageTimer)
                {
                    gameData.thirdStageOn = true;
                    gameData.secondStageOn = false;
                    //if (Time.frameCount % 24 == 0) Debug.Log("thirdStageOn");
                }
            }

        }
    }

    
}

