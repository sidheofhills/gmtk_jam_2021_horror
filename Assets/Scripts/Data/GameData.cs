using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[CreateAssetMenu(fileName = "newGameData", menuName = "Data/Game Data/Base")]

public class GameData : ScriptableObject
{
    // this one is a big, giant mistake that started as a place to collect all the changeable data
    // but then i've decided to protect myself from typos with hardcoded events
    // which is convenient because you can see all the events you have in a single place
    // but it became such a the nightmare to add a link to this data everytime i used the observer pattern
    // it breaks at least one PRISM principle for sure 

    [Header("Main Variables")]
    
    public static float enemyNumKilled = 0;
    [Space]
    public bool cutSceneDone = false;
    public bool startSpawn = false;

    [Space]
    public Vector3 weaponSpawnTransform;

    [Header("Monster variables")]
    [Tooltip("Monster's speed")] public float scaleMult = 1; 
    public float startingScale;
    public float warningScale = 0.5f;
    public float deathScale = 0.8f;
    


    
    #region Events
    
    [HideInInspector] public string GameOver { get;  } = "gameOverEvent";        
    [HideInInspector] public string GameWin { get; } = "gameWinEvent";    
    [HideInInspector] public string GameStartOver { get; } = "gameLevelEvent";    
    [HideInInspector] public string GameLeave { get; } = "gameLeaveEvent";    
    [HideInInspector] public string MainMenu { get; } = "gameMenuEvent";      
    [HideInInspector] public string Transition { get; } = "transitionEvent";       //not used 
    [HideInInspector] public string Skip { get; } = "gameSkipEvent";     

    [HideInInspector] public string MonstersSpawn { get; } = "monstersSpawnEvent";         
    [HideInInspector] public string MonsterDeath { get; } = "monsterDeathEvent";  
    
    [HideInInspector] public string OnCandlesGrpLit { get; } = "onCandlesGrpLitEvent";
    [HideInInspector] public string OnEachCandleLit { get; } = "onEachCandleLitEvent";

    [HideInInspector] public string OnWhitePentaDissapearing { get; } = "onWhitePentaDissapearingEvent";
    [HideInInspector] public string OnWhitePentaAppearing { get; } = "OnWhitePentAppearingEvent";
    [HideInInspector] public string OnDarkPentaAppearing { get; } = "onDarkPentAppearingEvent";
    [HideInInspector] public string OnDarkPentaDisappearing { get; } = "onDarkPentaDisappearingEvent";
        
    [HideInInspector] public string FirstPhaseEnds { get; } = "FirstPhaseEnds";  
    [HideInInspector] public string SecondPhaseEnds { get; } = "SecondPhaseEnds";
    [HideInInspector] public string ThirdPhaseEnds { get; } = "ThirdPhaseEnds";


    [HideInInspector] public string LeftGlassCracked { get; } = "LeftGlassCrackedEvent";
    [HideInInspector] public string RightGlassCracked { get; } = "RightGlassCrackedEvent";

    [HideInInspector] public string CreditsTime { get; } = "CreditsTimeEvent";



    #endregion




}
