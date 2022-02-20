using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllLightsOn : MonoBehaviour
{
    
    [SerializeField] GameData gameData;
    private LampLight[] lampStorage;

    private void Start()
    {
        lampStorage = this.gameObject.GetComponentsInChildren<LampLight>();
        foreach (LampLight lamp in lampStorage)
        {            
            lamp.BeforeKnock(); // turns on the lamps at the beginning
        }   
        
    }


}
