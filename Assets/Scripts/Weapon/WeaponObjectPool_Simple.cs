using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeaponObjectPool_Simple : MonoBehaviour
{

    [SerializeField] private GameObject myObjectPrefab;
    [SerializeField] private Queue<GameObject> myObjectPool = new Queue<GameObject>();
    [SerializeField] private int poolStartSize = 5;
    // Start is called before the first frame update
    void Start()
    {     

        for(int i = 0; i < poolStartSize; i++)
        {
            GameObject myObject = Instantiate(myObjectPrefab);
            myObjectPool.Enqueue(myObject);
            myObject.SetActive(false);
            
        }
    }


    public GameObject GetObject()
    {
        

        if (myObjectPool.Count>0)
        {
            GameObject myObject = myObjectPool.Dequeue();
            myObject.SetActive(true);            
            return myObject;
        }

        else
        {            
            GameObject myObject = Instantiate(myObjectPrefab);
            
            return myObject;
        }
    }
  

    public void ReturnGameObject(GameObject myObject)
    {
        myObjectPool.Enqueue(myObject);        
        myObject.SetActive(false);
    }

}
