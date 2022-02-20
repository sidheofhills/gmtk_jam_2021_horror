using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class InputController : MonoBehaviour
{
    
    private int curSceneNumber;
    public GameData gameData;
    private SceneManager sceneManager;
    private void Start()
    {
        curSceneNumber = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        sceneManager = FindObjectOfType<SceneManager>();
        
    }

    private void Update()
    {
        // as there're just a few scenes and key inputs in my game, i left it be that cheap and dirty

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (curSceneNumber == 1) // main level
            {                
                EventManager.TriggerEvent(gameData.Skip);
            }
            else if (curSceneNumber == 2) // game over scene
            {               
                EventManager.TriggerEvent(gameData.GameStartOver);                
            }

            else if (curSceneNumber == 3 || curSceneNumber == 4) // game win and credits scenes
            {                
                EventManager.TriggerEvent(gameData.MainMenu);                
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            sceneManager.LeaveButtonClicked();
        }

        //cheatcode !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        else if (Input.GetKeyDown(KeyCode.AltGr))
        {
            EventManager.TriggerEvent(gameData.GameWin);
        }

        

    }

}
