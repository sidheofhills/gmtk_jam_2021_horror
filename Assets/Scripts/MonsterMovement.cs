using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MonsterMovement : MonoBehaviour
{
   
    [SerializeField] private GameData gameData;
    private bool startMoving;
    

    // Start is called before the first frame update
    void Awake()
    {
        
        startMoving = false;
        
    }
    
    private void OnEnable()
    {
        
        transform.localScale = new Vector3(gameData.startingScale, gameData.startingScale, 1);
        
        startMoving = true;
        
    }
 
    // Update is called once per frame
    void Update()
    {
       
        if (startMoving)
        {
            Movement();
        }
        

        // game over event 
        if(transform.localScale.x>gameData.deathScale)
        {
            
            EventManager.TriggerEvent(gameData.GameOver);
        }
    }

    
    private void Movement()
    {
        float newScaleComponents = (Time.deltaTime * gameData.scaleMult);
        transform.localScale += new Vector3(newScaleComponents, newScaleComponents,0);


    }


 
    private void OnDisable()
    {
        
        startMoving = false;

    }
    

}

