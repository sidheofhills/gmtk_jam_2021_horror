using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(AudioSource))]
public class ButtonSound : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField]private AudioClips audioClips;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void OnButtonClick()
    {
        
        audioSource.clip = audioClips.buttonClicked[0];
        audioSource.Play();
    }

    // Update is called once per frame
    public void OnButtonHighlighted()
    {
        
        audioSource.clip = audioClips.buttonHighlighted[Random.Range(0, audioClips.buttonHighlighted.Length)];
        audioSource.Play();
    }

    public void OnButtonFlickering()
    {
        
        audioSource.clip = audioClips.lightBulbsFlickering[9];
        audioSource.Play();
    }

    public void OnButtonStopFlickering()
    {        
        audioSource.Stop();
    }
}
