using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public GameData gameData;
    [SerializeField] private AudioClips audioClips;
    [SerializeField] private AudioPlayer audioPlayer;
    [SerializeField] private AudioSource bgAudioSource;
    [SerializeField] private AudioSource envAudioSource;
    [SerializeField] private AudioSource transAudioSource;
    private AudioSource[] allAudioSources;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            audioPlayer.PlayAudio(audioClips.mainLevelMusic, bgAudioSource, true);
        if (Input.GetKeyDown(KeyCode.T))
            audioPlayer.StopAudio(audioClips.mainLevelMusic, bgAudioSource, true);
        if (Input.GetKeyDown(KeyCode.Y))
            audioPlayer.PlayAudio(audioClips.knocking, envAudioSource);
        if (Input.GetKeyDown(KeyCode.U))
            audioPlayer.RestartAudio(audioClips.mainLevelMusic, bgAudioSource);
        if (Input.GetKeyDown(KeyCode.I))
            audioPlayer.PlayAudio(audioClips.lightBulbsFlickering, envAudioSource);
            //audioPlayer.PlayAudio(AudioTitle.transitionToExit);
    }

 

    /// <summary>
    /// Monster Spawns, Deaths and Players Clicks are on their own prefabs and scripts in LocalAudioManager scripts
    /// this script is responsible for bg, transitions and the start of the game with thunders and knocking
    /// </summary>
    private void GameLeave()
    {
        audioPlayer.PlayAudio(audioClips.transitionToExit, transAudioSource, true);  //наверное, нужно это как-то получше обыграть - главное, чтобы игра выключилась после того, как музыка (и визуал) закончатся
    }

    private void GoToMainLevel()
    {
        audioPlayer.PlayAudio(audioClips.transitionToMainLevel, transAudioSource, true);
    }

    private void GameStart()
    {
        
    }

    private void SkipStart()  
    {
        
        audioPlayer.StopAudio(CurrentClipPrep(envAudioSource.clip), envAudioSource, true);
        Playing();
    }

    private void Playing()
    {
        audioPlayer.PlayAudio(audioClips.mainLevelMusic, bgAudioSource, true);
    }

    private void GameWin()
    {
        audioPlayer.PlayAudio(audioClips.gameWinMenuMusic, bgAudioSource, true);
    }

    private void GameOver()
    {
        audioPlayer.PlayAudio(audioClips.gameOverMenuMusic, bgAudioSource, true);
    }

    private void MainMenu()
    {
        audioPlayer.PlayAudio(audioClips.mainLevelMusic, bgAudioSource, true);
    }
    private void OnEnable()
    {
        EventManager.StartListening(gameData.GameOver, GameOver);
        EventManager.StartListening(gameData.MainMenu, MainMenu);
        EventManager.StartListening(gameData.GameStart, GameStart);  //';;;;;;;;;;;;;; n/ny
        EventManager.StartListening(gameData.GameWin, GameWin);
        EventManager.StartListening(gameData.Skip, SkipStart);  //ny

    }

    private void OnDisable()
    {
        EventManager.StopListening(gameData.GameOver, GameOver);
        EventManager.StopListening(gameData.MainMenu, MainMenu);
        EventManager.StopListening(gameData.GameStart, GameStart);
        EventManager.StopListening(gameData.GameWin, GameWin);
        EventManager.StopListening(gameData.Skip, SkipStart);
        Dispose();

    }
    private void Dispose()
    {
        allAudioSources = FindObjectsOfType<AudioSource>();
        foreach(AudioSource source in allAudioSources)
        {
            if(source != transAudioSource)
            {
                audioPlayer.StopAudio(CurrentClipPrep(source.clip), source, true);
            }
        }
    }

    private AudioClip[] CurrentClipPrep(AudioClip inputClip)
    {
        AudioClip[] arrayClip = null;
        arrayClip[0] = inputClip;
        return arrayClip;//???????????????????????????????????????
    }

}
