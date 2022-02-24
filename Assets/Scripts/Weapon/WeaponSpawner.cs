using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    private WeaponObjectPool_Simple objectPool;

    public GameData gameData;
   
    // Start is called before the first frame update
    void Start()
    {
        objectPool = GetComponent<WeaponObjectPool_Simple>();
        if (objectPool)
        {
            Debug.Log(objectPool.name);
        }
        else
        {
            Debug.Log("No game object called ObjectPool_Advanced found");
        }
        

    }


    public void SpawnFromThisPoint(Vector3 position, Vector3 scale)
    {
        GameObject newObject = objectPool.GetObject(); 
        newObject.transform.position = position;
        newObject.transform.localScale = scale;              
        
            
        
        //play spawn animation
    }
  


   
}
