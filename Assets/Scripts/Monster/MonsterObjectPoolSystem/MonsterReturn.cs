using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MonsterReturn : MonoBehaviour
{
    private MonsterObjectPool_Advanced objectPool;
    [SerializeField] private GameData gameData;


    void Start()
    {
        objectPool = FindObjectOfType<MonsterObjectPool_Advanced>();
    }



    private void OnDisable()  //??????????? ??? ?????, ? ????? ???????????? ? ???
    {
        if (objectPool != null)
        {
            objectPool.ReturnGameObject(this.gameObject);
            
        }
        
    }


}
