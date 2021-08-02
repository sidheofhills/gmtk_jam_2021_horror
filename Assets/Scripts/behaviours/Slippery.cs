using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slippery : MonsterParentClass
{
    //private ObjectPool_Simple myObjectPool;
    public GameData gameData;

    private bool spectialBehaviourModOn;
    [SerializeField] private float localTimer = 0.2f;
    // to new position variables
    private float timeElapsed;
    [SerializeField] private float lerpDuration = 0.5f;

   
    private void Awake()
    {
        spectialBehaviourModOn = false;
        
        
    }


    private void Update()
    {
        if (spectialBehaviourModOn) 
        {
            localTimer -= Time.deltaTime;
            if (localTimer>0)
            {
                SlipperyMod();
                Debug.Log("slippery mod done");
                
            }
        }
    }

   
    private void SlipperyMod()
    {
        StartCoroutine(LerpToNewPosition());

    }

    private void OnMouseEnter()
    {
        
        Debug.Log("onPointEnter");
        spectialBehaviourModOn = true;
    }
    private void OnMouseDown()
    {
        ClickToDeath();
        Debug.Log("basic mod done");
        
    }



    #region To New Position Setup. Note: *3
    private static Vector3 GetRandomDir2d()    // i use it only in this script so it's private. but in another project i might put it in a sep script and use it as a library
    {
        return new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)).normalized  * 3;   //left unityEngine in case i'll put it in a lib some day
    }

    private IEnumerator LerpToNewPosition()
    {
        Vector3 newPos = this.transform.position + GetRandomDir2d();
        if (timeElapsed < lerpDuration)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, newPos, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        else
        {
            this.transform.position = newPos;
        }

    }
    #endregion
}
