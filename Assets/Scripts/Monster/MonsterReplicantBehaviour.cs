using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterReplicantBehaviour : MonsterParentClass
{
    [SerializeField] private int numberOfReplicants = 3;
    
    private MonsterSpawner spawner;
    [SerializeField] private GameObject slipperyPefab;

    private void Awake()
    {
        
        spawner = FindObjectOfType<MonsterSpawner>();
        
    }

    private void OnMouseDown()
    {
        ReplicationMod();        
    }

    public void ReplicationMod()
    {
        for (int i = 0; i < numberOfReplicants; i++)
        {
            spawner.SpawnFromThisPoint(slipperyPefab, this.transform.position);
        }
        ClickToDeath();
        Debug.Log("replicant mod done");
    }
}
