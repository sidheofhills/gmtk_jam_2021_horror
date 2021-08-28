using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollector : MonoBehaviour
{
    /*
    public AudioTrack[] tracks;

    public Hashtable trackTable;
    public Hashtable levelTable;

    [System.Serializable]    
    public class AudioObject
    {
        public AudioTitile audioTitle;
        public AudioClip[] clip;
    }

    [System.Serializable]
    public class AudioTrack
    {
        public AudioSource source;
        public AudioObject[] audio;
    }

    

    private void Awake()
    {
        
        trackTable = new Hashtable();
        //levelTable = new Hashtable();
        GenerateTrackTable();
        //GenerateLevelTable();
    }

    private void GenerateTrackTable()
    {
        foreach (AudioTrack track in tracks)
        {
            foreach(AudioObject obj in track.audio)
            {
                if(!trackTable.ContainsKey(obj.audioTitle))
                {
                    trackTable.Add(obj.audioTitle, track);
                }
                else
                {
                    Debug.Log("threre already is [" + obj.audioTitle + "] with that name");
                }
            }
        }
    }

    /*private void GenerateLevelTable()
    {
        throw new NotImplementedException();
    }*/

   /* AudioTrack track = AudioCollector.GetAudioTrack(_job.type); // track existence should be verified by now
    _track.source.clip = GetAudioClipFromAudioTrack(_job.type, _track);


    private AudioTrack GetAudioTrack(AudioType _type, string _job = "")
    {
        
    }

    private AudioClip GetAudioClipFromAudioTrack(AudioType _type, AudioTrack _track)
    {
        
    }
    */
}
