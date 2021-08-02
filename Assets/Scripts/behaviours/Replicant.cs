using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replicant : MonsterParentClass
{
    [SerializeField] private int numberOfReplicants = 3;
    private Spawner spawner;

    private void Awake()
    {
        
        spawner = FindObjectOfType<Spawner>();
    }

    private void OnMouseDown()
    {
        ReplicationMod();
        ClickToDeath();
        Debug.Log("basic mod done");

    }

    public void ReplicationMod()
    {
        for (int i = 0; i < numberOfReplicants; i++)
        {
            spawner.SpawnFromThisPoint();



        }
    }
}
