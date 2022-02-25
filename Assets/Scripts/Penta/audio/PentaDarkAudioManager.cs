using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PentaDarkAudioManager : MonoBehaviour
{
    [SerializeField] GameData gameData;
    [SerializeField] AudioClip[] onAppearingClip;
    [SerializeField] AudioClip[] onRemainingClip;
    private AudioSource audioSource;
    private AudioPlayer audioPlayer;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioPlayer = FindObjectOfType<AudioPlayer>();
    }
    private void OnMonsterSpawn()
    {
        if(audioSource.isPlaying)
        {
            audioPlayer.StopAudio(onAppearingClip, audioSource, true);
        }
        audioSource.loop = true;
        audioPlayer.PlayAudio(onRemainingClip, audioSource, true);
    }
    private void OnEnable()
    {
        if(!gameData.startSpawn)
        {            
            audioSource.loop = false;
            audioPlayer.PlayAudio(onAppearingClip, audioSource);                       
        }

        EventManager.StartListening(gameData.MonstersSpawn, OnMonsterSpawn);
    }

    private void OnDisable()
    {
        EventManager.StopListening(gameData.MonstersSpawn, OnMonsterSpawn);      

    }
}
