using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneManager : MonoBehaviour
{
    public GameData gameData;
    private Action onGameOverListener;
    private Action sceneLoaderListener;

    private int sceneName;


    private void Awake()
    {
        gameData.enemyNum = 0;
        gameData.selectedObject = null;
        Debug.Log("awakeSceneMan" + gameData.enemyNum + gameData.selectedObject);
        onGameOverListener = new Action(OnGameOver);  //���������, ����� ��������� �������
        //sceneLoaderListener = new Action(SceneLoader);
    }

    private void Start()
    {


    }

    private void OnEnable()
    {
        EventManager.StartListening("gameOverEvent", onGameOverListener);
        EventManager.StartListening("gameMenuEvent", renameToMainMenu);
        EventManager.StartListening("gameLevelEvent", renameToMainLevel);
        EventManager.StartListening("gameWinEvent", renameToGameWinScene);

    }

    private void OnDisable()
    {
        EventManager.StopListening("gameOverEvent", onGameOverListener);
        EventManager.StopListening("gameMenuEvent", renameToMainMenu);
        EventManager.StopListening("gameLevelEvent", renameToMainLevel);
        EventManager.StopListening("gameWinEvent", renameToGameWinScene);
    }
    private void Update()
    {
        //test
        if(Input.GetKeyDown(KeyCode.M))
        {
            EventManager.TriggerEvent("gameMenuEvent");
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            EventManager.TriggerEvent("gameLevelEvent");
        }
        //OnKeyboardInput();


    }
    /*public void OnKeyboardInput()
    { 
    
    };*/

    /*private void OnLevelWasLoaded(int level)
    {
        if (level == 1)
        {
            gameData.enemyNum = 0;
            gameData.selectedObject = null;
            Debug.Log("onLvlWasLoaded" + gameData.enemyNum + gameData.selectedObject);
        }
    }*/

    /*private void LoadScene()
    {
        sce
    }*/


    // ����� �� �������� �� ��������� ���
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
       Debug.Log("game over");
        sceneName = 2;  //game over menu index
        SceneLoader(sceneName);

    }
    private void renameToGameWinScene()
    {
        Debug.Log("you win");
        sceneName = 3;  //game over menu index
        SceneLoader(sceneName);
    }

    private void SceneLoader(int sceneName)
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);   // ��� ����� - ������� ������, �������� ��� ������� ���� ����. ������������ ���������? ������������ ���������� string sceneName � ������� ��� ��������� � ����������� �� ��������

        sceneName = -1;
    }


    #region Buttons Pressed
    public void PlayButtonClicked()
    {
        // ������� �������� ����� ����, ��� ������ ����� ���� ��� ��� (2��) 
        renameToMainLevel();
    }

    public void LeaveButtonClicked()
    {
        Debug.Log("TempMsg: you left");
    }
    #endregion

}
