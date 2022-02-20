using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public static AudioPlayer audioPlayerInstance;  //singleton

    [SerializeField] private AudioClips audioClips;
    
    public bool debug = false;

    public enum AudioAction
    {
        None,
        Start,
        Stop,
        Restart,
    }
       
    #region Unity Functions and functions that called

    private void Awake()
    {
        if(!audioPlayerInstance)
        {
            audioPlayerInstance = this;
            
        }               
    }
    
    #endregion

    #region Public Functions for external usage
    public void PlayAudio(AudioClip[] _audioClip, AudioSource _audioSource, bool _fade = false)
    {
        
        StartCoroutine(AudioJob(AudioAction.Start, _audioClip, _audioSource, _fade));
    }

    public void StopAudio(AudioClip[] _audioClip, AudioSource _audioSource, bool _fade = false)
    {
        StartCoroutine(AudioJob(AudioAction.Stop, _audioClip, _audioSource, _fade));
    }

    public void RestartAudio(AudioClip[] _audioClip, AudioSource _audioSource, bool _fade = false)
    {
        StartCoroutine(AudioJob(AudioAction.Restart, _audioClip, _audioSource, _fade));
    }
    #endregion

    

    #region Private functions
    
    private IEnumerator AudioJob(AudioAction _action, AudioClip[] _clip, AudioSource _source, bool _fade)
    {
         
        float initialValue = 0.0f;
        float targetValue = audioClips.musicVolume; 
        AudioClip clip= ChooseRandomClip(_clip);
        _source.clip = clip;
        

        switch (_action)
        {
            case AudioAction.Start:
            {
                    _source.Play();
                    Log("play " + _source.clip);
                    break;
            }
            case AudioAction.Stop:
                {
                    _source.Stop();
                    Log("stop " + _source.clip);
                    break;
                }

            case AudioAction.Restart:
                _source.Stop();
                _source.Play();                
                break;
        }
        if (_fade)
        {
            if(_action == AudioAction.Stop)
            {
                initialValue = audioClips.musicVolume;
                targetValue = 0.0f;
            }
            
            float timePassed = 0.0f;
            float lerpDuration = 1.5f;
            while (timePassed <= lerpDuration)
            {
                _source.volume = Mathf.Lerp(initialValue, targetValue, timePassed / lerpDuration);
                timePassed += Time.deltaTime;
                yield return null;

            }
            // if _timer was 0.9999 and Time.deltaTime was 0.01 we would not have reached the target
            // so this is to make sure the volume is set to the value we want
            _source.volume = targetValue;
        }      
    }

    // i have scriptable object AudioClipS that stores almost all sfx I use in this game
    //  and sometimes i need different amount of tracks to choose from - like flickering sounds not to be too repetitive
    // I had to make the parameter into array to make it fit to all of the cases
    // so when the clip is a single object, I use this one as a crutch
    private AudioClip ChooseRandomClip(AudioClip[] _audioClipArray)
    {
        
        if (_audioClipArray.Length <= 1)
        {
            return (AudioClip)_audioClipArray[0];
        }
        else
        {
            int randomValue = UnityEngine.Random.Range(0, _audioClipArray.Length);
            Log("trying to get a random value:" + _audioClipArray.Length+ "randomVal is "+ randomValue);
            return (AudioClip)_audioClipArray[randomValue];
        }
    }
    #endregion


    #region Helper(Log) Functions
    private void Log(string _msg)
    {
        if (!debug) return;
        Debug.Log("[Audio Controller]: " + _msg);
    }

    private void LogWarning(string _msg)
    {
        if (!debug) return;
        Debug.LogWarning("[Audio Controller]: " + _msg);
    }
    #endregion
}





