using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/Audio/AudioClips", fileName = "newAudioClips")]
public class AudioClips : ScriptableObject
{
    //collection of almost all music and sfx i used in the game.
    // bg music in different scenes is not in the list, as well as normalm not flickering lightBulbs sounds
    

    [Header("BG Music")]
    
    public AudioClip[] bgMusic;
    

    

    [Header("Environment Music")]
    
    public AudioClip[] lightBulbsFlickering;
    public AudioClip[] thunder;
    public AudioClip[] knocking;
    public AudioClip[] lightSwitcher;
    



    [Header("Transitions")]
   
    public AudioClip[] transitionToMainLevel;
    public AudioClip[] transitionToExit;



    [Header("SFX")]
    
    public AudioClip[] monsterSpawning;
    public AudioClip[] monsterDying;
    public AudioClip[] attack;



    [Header("UI sounds")]
    public AudioClip[] buttonHighlighted;
    public AudioClip[] buttonClicked;
    public AudioClip[] message;



    [Header("Volumes")]
    public int musicVolume;
    public int sfxVolumne;
}
