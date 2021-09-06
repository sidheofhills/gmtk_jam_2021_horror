using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalAudioManager : MonoBehaviour
{
    [SerializeField] private GameData gameData;
    [SerializeField] private AudioClips audioClips;
    [SerializeField] private AudioSource localAudioSource;
    private void Start()
    { 
        
    }

    private void MonsterSpawn()
    {
        AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.monsterSpawning, localAudioSource);
    }

    private void MonsterDeath()
    {
        AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.monsterDying, localAudioSource);
    }
    private void Attack()
    {
        AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.attack, localAudioSource);  //PREFAB GUNS OBJECT POOLING UNDER PLAYER OBJECT
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
