using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneManager : MonoBehaviour  // cutscene in main level after the player pressed knock
{
    private PlayableDirector cutScenePlayableDirector;
    public GameData gameData;
    private void Start()
    {
        cutScenePlayableDirector = GetComponent<PlayableDirector>();        
        cutScenePlayableDirector.stopped += CutSceneDone;
        gameData.cutSceneDone = false;        
    }

    public void OnKnock()
    {
        cutScenePlayableDirector.Play();
    }

    private void OnSkip() 
    {
        cutScenePlayableDirector.Stop();
    }
    
    private void CutSceneDone(PlayableDirector cutScene)
    {
        gameData.cutSceneDone = true;
        EventManager.TriggerEvent(gameData.MonstersSpawn);
    }


    private void OnEnable()
    {
        EventManager.StartListening(gameData.Skip, OnSkip);
    }
    private void OnDisable()
    {
        cutScenePlayableDirector.stopped -= CutSceneDone;
        EventManager.StopListening(gameData.Skip, OnSkip);
    }


}
