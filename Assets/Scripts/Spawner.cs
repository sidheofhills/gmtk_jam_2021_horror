using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Spawner : MonoBehaviour
{

    [SerializeField] private float timeToSpawn = 5f;

    [SerializeField] private float spawnTimeReducer;
       
    private float basicTimeSinceSpawn;
    private float specialTimeSinceSpawn;

    private ObjectPool_Advanced objectPool;
    

    [SerializeField] int slipperyNumber;
    [SerializeField] int replicantNumber;

    public GameData gameData;

    

    // Start is called before the first frame update
    void Start()
    {
        objectPool = FindObjectOfType<ObjectPool_Advanced>();
        

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
                SpawnFromThisPoint(objectPool.basicPefab);  //logic of spawning different enemies at diff time = maybe there's need in another script - monster randomizer                                                                                                                                          

                basicTimeSinceSpawn = 0f;
            }
            //Debug.Log(timeToSpawn);

            if (gameData.firstStageOn)
            {
                if (specialTimeSinceSpawn > timeToSpawn * 2)
                {
                    SpawnFromThisPoint(objectPool.slipperyPefab);
                    specialTimeSinceSpawn = 0f;
                }
            }
            else if (gameData.secondStageOn)
            {
                if (specialTimeSinceSpawn > timeToSpawn * 4)
                {
                    SpawnFromThisPoint(objectPool.replicantPefab);                                       
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
        else return;  //��� ����� ���������� � ����������� ����������
        
    }


    public void SpawnFromThisPoint(GameObject prefab)
    {
                GameObject newObject = objectPool.GetObject(prefab);
                Vector2 newSpawnPoint = new Vector2(0, 0);

                gameData.enemyNum += 1;

                EventManager.TriggerEvent("spawnEvent"); // EVENT TRIGGER  spawnEvent()

                //Debug.Log("spaawn and triggered" + gameData.enemyNum);

                newSpawnPoint = this.transform.position + UnityEngine.Random.insideUnitSphere * 2;

                newObject.transform.position = newSpawnPoint;
                
        

    }
    
    


    #region Events Functions Enable/Disable
    private void OnEnable()
    {
        EventManager.StartListening("onTwoMinuteEvent", SpawnSpeedUpdate);
        
    }
    private void OnDisable()
    {
        EventManager.StopListening("onTwoMinuteEvent", SpawnSpeedUpdate);
        
    }
    #endregion
}
