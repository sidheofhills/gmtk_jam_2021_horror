using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    private MonsterObjectPool_Advanced objectPool;

    //public for them to be taken elsewhere 
    [SerializeField] private GameObject weaponPefab;
    
    public GameData gameData;
    private bool attack;



    // Start is called before the first frame update
    void Start()
    {
        objectPool = FindObjectOfType<MonsterObjectPool_Advanced>();
        if (objectPool)
        {
            Debug.Log(objectPool.name);
        }
        else
        {
            Debug.Log("No game object called ObjectPool_Advanced found");
        }
        attack = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (KnockUI.HeKnocked)
        {
            if(attack)
            {
                SpawnFromThisPoint();
                attack = false;
                Debug.Log("2attack false");
            }
        }
    }
   


    public void SpawnFromThisPoint()
    {
        GameObject newObject = objectPool.GetObject(weaponPefab);
        
        //EventManager.TriggerEvent(gameData.Attack); // EVENT TRIGGER  attackEvent()

        newObject.transform.position = gameData.weaponSpawnTransform;

    }

    private void Attack()
    {
        attack = true;
        Debug.Log("1attack true");
    }


    #region Events Functions Enable/Disable
    private void OnEnable()
    {
        EventManager.StartListening(gameData.Attack, Attack);

    }


    private void OnDisable()
    {
        EventManager.StopListening(gameData.Attack, Attack);

    }
    #endregion
}
