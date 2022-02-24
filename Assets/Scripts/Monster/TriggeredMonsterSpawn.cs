using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredMonsterSpawn : MonoBehaviour
{
    public GameData gameData;

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
