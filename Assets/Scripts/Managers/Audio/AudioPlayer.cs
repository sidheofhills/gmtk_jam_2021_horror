using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public static AudioPlayer audioPlayerInstance;  //singleton

    [SerializeField] private AudioClips audioClips;
    
    public bool debug = false;

    public static float audioVolume = 1.0f;

    
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

    #region Public Functions for AudioManager to use
    public void PlayAudio(AudioClip[] _audioClip, AudioSource _audioSource, bool _fade = false)
    {
        AudioJob(AudioAction.Start, _audioClip, _audioSource, _fade);
    }

    public void StopAudio(AudioClip[] _audioClip, AudioSource _audioSource, bool _fade = false)
    {
        AudioJob(AudioAction.Stop, _audioClip, _audioSource, _fade);
    }

    public void RestartAudio(AudioClip[] _audioClip, AudioSource _audioSource, bool _fade = false)
    {
        AudioJob(AudioAction.Restart, _audioClip, _audioSource, _fade);
    }


    private IEnumerator AudioJob(AudioAction _action, AudioClip[] _clip, AudioSource _source, bool _fade = false)
    { 
        float initialValue = 0.0f;
        float targetValue = audioVolume;
        AudioClip clip= ChooseRandomClip(_clip);
        _source.clip = clip;

        switch (_action)
        {
            case AudioAction.Start:
            {
                    _source.Play();
                    break;
            }
            case AudioAction.Stop:
                {
                    _source.Stop();
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
                initialValue = audioVolume;
                targetValue = 0.0f;
            }
            float volume;
            float timePassed = 0.0f;
            float lerpDuration = 1.0f;
            while (timePassed <= lerpDuration)
            {
                _source.volume = Mathf.Lerp(initialValue, targetValue, timePassed / lerpDuration);
                timePassed += Time.deltaTime;
                yield return null;

            }
            // if _timer was 0.9999 and Time.deltaTime was 0.01 we would not have reached the target
            // make sure the volume is set to the value we want
            _source.volume = targetValue;
        }
        

    }
    #endregion

    #region Private functions

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


    // RUN AUDIO JOB
    /*
    private IEnumerator RunAudioJob(AudioJob _job)

    {
        

        _track.source.clip = ChooseRandomClip(_audioClipArray);
        
        float _initialValue =  0.0f;
        float _targetValue  = audioVolume;
        
        switch (_job.action)
        {
            case AudioAction.Start:
                _track.source.Play();
                    break;

            case AudioAction.Stop when (!_job.fade):
                {
                    _track.source.Stop();
                }

                break;
            case AudioAction.Stop:
                 _initialValue = audioVolume; 
                 _targetValue = 0.0f;
                break;

            case AudioAction.Restart:
                _track.source.Stop();
                _track.source.Play();
                break;

        }
        if(_job.fade)
           {
                float timePassed = 0.0f;
                float lerpDuration = 1.0f;
            while(timePassed<=lerpDuration)
            {
                _track.source.volume = Mathf.Lerp(_initialValue, _targetValue, timePassed / lerpDuration);
                timePassed += Time.deltaTime;
                yield return null;

            }
            // if _timer was 0.9999 and Time.deltaTime was 0.01 we would not have reached the target
            // make sure the volume is set to the value we want
            _track.source.volume = _targetValue;

            if(_job.action == AudioAction.Stop)
            {
                _track.source.Stop();
            }

        }
        //jobTable.Remove(_job.title);
        Log("job removed. is [" + (_job.title) + "] playing?" + _track.source.isPlaying);
        
    }

    */


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





