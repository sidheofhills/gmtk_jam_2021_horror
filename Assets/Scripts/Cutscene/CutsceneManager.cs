using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneManager : MonoBehaviour
{
    private PlayableDirector cutScenePlayableDirector;
    public GameData gameData;
    private void Awake()
    {
        cutScenePlayableDirector = GetComponent<PlayableDirector>();
        cutScenePlayableDirector.played += CutSceneDone;
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
        EventManager.TriggerEvent(gameData.MonstersSpawn);
    }


    private void OnEnable()
    {
        EventManager.StartListening(gameData.Skip, OnSkip);
    }
    private void OnDisable()
    {
        EventManager.StopListening(gameData.Skip, OnSkip);
    }


}
