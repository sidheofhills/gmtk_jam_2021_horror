using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(AudioSource))]
public class LampLight : MonoBehaviour
{
    
    [FormerlySerializedAs("isLeftLamp")] [SerializeField] private bool leftLamp; 
    public bool LeftLamp => leftLamp; // for monsters fade in and out

    [SerializeField] private bool manualLampSwitchOff; // for cutscene

    [SerializeField] private AudioClip[] lightBulbsNormal;  //unique for each lamp
    [SerializeField] private GameData gameData;
    [SerializeField] private AudioClips audioClips;
    private LightManager lightManager;
    private AudioSource lightAudioSource;
    private LightsAudioSpectrum audioSpectrum;
    private SpriteRenderer[] spriteRenderer;

    // changeable parameters
    public int LightOn { get; set; }
    public float TimeDuration { get; set; }
    public bool Flickering { get; set; }
    
    

    private void Awake()
    {
        lightManager = FindObjectOfType<LightManager>();
        lightAudioSource = GetComponent<AudioSource>(); 
        audioSpectrum = GetComponent<LightsAudioSpectrum>();
        spriteRenderer = GetComponentsInChildren<SpriteRenderer>();               
    }

    private void Update()
    {        
        if (Flickering && LightOn==1)
        {
            FlickeringAudio();
        }

        if(manualLampSwitchOff && !gameData.cutSceneDone)  // for cutscene
        {
            SpritesAlphaSwitcher(0);
        }
    }

    private void SpritesAlphaSwitcher(int value)  //switches light/shadow on and off
    {
        // if i remember correctly, i couldn't get good results with only spriteRenderer[0].color.a = value
        // probably, because color is a struct?
        spriteRenderer[0].color = new Vector4(spriteRenderer[0].color.r, spriteRenderer[0].color.g, spriteRenderer[0].color.b, value);
        spriteRenderer[1].color = new Vector4(spriteRenderer[1].color.r, spriteRenderer[1].color.g, spriteRenderer[1].color.b, value);
        spriteRenderer[2].color = new Vector4(spriteRenderer[2].color.r, spriteRenderer[2].color.g, spriteRenderer[2].color.b, value);
        spriteRenderer[3].color = new Vector4(spriteRenderer[3].color.r, spriteRenderer[3].color.g, spriteRenderer[3].color.b, 1-value);
    }

    private void FlickeringAudio()
    {        
        spriteRenderer[0].color = new Vector4(spriteRenderer[0].color.r, spriteRenderer[0].color.g, spriteRenderer[0].color.b, audioSpectrum.FlickeringValue);
        spriteRenderer[1].color = new Vector4(spriteRenderer[1].color.r, spriteRenderer[1].color.g, spriteRenderer[1].color.b, audioSpectrum.FlickeringValue);
        spriteRenderer[2].color = new Vector4(spriteRenderer[2].color.r, spriteRenderer[2].color.g, spriteRenderer[2].color.b, audioSpectrum.FlickeringValue);
        spriteRenderer[3].color = new Vector4(spriteRenderer[3].color.r, spriteRenderer[3].color.g, spriteRenderer[3].color.b, 1 -audioSpectrum.FlickeringValue);
    }

    public void BeforeKnock() // i only needed them to occasionally flicker with lights all on
    {
        LightOn = 1;
        Flickering = UnityEngine.Random.Range(0, 6) % 2 == 0;
        SpritesAlphaSwitcher(LightOn);
        PlayLightSound(LightOn);        
    }

    // continuous cycle of lights turning on and off during the game. used only in LightManager
    public IEnumerator RunJob()
    {        
        SpritesAlphaSwitcher(LightOn);

        PlayLightSound(LightOn);

        yield return new WaitForSeconds(TimeDuration);
        
        PlayLightSound(1-LightOn);

        SpritesAlphaSwitcher(1-LightOn);        

        lightManager.LampEnqueue(this);                       
    }

    
    private void PlayLightSound(int value) // could be done better
    {      
        if (value==1)
        {            
            if (Flickering) AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.lightBulbsFlickering, lightAudioSource); 

            else   AudioPlayer.audioPlayerInstance.PlayAudio(lightBulbsNormal, lightAudioSource);             
        }

        else if (lightAudioSource.isPlaying)
        {
            if (Flickering) AudioPlayer.audioPlayerInstance.StopAudio(audioClips.lightBulbsFlickering, lightAudioSource);

            else    AudioPlayer.audioPlayerInstance.StopAudio(lightBulbsNormal, lightAudioSource);            
        }               
    }


}
