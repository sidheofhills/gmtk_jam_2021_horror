using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterReplicantBehaviour : MonsterParentClass
{    
    private MonsterSpawner spawner;
    private GameObject spawningPefab;
    [SerializeField] private GameData gameData;
    [SerializeField] private GameObject slipperyPefab;
    [SerializeField] private GameObject basicPefab;
    private int numberOfReplicants = 2;

    private void Start()
    {        
        spawner = FindObjectOfType<MonsterSpawner>();
        spawningPefab = basicPefab;        
    }

    private void OnMouseDown()
    {
        ReplicationMod();        
    }

    public void ReplicationMod()
    {
        for (int i = 0; i < numberOfReplicants; i++)
        {
            spawner.SpawnFromThisPoint(spawningPefab, this.transform.position);
        }
        ClickToDeath();
        
    }

    private void OnSecondPhaseEnds()
    {        
        spawningPefab = slipperyPefab;
        numberOfReplicants *= 2; 
    }
    private void OnEnable()
    {        
        EventManager.StartListening(gameData.SecondPhaseEnds, OnSecondPhaseEnds);
    }
    private void OnDisable()
    {        
        EventManager.StopListening(gameData.SecondPhaseEnds, OnSecondPhaseEnds);
    }
}
