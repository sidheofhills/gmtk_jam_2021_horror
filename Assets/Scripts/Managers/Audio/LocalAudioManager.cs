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
        //Debug.Log("monster spawn in local audio manager" + audioClips.monsterSpawning[0] + " " + localAudioSource.name);
    }

    /*private void MonsterDeath()
    {
        AudioPlayer.audioPlayerInstance.StopAudio(audioClips.monsterSpawning, localAudioSource);
        AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.monsterDying, localAudioSource);
    }*/
    private void Attack()
    {
        AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.attack, localAudioSource);  //PREFAB runes OBJECT POOLING UNDER PLAYER OBJECT
        AudioPlayer.audioPlayerInstance.StopAudio(audioClips.monsterSpawning, localAudioSource);  //for it to mix a bit
    }

   


    private void OnEnable()
    {
        EventManager.StartListening(gameData.MonsterSpawn, MonsterSpawn);
        //EventManager.StartListening(gameData.MonsterDeath, MonsterDeath);
        EventManager.StartListening(gameData.Attack, Attack);
        

    }

    private void OnDisable()
    {
        EventManager.StopListening(gameData.MonsterSpawn, MonsterSpawn);
        //EventManager.StopListening(gameData.MonsterDeath, MonsterDeath);
        EventManager.StopListening(gameData.Attack, Attack);
    }

}
