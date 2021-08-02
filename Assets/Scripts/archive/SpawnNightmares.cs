using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNightmares : MonoBehaviour



{
    // Start is called before the first frame update
[SerializeField] private GameObject nightmare;
    public static int enemyNum = 0;
    [SerializeField] private float spawnTime = 0.1f;
    bool spawning = true;
    [SerializeField] private float maxX;
[SerializeField] private float minX;
[SerializeField] private float maxY;
[SerializeField] private float minY;

[SerializeField] private float timeBetweenSpawn;

    
    // Update is called once per frame
    void Update()
    {
       if (enemyNum <5) //or no enemys left
        {
            StartCoroutine(Spawn());
        }
    }

    IEnumerator Spawn()
    {
         float randomX = Random.Range(minX, maxX);
         float randomY = Random.Range(minY, maxY);

        
        enemyNum += 1;
        spawning = false;
        yield return new WaitForSeconds(spawnTime);
        spawning = true;
        
        Instantiate(nightmare, transform.position + new Vector3(randomX, randomY, 0), Quaternion.identity);
        Debug.Log(enemyNum);
        Debug.Log(spawning);
    }
}

