using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsAudioManager : MonoBehaviour  //этот скрипт не нужен, tester
{
    
    [SerializeField] private GameData gameData;
    [SerializeField] private AudioClips audioClips;
    private AudioSource lightAudioSource;
    private LampLight thisLampLight;
    [SerializeField] private AudioClip[] lightBulbsNormal;  //unique for each lamp

    private void Start()
    {
        lightAudioSource = GetComponent<AudioSource>();
        thisLampLight = GetComponent<LampLight>();
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.R))
            AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.lightBulbsFlickering, lightAudioSource);
        if (Input.GetKeyDown(KeyCode.T))
            AudioPlayer.audioPlayerInstance.StopAudio(audioClips.lightBulbsFlickering, lightAudioSource);
        if (Input.GetKeyDown(KeyCode.Y))
            AudioPlayer.audioPlayerInstance.PlayAudio(lightBulbsNormal, lightAudioSource);
        if (Input.GetKeyDown(KeyCode.U))
            AudioPlayer.audioPlayerInstance.StopAudio(lightBulbsNormal, lightAudioSource);
        
    }


}




