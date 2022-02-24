using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class InputController : MonoBehaviour
{
    
    private int curSceneNumber;
    public GameData gameData;
    private void Awake()
    {
        curSceneNumber = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        
        
    }

    private void Update()
    {
        //test
        

        if (curSceneNumber == 1)
        {
            if (Input.anyKeyDown)
            {
                Debug.Log("skipping timeline placeholder");
                EventManager.TriggerEvent(gameData.Skip);
            }
            
        }

        else if (curSceneNumber == 2)
        {
            EventManager.TriggerEvent(gameData.GameStart);
        }

    }

}
