using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(AudioSource))]
public class LampLight : MonoBehaviour
{
    
    [FormerlySerializedAs("isLeftLamp")] [SerializeField] private bool leftLamp;
    [SerializeField] private GameData gameData;
    [SerializeField] private AudioClips audioClips;
    [SerializeField] private AudioClip[] lightBulbsNormal;  //unique for each lamp
    public bool LeftLamp => leftLamp;
    public int LightOn { get; set; }
    public float TimeDuration { get; set; }

    public bool Flickering { get; set; }
    
    private LightManager lightManager;
    private AudioSource lightAudioSource;
    private SpriteRenderer[] spriteRenderer;
    private LightsAudioSpectrum audioSpectrum;
    public float testAlpha;

    private void Awake()
    {
        lightManager = FindObjectOfType<LightManager>();

        lightAudioSource = GetComponent<AudioSource>();
        if (lightAudioSource)
        {
            Debug.Log(lightAudioSource.name + this.gameObject.name);
        }
        else
        {
            Debug.Log("No game object called lightAudioSource found in " + this.gameObject.name);
        }

        audioSpectrum = GetComponent<LightsAudioSpectrum>();
        spriteRenderer = GetComponentsInChildren<SpriteRenderer>();

        SpritesAlphaSwitcher(1);


    }

    private void Update()
    {
        
        if (Flickering && LightOn==1)
        {
            FlickeringWithAudio();
        }
    }

    public IEnumerator RunJob()
    {
        //Debug.Log(this.gameObject.name + " lightOn is " +LightOn);
        SpritesAlphaSwitcher(LightOn);

        PlayLightSound(LightOn);

        //Debug.Log(this.gameObject.name + " starting to wait");
        yield return new WaitForSeconds(TimeDuration);
        //Debug.Log(this.gameObject.name + " end waiting");

        PlayLightSound(1-LightOn);

        SpritesAlphaSwitcher(1-LightOn);
        //Debug.Log(this.gameObject.name + " switched lights");

        lightManager.LampEnqueue(this);
        //Debug.Log(this.gameObject.name + " enqueued");


        
    }

    

    private void PlayLightSound(int value)
    {
        

        if (value==1)
        {
            //Debug.Log(this.gameObject.name + " setting music for");
            //Debug.Log(lightAudioSource + " setting music to");
            if (Flickering)
            {
                AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.lightBulbsFlickering, lightAudioSource);
            }
            else
            {
                AudioPlayer.audioPlayerInstance.PlayAudio(lightBulbsNormal, lightAudioSource);
            }

            
        }
        else if (lightAudioSource.isPlaying)
        {
            //Debug.Log(this.gameObject.name + " stopping music for");
            //Debug.Log(lightAudioSource + " stopping music to");
            if (Flickering)
            {
                AudioPlayer.audioPlayerInstance.StopAudio(audioClips.lightBulbsFlickering, lightAudioSource);
            }
            else
            {
                AudioPlayer.audioPlayerInstance.StopAudio(lightBulbsNormal, lightAudioSource);
            }
            
        }
        else Debug.Log(this.gameObject.name + " music - pass");

        
    }

    private void SpritesAlphaSwitcher(int value)  //switches light/shadow on and off
    {
        
        spriteRenderer[0].color = new Vector4(spriteRenderer[0].color.r, spriteRenderer[0].color.g, spriteRenderer[0].color.b, value);
        spriteRenderer[1].color = new Vector4(spriteRenderer[1].color.r, spriteRenderer[1].color.g, spriteRenderer[1].color.b, value);
        spriteRenderer[2].color = new Vector4(spriteRenderer[2].color.r, spriteRenderer[2].color.g, spriteRenderer[2].color.b, value);
        spriteRenderer[3].color = new Vector4(spriteRenderer[3].color.r, spriteRenderer[3].color.g, spriteRenderer[3].color.b, 1-value);
    }

    private void FlickeringWithAudio()
    {
        
        spriteRenderer[0].color = new Vector4(spriteRenderer[0].color.r, spriteRenderer[0].color.g, spriteRenderer[0].color.b, audioSpectrum.FlickeringValue);
        spriteRenderer[1].color = new Vector4(spriteRenderer[1].color.r, spriteRenderer[1].color.g, spriteRenderer[1].color.b, audioSpectrum.FlickeringValue);
        spriteRenderer[2].color = new Vector4(spriteRenderer[2].color.r, spriteRenderer[2].color.g, spriteRenderer[2].color.b, audioSpectrum.FlickeringValue);
        spriteRenderer[3].color = new Vector4(spriteRenderer[3].color.r, spriteRenderer[3].color.g, spriteRenderer[3].color.b, 1 -audioSpectrum.FlickeringValue);
    }

}
