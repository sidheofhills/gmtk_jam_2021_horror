using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneManager : MonoBehaviour
{
    public GameData gameData;                                            
        
    private int sceneName;

    // Á‰ÂÒ¸ ·˚ Á‡ÏÂÌËÚ¸ Ì‡ ‰ÂÎÂ„‡ÚÓ‚ ‚ÒÂ
    private void renameToMainMenu()
    {
        sceneName = 0;  //main menu index
        SceneLoader(sceneName);
        
    }

    private void renameToMainLevel()
    {
        sceneName = 1;  //main level index
        SceneLoader(sceneName);
        
    }

    private void OnGameOver()

    {
        sceneName = 2;  //game over menu index
        SceneLoader(sceneName);
        

    }
    private void renameToGameWinScene()
    {
        
        sceneName = 3;  //game over menu index
        SceneLoader(sceneName);
        
    }
       
    private void SceneLoader(int sceneIndex)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
        sceneName = -1;
    }

    #region Main Menu Buttons Clicked
    public void PlayButtonClicked()
    {
        // —ƒ≈À¿“‹ — –»ÃÃ≈– œŒ—À≈ “Œ√Œ,  ¿  œÀ›…≈– Õ¿∆¿À œÀ›… »À» À»¬ (2ÿ“) 
        renameToMainLevel();
    }

    public void LeaveButtonClicked()
    {
#if UNITY_WEBGL
        Application.OpenURL("https://sidheofhills.itch.io/exorciste-practice");
#elif UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }


    public void CreditsButtonClicked()
    {
        SceneLoader(4);

    }

    #endregion
    private void OnEnable()
    {
        EventManager.StartListening(gameData.GameOver, OnGameOver);
        EventManager.StartListening(gameData.MainMenu, renameToMainMenu);
        EventManager.StartListening(gameData.GameStartOver, renameToMainLevel);
        EventManager.StartListening(gameData.GameWin, renameToGameWinScene);
        
    }

    private void OnDisable()
    {
        EventManager.StopListening(gameData.GameOver, OnGameOver);
        EventManager.StopListening(gameData.MainMenu, renameToMainMenu);
        EventManager.StopListening(gameData.GameStartOver, renameToMainLevel);
        EventManager.StopListening(gameData.GameWin, renameToGameWinScene);
        
    }


}
