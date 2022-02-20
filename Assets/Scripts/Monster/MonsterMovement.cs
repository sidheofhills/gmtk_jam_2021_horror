using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MonsterMovement : MonoBehaviour // as it is a 2d game, i faked movement by simply scaling up monsters
{
    [SerializeField] private GameData gameData;
    private bool startMoving;

    private bool leftSide = false; //  for glass cracking events

    void Awake()  // because i need it to set up before onEnable
    {
        
        startMoving = false;
        
    }
    
    private void OnEnable()
    {
        transform.localScale = new Vector3(gameData.startingScale, gameData.startingScale, 1);
        
        startMoving = true;
        WhichSide();  /// ??????????????????????????????????????????????
    }

    private void WhichSide()
    {
        float currentXpos = transform.position.x;
        if (currentXpos < 0.0f) leftSide = true;
     }
        
    private void OnDisable()
    {        
        startMoving = false;
    }
    
    private void Update()
    {         
        if (startMoving)
        {
            Movement();
        }

        EventsTrigger();
    }

    private void Movement()
    {
        float newScaleComponents = (Time.deltaTime * gameData.scaleMult);
        transform.localScale += new Vector3(newScaleComponents, newScaleComponents,0);
    }

    private void EventsTrigger()
    {
        if(transform.localScale.x > gameData.warningScale && transform.localScale.x < gameData.deathScale)  // could be written better
        {
            if(leftSide)
            {                
                EventManager.TriggerEvent(gameData.LeftGlassCracked);
            }
            else
            {                
                EventManager.TriggerEvent(gameData.RightGlassCracked);
            }
        }

        // game over event 
        else if(transform.localScale.x>gameData.deathScale)
        {            
            EventManager.TriggerEvent(gameData.GameOver);
        }

    }
    


    
    

}

