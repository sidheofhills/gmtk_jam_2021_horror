
using UnityEngine;



public class MonsterSpawner : MonoBehaviour
{

    private MonsterObjectPool_Advanced objectPool;

    public GameData gameData;

    

    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void SpawnFromThisPoint(GameObject prefab, Vector3 position)
    {
        GameObject newObject = objectPool.GetObject(prefab);
        Vector2 newSpawnPoint = new Vector2(0, 0);
        

        


        newSpawnPoint = position + UnityEngine.Random.insideUnitSphere * 2;

        newObject.transform.position = newSpawnPoint;
        //Debug.Log(newObject.transform.position +" is spawner of " + newObject.name + newObject.GetInstanceID());
        newObject.SetActive(true);


    }




}


