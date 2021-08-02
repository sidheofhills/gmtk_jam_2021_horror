using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[CreateAssetMenu(fileName = "newGameData", menuName = "Data/Game Data/Base")]

public class GameData : ScriptableObject
{
    [Header("Main Variables")]
    public float enemyNum = 0;
    public GameObject selectedObject;
    public float speed = 1;
    public float scaleMult = 1;
    public float startingScale;

    [HideInInspector] public bool firstStageOn;
    [HideInInspector] public bool secondStageOn;
    [HideInInspector] public bool thirdStageOn;


}
