using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMainLevelBg : MonoBehaviour
{
    public GameData gameData;
    [SerializeField] private AudioClips audioClips;
     private AudioPlayer audioPlayer;
    [SerializeField] private AudioSource bgAudioSource;
    
    [SerializeField] private AudioSource transAudioSource;
    private AudioSource[] allAudioSources;
    private int curSceneNumber;
    private void Awake()
    {
        audioPlayer = GetComponent<AudioPlayer>();
        curSceneNumber = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;        
    }

    // this script is responsible for playing bg audio in main level after monster spawn starts 
 

    public void OnMonsterSpawn()
    {
        audioPlayer.PlayAudio(audioClips.bgMusic, bgAudioSource, true);
    }


    // cleaner
    private void Dispose()
    {
        allAudioSources = FindObjectsOfType<AudioSource>();
        foreach(AudioSource source in allAudioSources)
        {
            if(source != transAudioSource && source.isPlaying)
            {                
                source.Stop();
                return;
            }
        }
    }


    private void OnEnable()
    {
        EventManager.StartListening(gameData.MonstersSpawn, OnMonsterSpawn);
    }
    private void OnDisable()
    {
        EventManager.StopListening(gameData.MonstersSpawn, OnMonsterSpawn);
        Dispose();

    }

    // setup for never made transition
    private void GameLeave()
    {
        audioPlayer.PlayAudio(audioClips.transitionToExit, transAudioSource, true);  //наверное, нужно это как-то получше обыграть - главное, чтобы игра выключилась после того, как музыка (и визуал) закончатся
    }

    private void GoToMainLevel()
    {
        audioPlayer.PlayAudio(audioClips.transitionToMainLevel, transAudioSource, true);
    }


}
