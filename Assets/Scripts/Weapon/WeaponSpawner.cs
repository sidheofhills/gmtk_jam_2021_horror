using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(WeaponObjectPool_Simple))]
public class WeaponSpawner : MonoBehaviour
{
    private WeaponObjectPool_Simple objectPool;

    public GameData gameData;
   
    // Start is called before the first frame update
    void Start()
    {
        objectPool = GetComponent<WeaponObjectPool_Simple>();
        
        // in scriptable objects data is not updating with exiting a game 
        // so it needs to be done manually
        gameData.weaponSpawnTransform = new Vector3(0, 0, 0);

    }


    public void SpawnFromThisPoint(Vector3 position, Vector3 scale)
    {
        GameObject newObject = objectPool.GetObject(); 
        newObject.transform.position = position;
        newObject.transform.localScale = scale;

        EventManager.TriggerEvent(gameData.MonsterDeath);



        //play spawn animation
    }
  


   
}
