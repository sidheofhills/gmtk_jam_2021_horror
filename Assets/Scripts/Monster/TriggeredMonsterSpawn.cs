using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredMonsterSpawn : MonoBehaviour
{
    // some of the methods in the game require to be in update mode, so gameData.startSpawn is a crutch to hold spawn before player knocks
    public GameData gameData;

    private void Awake()
    {
        gameData.startSpawn = false;
    }
    private void StartMonsterSpawn()
    {
        
        gameData.startSpawn = true;
    }

    private void OnEnable()
    {
        EventManager.StartListening(gameData.MonstersSpawn, StartMonsterSpawn);
    }
    private void OnDisable()
    {
        EventManager.StopListening(gameData.MonstersSpawn, StartMonsterSpawn);
    }
}
