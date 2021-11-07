using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterObjectPool_Advanced : MonoBehaviour
{
    private Dictionary<string, Queue<GameObject>> objectPool = new Dictionary<string, Queue<GameObject>>();  //create and initialize dictionary



    public GameObject GetObject(GameObject gameObject)
    {
        if (objectPool.TryGetValue(gameObject.name, out Queue<GameObject> objectList))  //if there's smth in OP get out new variable objectList
        {
            if(objectList.Count==0)
            {
                
                return CreateNewObject(gameObject);
            }
            else
            {
                GameObject _object = objectList.Dequeue();
                
                _object.SetActive(true);
                return _object;
                
            }
        }
        else
        {
            
            return CreateNewObject(gameObject);
        }
    }


    public GameObject CreateNewObject(GameObject gameObject)
    {
        GameObject newGameObject = Instantiate(gameObject);
        newGameObject.name = gameObject.name;  //for better control over variety of objectLists
        return newGameObject;
    }


    public void ReturnGameObject(GameObject gameObject)
    {
        if (objectPool.TryGetValue(gameObject.name, out Queue<GameObject> objectList))
        {
            objectList.Enqueue(gameObject);
            Debug.Log("enqueue old object" + gameObject.name);
        }
        else
        {
            Queue<GameObject> newObjectQueue = new Queue<GameObject>();
            newObjectQueue.Enqueue(gameObject);
            objectPool.Add(gameObject.name, newObjectQueue);
            Debug.Log("enqueue new object" + gameObject.name);
        }
        //Debug.Log("object pool list" + objectList.Count);
        //gameObject.SetActive(false);
    }
}
