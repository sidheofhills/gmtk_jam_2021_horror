using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCreditsEvent : MonoBehaviour  // for game win credits 
{
    [SerializeField] GameData gameData;
    [SerializeField] float timer = 11f;
    private AudioSource audioSource;
    private void Start()
    {
        StartCoroutine(Trigger());
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.Play();
    }
    private IEnumerator Trigger()
    {
        // i really wanted the credits' animation in win scene to keep up with music
        yield return new WaitForSeconds(timer);
        EventManager.TriggerEvent(gameData.CreditsTime);
    }
}
