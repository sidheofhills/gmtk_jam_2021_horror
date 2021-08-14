using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replicant : MonsterParentClass
{
    [SerializeField] private int numberOfReplicants = 3;
    
    private Spawner spawner;
    private ObjectPool_Advanced objectPool;

    private void Awake()
    {
        
        spawner = FindObjectOfType<Spawner>();
        objectPool = FindObjectOfType<ObjectPool_Advanced>();
    }

    private void OnMouseDown()
    {
        ReplicationMod();        
    }

    public void ReplicationMod()
    {
        for (int i = 0; i < numberOfReplicants; i++)
        {
            spawner.SpawnFromThisPoint(objectPool.slipperyPefab);
        }
        ClickToDeath();
        Debug.Log("basic mod done");
    }
}
