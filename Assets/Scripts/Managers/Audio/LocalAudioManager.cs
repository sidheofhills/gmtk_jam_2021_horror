using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalAudioManager : MonoBehaviour
{
    [SerializeField] private GameData gameData;
    

    private void MonsterSpawn()
    {
        AudioPlayer.audioPlayerInstance.PlayAudio(AudioTitle.monsterSpawning);
    }

    private void MonsterDeath()
    {
        AudioPlayer.audioPlayerInstance.PlayAudio(AudioTitle.monsterDying);
    }
    private void Attack()
    {
        AudioPlayer.audioPlayerInstance.PlayAudio(AudioTitle.attack);
    }




    private void OnEnable()
    {
        EventManager.StartListening(gameData.MonsterSpawn, MonsterSpawn);
        EventManager.StartListening(gameData.MonsterDeath, MonsterDeath);
        EventManager.StartListening(gameData.Attack, Attack);
        

    }

    private void OnDisable()
    {
        EventManager.StopListening(gameData.MonsterSpawn, MonsterSpawn);
        EventManager.StopListening(gameData.MonsterDeath, MonsterDeath);
        EventManager.StopListening(gameData.Attack, Attack);
    }

}
