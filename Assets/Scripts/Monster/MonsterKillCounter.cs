using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterKillCounter : MonoBehaviour
{
    public GameData gameData;
    

    private void Awake()
    {

        
    }

    private void KillCounter()
    {
        gameData.enemyNumKilled++;
    }

    private void OnEnable()
    {
        EventManager.StartListening(gameData.MonsterDeath, KillCounter);
    }

    private void OnDisable()
    {
        EventManager.StopListening(gameData.MonsterDeath, KillCounter);
    }

    public void ForceNumKillsNullify()
    {
        gameData.enemyNumKilled = 0;
    }

}
