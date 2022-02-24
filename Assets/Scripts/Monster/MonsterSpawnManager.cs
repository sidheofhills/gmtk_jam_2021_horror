using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawnManager : MonoBehaviour
{
    [SerializeField] private GameData gameData;
    private MonsterSpawner monsterSpawner;
    [SerializeField] private AudioClips audioClips;
    private AudioSource monsterAudioSource;

    //public for them to be taken elsewhere 
    [SerializeField] private GameObject basicPefab;
    [SerializeField] private GameObject slipperyPefab;
    [SerializeField] private GameObject replicantPefab;

    [SerializeField] private int slipperyNumber;
    [SerializeField] private int replicantNumber;


    [SerializeField] private float timeToSpawn = 5f;

    [SerializeField] private float spawnTimeReducer;

    private float basicTimeSinceSpawn;
    private float specialTimeSinceSpawn;


    [SerializeField] private bool leftSide;
    
    [SerializeField] float waitingOffsetTime;



    private void Start()
    {
        monsterAudioSource = GetComponent<AudioSource>();
        monsterSpawner = FindObjectOfType<MonsterSpawner>();
    }

    private void Update()
    {
        StartCoroutine(SpawnLogic());
    }
    private IEnumerator SpawnLogic()
    {
        if (gameData.startSpawn)
        {
            if(leftSide)
            {
                yield return new WaitForSeconds(Random.value * waitingOffsetTime);
            }

            basicTimeSinceSpawn += Time.deltaTime;
            specialTimeSinceSpawn += Time.deltaTime;

            if (basicTimeSinceSpawn > timeToSpawn)
            {
                monsterSpawner.SpawnFromThisPoint(basicPefab, this.transform.position);  //logic of spawning different enemies at diff time = maybe there's need in another script - monster randomizer                                                                                                                                          
                AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.monsterSpawning, monsterAudioSource);
                basicTimeSinceSpawn = 0f;
            }


            if (gameData.firstStageOn)
            {
                if (specialTimeSinceSpawn > timeToSpawn * 2)
                {
                    monsterSpawner.SpawnFromThisPoint(slipperyPefab, this.transform.position);
                    AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.monsterSpawning, monsterAudioSource);
                    specialTimeSinceSpawn = 0f;
                }
            }
            else if (gameData.secondStageOn)
            {
                if (specialTimeSinceSpawn > timeToSpawn * 4)
                {
                    monsterSpawner.SpawnFromThisPoint(replicantPefab, this.transform.position);
                    AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.monsterSpawning, monsterAudioSource);
                    specialTimeSinceSpawn = 0f;
                }
            }
        }

    }

    // необязатлеьная функция и можно ее убрать, но пусть пока
    private void SpawnSpeedUpdate()
    {
        if (timeToSpawn > 0.2)
        {
            timeToSpawn -= spawnTimeReducer;
            Debug.Log("reduced spawnTime, now it is" + timeToSpawn);
        }
        else return;  //тут враги вызываются с минимальным интервалом

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
