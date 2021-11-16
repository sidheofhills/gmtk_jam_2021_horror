using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalAudioManager : MonoBehaviour
{
    [SerializeField] private GameData gameData;
    [SerializeField] private AudioClips audioClips;
    private AudioSource localAudioSource;

    private void Start()
    {
        localAudioSource = GetComponent<AudioSource>();
    }


    private void MonsterSpawn()
    {
        AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.monsterSpawning, localAudioSource);
       
    }

    private void Attack()
    {
        AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.attack, localAudioSource);  //PREFAB runes OBJECT POOLING UNDER PLAYER OBJECT
        
    }

   


    private void OnEnable()
    {
        EventManager.StartListening(gameData.MonsterSpawn, MonsterSpawn);  //этот скрипт должен раотать неправильно
      
        EventManager.StartListening(gameData.Attack, Attack);
        

    }

    private void OnDisable()
    {
        EventManager.StopListening(gameData.MonsterSpawn, MonsterSpawn);
      
        EventManager.StopListening(gameData.Attack, Attack);
    }

}
