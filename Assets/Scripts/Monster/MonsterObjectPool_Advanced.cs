using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterObjectPool_Advanced : MonoBehaviour
{

    /// <summary>
    /// this one was made with the help f https://onewheelstudio.com/blog/2020/7/15/object-pooling
    /// but unlike with event manager i don't have a lot of questions here
    /// </summary>
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
                _object.SetActive(false); // i need this so that i could place them correctly first and then turn on
                return _object;                
            }
        }
        else
        {            
            return CreateNewObject(gameObject);
        }
    }


    private GameObject CreateNewObject(GameObject gameObject)
    {
        GameObject newGameObject = Instantiate(gameObject);
        newGameObject.name = gameObject.name;  //for better control over variety of objectLists
        gameObject.SetActive(false);  // i need this so that i could place them correctly first and then turn on
        return newGameObject;
    }


    public void ReturnGameObject(GameObject gameObject)
    {
        if (objectPool.TryGetValue(gameObject.name, out Queue<GameObject> objectList))
        {
            objectList.Enqueue(gameObject);            
        }
        else
        {
            Queue<GameObject> newObjectQueue = new Queue<GameObject>();
            newObjectQueue.Enqueue(gameObject);
            objectPool.Add(gameObject.name, newObjectQueue);           
        }
        
    }
}
