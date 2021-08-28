using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public GameData gameData;
    [SerializeField] private AudioPlayer audioPlayer;

   
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            audioPlayer.PlayAudio(AudioTitle.mainLevelMusic, true);
        if (Input.GetKeyDown(KeyCode.T))
            audioPlayer.StopAudio(AudioTitle.mainLevelMusic, true);
        if (Input.GetKeyDown(KeyCode.Y))
            audioPlayer.PlayAudio(AudioTitle.knocking);
        if (Input.GetKeyDown(KeyCode.U))
            audioPlayer.RestartAudio(AudioTitle.mainLevelMusic);
        if (Input.GetKeyDown(KeyCode.I))
            audioPlayer.PlayAudio(AudioTitle.lightBulbsFlickering);
            //audioPlayer.PlayAudio(AudioTitle.transitionToExit);
    }


    /// <summary>
    /// Monster Spawns, Deaths and Players Clicks are on their own prefabs and scripts in LocalAudioManager scripts
    /// this script is responsible for bg, transitions and the start of the game with thunders and knocking
    /// </summary>
    private void GameLeave()
    {

    }

    private void GoToMainLevel()
    {

    }

    private void GameStart()
    {
        
    }

    private void SkipStart()
    {

    }

    private void Playing()
    {
           
    }

    private void GameWin()
    {

    }

    private void GameOver()
    {

    }

    private void MainMenu()
    {

    }
    private void OnEnable()
    {
        EventManager.StartListening(gameData.GameOver, GameOver);
        EventManager.StartListening(gameData.MainMenu, MainMenu);
        EventManager.StartListening(gameData.GameStart, GameStart);  //ny
        EventManager.StartListening(gameData.GameWin, GameWin);
        EventManager.StartListening(gameData.Skip, SkipStart);  //ny

    }

    private void OnDisable()
    {
        EventManager.StopListening(gameData.GameOver, GameOver);
        EventManager.StopListening(gameData.MainMenu, MainMenu);
        EventManager.StopListening(gameData.GameStart, GameStart);
        EventManager.StopListening(gameData.GameWin, GameWin);
        EventManager.StopListening(gameData.Skip, SkipStart);
    }

}
