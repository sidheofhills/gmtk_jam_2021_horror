using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(PentaWhiteAnimation))]
public class PentaWhiteAudioManager : MonoBehaviour
{
    [SerializeField] GameData gameData;

    private PentaWhiteAnimation pentaWhiteCutscene;
    private AudioSource audioSource;
    private AudioPlayer audioPlayer;

    [SerializeField] AudioClip[] onAppearingClip;
    [SerializeField] AudioClip[] onDisappearingClip;
    [SerializeField] AudioClip[] onRemainingClip;

    bool volumePulsingOn = false;
    float prevLerpedValue = 0.0f;
    float curLerpedValue = 1.0f;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioPlayer = FindObjectOfType<AudioPlayer>();
        pentaWhiteCutscene = GetComponent<PentaWhiteAnimation>();


    }
    private void Start()
    {
        audioSource.volume = 1f;
        audioSource.loop = true;
        audioPlayer.PlayAudio(onRemainingClip,audioSource,true);
    }
    private void OnWhitePentaDissapearing()
    {

        audioPlayer.StopAudio(onRemainingClip, audioSource, true);
        audioSource.loop = false;        
        audioPlayer.PlayAudio(onDisappearingClip, audioSource, true);
        volumePulsingOn = true;
        
        
    }

    private void Update()
    {
        if(volumePulsingOn)
        {
            VolumePulsing();
        }
    }
    private void VolumePulsing()
    {        
        if(curLerpedValue != prevLerpedValue)
        {
        prevLerpedValue = curLerpedValue;
        curLerpedValue = pentaWhiteCutscene.LerpedValue;
        audioSource.volume = Mathf.Lerp(0,1, curLerpedValue); 
        }
        else { volumePulsingOn = false; }
       
    }
    private void OnEnable()
    {
        EventManager.StartListening(gameData.OnWhitePentaDissapearing, OnWhitePentaDissapearing);        
    }

    private void OnDisable()
    {
        EventManager.StopListening(gameData.OnWhitePentaDissapearing, OnWhitePentaDissapearing);      

    }

}
