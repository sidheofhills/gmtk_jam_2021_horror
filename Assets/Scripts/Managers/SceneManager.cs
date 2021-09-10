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
        gameData.weaponSpawnTransform = new Vector3(0,0,0);
        Debug.Log("awakeSceneMan" + gameData.enemyNum + gameData.selectedObject);
        onGameOverListener = new Action(OnGameOver);  //���������, ����� ��������� �������
        //sceneLoaderListener = new Action(SceneLoader);
        string test = gameData.GameWin;
        Debug.Log(test);
    }


    private void Update()
    {
        //test
        if(Input.GetKeyDown(KeyCode.M))
        {
            EventManager.TriggerEvent(gameData.MainMenu);
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            EventManager.TriggerEvent(gameData.GameStart);
        }
        //OnKeyboardInput();


    }
    


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

    private void OnEnable()
    {
        EventManager.StartListening(gameData.GameOver, onGameOverListener);
        EventManager.StartListening(gameData.MainMenu, renameToMainMenu);
        EventManager.StartListening(gameData.GameStart, renameToMainLevel);
        EventManager.StartListening(gameData.GameWin, renameToGameWinScene);
        //EventManager.StartListening(gameData.Skip, SkipStart);

    }

    private void OnDisable()
    {
        EventManager.StopListening(gameData.GameOver, onGameOverListener);
        EventManager.StopListening(gameData.MainMenu, renameToMainMenu);
        EventManager.StopListening(gameData.GameStart, renameToMainLevel);
        EventManager.StopListening(gameData.GameWin, renameToGameWinScene);
        //EventManager.StopListening(gameData.Skip, SkipStart);
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
