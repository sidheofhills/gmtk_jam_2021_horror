using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameData gameData;

    private int i = 0;  //counter
    private Dictionary<int, string> redefinerDic = new Dictionary<int, string>();  // хотелось поэксперементировать со словарями
    
    
    [SerializeField] private float timer = 18f;
    private float runningTime;

    private void Start()
    {
        RedefinerDicSetUp();
        runningTime = timer;
    }

    private void RedefinerDicSetUp()  // i have only 3 phases and a really short game so I hardcoded it
    {
        redefinerDic.Add(0, gameData.FirstPhaseEnds);
        redefinerDic.Add(1, gameData.SecondPhaseEnds);
        redefinerDic.Add(2, gameData.ThirdPhaseEnds);
    }

    private void Update()
    {
        if(gameData.startSpawn)
        {
            runningTime -= Time.deltaTime;            
            if(runningTime <=0.0f)
            {
                runningTime = timer;
                OnPhaseEnds();
            }            
        }
    }

    private void OnPhaseEnds()  // хотелось поэксперементировать со словарями
    {        
        if (i < redefinerDic.Count)
        {
            EventManager.TriggerEvent(redefinerDic[i]);
            i++;
        }
    }

}

