using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAudioManager : MonoBehaviour
{
    [SerializeField] private GameData gameData;    
    [SerializeField] private AudioClips audioClips;
    private AudioSource weaponAudioSource;

    private void Awake()
    {
        weaponAudioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.monsterSpawning, weaponAudioSource);
    }
}
