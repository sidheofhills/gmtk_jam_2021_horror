using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterKillCounter : MonoBehaviour
{
    public GameData gameData;
    

    private void Awake()
    {
        GameData.enemyNumKilled = 0;

    }

    private void KillCounter()
    {
        GameData.enemyNumKilled++;        
    }

    private void OnEnable()
    {
        EventManager.StartListening(gameData.MonsterDeath, KillCounter);
    }

    private void OnDisable()
    {
        EventManager.StopListening(gameData.MonsterDeath, KillCounter);
    }


}
