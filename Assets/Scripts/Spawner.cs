using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Spawner : MonoBehaviour
{

    [SerializeField] private float timeToSpawn = 5f;
    //[SerializeField] private float timer;
    //private float localTimer;
    [SerializeField] private float spawnTimeReducer;
    //private float timeSinceSpawn;
    private float localTimSinceSpawn;
    
    
    
    private ObjectPool_Simple myObjectPool;
    //public SelectionManager selectionManager; //reference to a manager to take variables from
    public GameData gameData;


    public event Action spawnEvent;


    

    // Start is called before the first frame update
    void Start()
    {
        myObjectPool = FindObjectOfType<ObjectPool_Simple>();
        //localTimer = timer;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (KnockUI.HeKnocked)
        { //timeSinceSpawn += Time.deltaTime;
            localTimSinceSpawn += Time.deltaTime;


            if (localTimSinceSpawn > timeToSpawn)
            {
                SpawnFromThisPoint();

                localTimSinceSpawn = 0f;
            }
            //Debug.Log(timeToSpawn);
        }
    }

    private void LateUpdate()
    {
        
       
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


    public void SpawnFromThisPoint()
    {
                GameObject newObject = myObjectPool.GetMyObject();
                Vector3 newSpawnPoint = new Vector3(0, 0, 0);

                gameData.enemyNum += 1;

                if (spawnEvent != null) spawnEvent(); // EVENT TRIGGER  spawnEvent()

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
