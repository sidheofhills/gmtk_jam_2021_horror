using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CreditsCutscene : MonoBehaviour // cutscene in gameWin
{
    [SerializeField] GameData gameData;
    private PlayableDirector cutScenePlayableDirector;    
     
    private void Awake()
    {
        cutScenePlayableDirector = GetComponent<PlayableDirector>(); 
    }


    // i really wanted the credits' animation in win scene to keep up with music
    private void PlayCredits()
    {
        cutScenePlayableDirector.Play();
    }


    private void OnEnable()
    {        
        EventManager.StartListening(gameData.CreditsTime, PlayCredits);
    }
    private void OnDisable()
    {        
        EventManager.StopListening(gameData.CreditsTime, PlayCredits);
    }
}
