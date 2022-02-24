using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[CreateAssetMenu(fileName = "newGameData", menuName = "Data/Game Data/Base")]

public class GameData : ScriptableObject
{
    [Header("Main Variables")]
    
    public float enemyNumKilled = 0;
    public bool startSpawn = false;
    public bool cutSceneDone = false;
    public GameObject selectedObject;
    public Vector3 weaponSpawnTransform;
    public float speed = 1;
    public float scaleMult = 1;
    public float startingScale;
    public float deathScale = 0.8f;
    public float boxColliderExpandValue = 1.5f;

    [HideInInspector] public bool firstStageOn;
    [HideInInspector] public bool secondStageOn;
    [HideInInspector] public bool thirdStageOn;

    #region Events
    
    [HideInInspector] public string GameOver { get;  } = "gameOverEvent";        
    [HideInInspector] public string GameWin { get; } = "gameWinEvent";    
    [HideInInspector] public string GameStart { get; } = "gameLevelEvent";    
    [HideInInspector] public string GameLeave { get; } = "gameLeaveEvent";    
    [HideInInspector] public string MainMenu { get; } = "gameMenuEvent";     
    [HideInInspector] public string Transition { get; } = "transitionEvent";     
    [HideInInspector] public string Skip { get; } = "gameSkipEvent";     
    [HideInInspector] public string MonstersSpawn { get; } = "monstersSpawnEvent";    
    [HideInInspector] public string Attack { get; } = "attackEvent";     
    [HideInInspector] public string MonsterDeath { get; } = "monsterDeathEvent";    
    [HideInInspector] public string OnMinute { get; } = "onMinuteEvent";    
    [HideInInspector] public string OnHour  { get; } = "onHourEvent";     
    [HideInInspector] public string OnTwoMinutes { get; } = "onTwoMinutesEvent";
    [HideInInspector] public string OnLampJobRun { get; } = "onLampJobRunEvent";

    #endregion




}
