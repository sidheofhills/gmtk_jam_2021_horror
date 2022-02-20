
using UnityEngine;



public class MonsterSpawner : MonoBehaviour
{
        private MonsterObjectPool_Advanced objectPool;

    public GameData gameData;

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
    }

    public void SpawnFromThisPoint(GameObject prefab, Vector3 position)
    {
        GameObject newObject = objectPool.GetObject(prefab);
        Vector2 newSpawnPoint = new Vector2(0, 0);
        
        newSpawnPoint = position + UnityEngine.Random.insideUnitSphere * 2;

        newObject.transform.position = newSpawnPoint;        
        newObject.SetActive(true);


    }




}


