using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
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
        // НАДО ПЕРЕДЕЛАТЬ НА ДЖЕНЕРИКИ ФУНЦИЮ ПРОИГРЫВАНИЯ ИЛИ КАК-ТО  СДЕЛАТЬ ТАК, ЧТОБЫ БЫЛА ПЕРЕГРУЗКА ИЛИ ЧТО-ЛИБО ЕЩЕ
    }

    private void Start()
    {
        //audioPlayer.PlayAudio(audioClips.bgMusic[curSceneNumber], bgAudioSource, true);
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



    public void OnKnock()
    {
        audioPlayer.PlayAudio(audioClips.bgMusic, bgAudioSource, true);
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

    private void OnEnable()
    {
        EventManager.StartListening(gameData.MonstersSpawn, OnKnock);
    }
    private void OnDisable()
    {
        EventManager.StopListening(gameData.MonstersSpawn, OnKnock);
        Dispose();

    }

}
