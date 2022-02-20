using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MonsterReturn : MonoBehaviour
{
    private MonsterObjectPool_Advanced objectPool;
    public GameData gameData;


    void Start()
    {
        objectPool = FindObjectOfType<MonsterObjectPool_Advanced>();
    }



    private void OnDisable()  //выключаетс€ при клике, а потом возвращаетс€ в пул
    {
        if (objectPool != null)
        {
            objectPool.ReturnGameObject(this.gameObject);
            
            
        }
        
    }


}
