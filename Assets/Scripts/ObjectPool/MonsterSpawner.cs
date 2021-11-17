using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class MonsterSpawner : MonoBehaviour
{

    [SerializeField] private float timeToSpawn = 5f;

    [SerializeField] private float spawnTimeReducer;

    [SerializeField] private bool leftSide;
    public bool LeftSide => leftSide;
    [SerializeField] float waitingOffsetTime;

    private float basicTimeSinceSpawn;
    private float specialTimeSinceSpawn;

    private MonsterObjectPool_Advanced objectPool;

    //public for them to be taken elsewhere 
    [SerializeField] private GameObject basicPefab;
    [SerializeField] private GameObject slipperyPefab;
    [SerializeField] private GameObject replicantPefab;

    [SerializeField] private int slipperyNumber;
    [SerializeField] private int replicantNumber;
    [SerializeField] private int poolStartSize = 4;

    public GameData gameData;

    

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
        objectPool.SettingUpPool(basicPefab, poolStartSize);
        objectPool.SettingUpPool(slipperyPefab, poolStartSize);
        objectPool.SettingUpPool(replicantPefab, poolStartSize);

    }

    // Update is called once per frame
    void Update()
    {
        if (KnockUI.HeKnocked)
        { 
            
            basicTimeSinceSpawn += Time.deltaTime;
            specialTimeSinceSpawn += Time.deltaTime;

            if (basicTimeSinceSpawn > timeToSpawn)
            {
                SpawnFromThisPoint(basicPefab);  //logic of spawning different enemies at diff time = maybe there's need in another script - monster randomizer                                                                                                                                          

                basicTimeSinceSpawn = 0f;
            }
            //Debug.Log(timeToSpawn);

            if (gameData.firstStageOn)
            {
                if (specialTimeSinceSpawn > timeToSpawn * 2)
                {
                    SpawnFromThisPoint(slipperyPefab);
                    specialTimeSinceSpawn = 0f;
                }
            }
            else if (gameData.secondStageOn)
            {
                if (specialTimeSinceSpawn > timeToSpawn * 4)
                {
                    SpawnFromThisPoint(replicantPefab);                                       
                    specialTimeSinceSpawn = 0f;
                }
            }
        }
    }
    private void SpawnSpeedUpdate()
    {
        if (timeToSpawn > 0.2)
        {
            timeToSpawn -= spawnTimeReducer;
            Debug.Log("reduced spawnTime, now it is" + timeToSpawn);
        }
        else return;  //тут враги вызываются с минимальным интервалом

    }


    public void SpawnFromThisPoint(GameObject prefab)
    {
        GameObject newObject = objectPool.GetObject(prefab);
        Vector2 newSpawnPoint = new Vector2(0, 0);
        

        gameData.enemyNum += 1;

        EventManager.TriggerEvent(gameData.MonsterSpawn); // EVENT TRIGGER  spawnEvent()

        //Debug.Log("spaawn and triggered" + gameData.MonsterSpawn);

        newSpawnPoint = this.transform.position + UnityEngine.Random.insideUnitSphere * 2;

        newObject.transform.position = newSpawnPoint;

        //return newObject;


    }




    #region Events Functions Enable/Disable
    private void OnEnable()
    {
        EventManager.StartListening(gameData.OnTwoMinutes, SpawnSpeedUpdate);

    }
    private void OnDisable()
    {
        EventManager.StopListening(gameData.OnTwoMinutes, SpawnSpeedUpdate);

    }
    #endregion
}


