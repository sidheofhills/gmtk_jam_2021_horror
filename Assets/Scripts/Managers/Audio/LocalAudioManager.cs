using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalAudioManager : MonoBehaviour
{
    [SerializeField] private GameData gameData;
    [SerializeField] private AudioClips audioClips;
    [SerializeField] private AudioSource localAudioSource;
    

    private enum LocalStates
    {
        None,
        MonsterSpawn,
        MonsterDeath,
        Attack,
    }

    private LocalStates currentState;
    private void Start()
    {
        currentState = LocalStates.None;
        
    }

    private void MonsterSpawn()
    {
        currentState = LocalStates.MonsterSpawn;
    }

    private void MonsterDeath()
    {
        currentState = LocalStates.MonsterDeath;
    }
    private void Attack()
    {
        currentState = LocalStates.Attack;
    }

    private void Update()
    {
        
        LocalAudioPlayer(currentState);
        
    }
    private void LocalAudioPlayer(LocalStates _localState)
    {
        switch(_localState)
        {
            case LocalStates.MonsterSpawn:
                {
                    AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.monsterSpawning, localAudioSource);
                    Debug.Log("monster spawn in local audio manager" + audioClips.monsterSpawning[0] + " " + localAudioSource.name);
                    break;
                }
            case LocalStates.MonsterDeath:
                {
                    AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.monsterDying, localAudioSource);
                    break;
                }
            case LocalStates.Attack:
                {
                    AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.attack, localAudioSource);  //PREFAB GUNS OBJECT POOLING UNDER PLAYER OBJECT
                    break;
                }
            case LocalStates.None:
                {
                    break;
                }

        }
        _localState = LocalStates.None;
        
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
