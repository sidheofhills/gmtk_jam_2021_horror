using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public static AudioPlayer audioPlayerInstance;
    public AudioTrack[] tracks;
    public bool debug = false;

    public static float audioVolume = 1.0f;

    private Hashtable trackTable;
    private Hashtable jobTable;
   // public Hashtable levelTable;

    [System.Serializable]
    public class AudioObject
    {
        public AudioTitle audioTitle;
        public AudioClip[] clip;
    }

    [System.Serializable]
    public class AudioTrack
    {
        public AudioSource source;
        public AudioObject[] audioObject;
    }

    public enum AudioAction
    {
        None,
        Start,
        Stop,
        Restart,
    }

    private class AudioJob
    {
        public AudioAction action;
        public AudioTitle title;
        public bool fade;
        public bool removeConflict;

        public AudioJob(AudioAction _action, AudioTitle _title, bool _fade, bool _removeConflict)
        {
            action = _action;
            title = _title;
            fade = _fade;
            removeConflict = _removeConflict;
        }
    }

    #region Unity Functions and functions that called

    private void Awake()
    {
        if(!audioPlayerInstance)
        {
            Configure();
        }
        
    }

    private void OnDisable()
    {
        Dispose();
    }

    private void Configure()
    {
        audioPlayerInstance = this;
        trackTable = new Hashtable();
        jobTable = new Hashtable();

        GenerateTrackTable();
        
    }
    private void Dispose()  // stops all jobs on disable
    {
        foreach(DictionaryEntry _entry in jobTable)
        {
            Coroutine _job = (Coroutine)_entry.Value;
            StopCoroutine(_job);
            
        }
    }

    private void GenerateTrackTable()
    {
        foreach (AudioTrack track in tracks)
        {
            foreach (AudioObject obj in track.audioObject)
            {
                if (!trackTable.ContainsKey(obj.audioTitle))
                {
                    trackTable.Add(obj.audioTitle, track);
                }
                else
                {
                   Log("threre already is [" + obj.audioTitle + "] with that name");
                }
            }
        }
    }


    #endregion

    #region Public Functions for AudioManager to use
    public void PlayAudio(AudioTitle _title, bool _fade = false, bool _removeConflict = false)
    {
        AddJob(new AudioJob(AudioAction.Start,_title, _fade, _removeConflict));
    }

    // local audio source needed
    public void StopAudio(AudioTitle _title, bool _fade = false, bool _removeConflict = false)
    {
        AddJob(new AudioJob(AudioAction.Stop, _title, _fade, _removeConflict));
    }

    public void RestartAudio(AudioTitle _title, bool _fade = false, bool _removeConflict = false)
    {
        AddJob(new AudioJob(AudioAction.Restart, _title, _fade, _removeConflict));
    }

    public void VolumeSetUp(int volume)
    {
        
    }
    #endregion

    #region Private functions
    // ADD / REMOVE FUNCS
    private void AddJob(AudioJob _job)
    {
        RemoveConflictingJobs(_job.title, _job.removeConflict);

        /*if(!_job.removeConflict)
        { _job.action = AudioAction.Restart;
            Log("changed job to restart" + _job.title);
        }*/
        jobTable.Add(_job.title, _job);
        Log("added job" + _job.title);
        Coroutine _runningJob = StartCoroutine(RunAudioJob(_job));
        jobTable.Remove(_job.title);
        Log("job count:" + jobTable.Count);


    }
    private void RemoveConflictingJobs(AudioTitle _title, bool _removeConflict)

    {
        // cancel the job if one exists with the same type
        if (jobTable.ContainsKey(_title))
        {
            RemoveJob(_title);
        }
        if (_removeConflict)
        {
            // cancel jobs that share the same audio track
            AudioTitle _conflictAudio = AudioTitle.none;
            AudioTrack audioTrackNeeded = GetAudioTrack(_title, "getting audio track needed");
            foreach (DictionaryEntry _entry in jobTable)
            {
                AudioTitle _audioTitle = (AudioTitle)_entry.Key;
                AudioTrack audioTrackInUse = GetAudioTrack(_audioTitle, "getting audio track in use");
                if (audioTrackInUse.source == audioTrackNeeded.source)
                {
                    _conflictAudio = _audioTitle;
                    Log("conflicted job detected" + _title);
                    break; //ищем, но не прерываем прям здесь
                }

            }
            if (_conflictAudio != AudioTitle.none)
            {
                RemoveJob(_conflictAudio);
            }
        }
        
    }
    private void RemoveJob(AudioTitle _title)
    {
        if(!jobTable.ContainsKey(_title))
        {
            Log("there's no job with such name to remove" + _title);
        }
        Coroutine _runningJob = (Coroutine)jobTable[_title];
        StopCoroutine(_runningJob);
        jobTable.Remove(_title);
    }

    // GET AUDIO FUNCS
    private AudioTrack GetAudioTrack(AudioTitle _title, string debugMsg = "")
    {
        if(!trackTable.ContainsKey(_title))
        {
            Log("there's no such track to get" + _title+debugMsg);
        }
        return (AudioTrack)trackTable[_title];
    }
    private AudioClip[] GetAudioClipFromAudioTrack(AudioTitle _title, AudioTrack _track)
    {
        foreach(AudioObject _obj in _track.audioObject)
        {
            if(_obj.audioTitle == _title)
            {
            return _obj.clip;

            }
        }
        return null;
    }
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
    private IEnumerator RunAudioJob(AudioJob _job)

    {
        AudioTrack _track = GetAudioTrack(_job.title); // track existence should be verified by now
        AudioClip[] _audioClipArray = GetAudioClipFromAudioTrack(_job.title, _track);

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





