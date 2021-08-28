using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class GameOverTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.tag == "enemy")
        {

            EventManager.TriggerEvent("gameOverEvent");

            
        }
    }
}
