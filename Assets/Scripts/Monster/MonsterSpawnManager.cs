using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawnManager : MonoBehaviour
{
    [SerializeField] private GameData gameData;
    private MonsterSpawner monsterSpawner;
    [SerializeField] private AudioClips audioClips;
    private AudioSource monsterAudioSource;

    [SerializeField] private GameObject basicPrefab;
    [SerializeField] private GameObject slipperyPrefab;
    [SerializeField] private GameObject replicantPrefab;

    [SerializeField] private bool leftSide; // for the offset
    [SerializeField] float waitingOffsetTime;

    private bool spawn = false;
    private GameObject mainPrefab;
    private GameObject additionalPrefab;
    private float timer;
    [SerializeField] private float mainPrefabSpawnCooldown = 5f;    
    [SerializeField] private float spawnTimeReducer;

       
    private void Start()
    {
        monsterAudioSource = GetComponent<AudioSource>();
        monsterSpawner = FindObjectOfType<MonsterSpawner>();

        
        InitialPrefabSetup();
        timer = mainPrefabSpawnCooldown + 0.1f;
    }

    private void Update()
    {        
       SpawnLogic();
    }

    private void StartSpawning()  //чтобы можно было сделать офсет на споун
    {
        StartCoroutine(WaitIfLeftSide());
        spawn = true;
    }

    private IEnumerator WaitIfLeftSide()
    {
        if (leftSide)
        {
            yield return new WaitForSeconds(UnityEngine.Random.value * waitingOffsetTime);
        }
    }
    private void SpawnLogic()
    {
        if (spawn)
        {
           
            if (timer > mainPrefabSpawnCooldown)
            {
                timer = 0f;
                SpawnBundle(mainPrefab);
                //yield return new WaitForSeconds(UnityEngine.Random.value * (waitingOffsetTime / 2f));
                SpawnBundle(additionalPrefab);
            }
            timer += Time.deltaTime;
        }
    }
    private void SpawnBundle(GameObject prefab)
    {
        monsterSpawner.SpawnFromThisPoint(prefab, this.transform.position);                                                                                                                                        
        AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.monsterSpawning, monsterAudioSource);     
    }

   

    //  чтобы можно было побалансить, если понадобится
    private void InitialPrefabSetup()
    {
        mainPrefab = basicPrefab;
        additionalPrefab = basicPrefab;     //!!!!!!!!!!!!!!!!!!!!!!!!    
    }


    private void OnFirstPhaseEnds()
    {
        mainPrefab = basicPrefab;
        additionalPrefab = replicantPrefab;
        mainPrefabSpawnCooldown -= spawnTimeReducer;
               
    }

    private void OnSecondPhaseEnds()
    {
        mainPrefab = basicPrefab;
        additionalPrefab = slipperyPrefab;
        mainPrefabSpawnCooldown -= spawnTimeReducer/2f;
               
    }

    private void OnThirdPhaseEnds()
    {
        mainPrefab = replicantPrefab;
        additionalPrefab = basicPrefab;
        mainPrefabSpawnCooldown += spawnTimeReducer*1.5f;
               
    }

    #region Events Functions Enable/Disable
    private void OnEnable()
    {
        
        EventManager.StartListening(gameData.FirstPhaseEnds, OnFirstPhaseEnds);
        EventManager.StartListening(gameData.SecondPhaseEnds, OnSecondPhaseEnds);
        EventManager.StartListening(gameData.ThirdPhaseEnds, OnThirdPhaseEnds);
        EventManager.StartListening(gameData.MonstersSpawn, StartSpawning);


    }
    private void OnDisable()
    {
        EventManager.StopListening(gameData.FirstPhaseEnds, OnFirstPhaseEnds);
        EventManager.StopListening(gameData.SecondPhaseEnds, OnSecondPhaseEnds);
        EventManager.StopListening(gameData.ThirdPhaseEnds, OnThirdPhaseEnds);
        EventManager.StopListening(gameData.MonstersSpawn, StartSpawning);

    }
    #endregion
}
