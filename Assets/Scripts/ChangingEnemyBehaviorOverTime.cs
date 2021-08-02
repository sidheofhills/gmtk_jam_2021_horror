using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingEnemyBehaviorOverTime : MonoBehaviour
{


    //private ObjectPool_Simple myObjectPool;
    public GameData gameData;

    private bool spectialBehaviourModOn;

    // to new position variables
    private float timeElapsed;
    [SerializeField] private float lerpDuration = 0.5f;

    [SerializeField] private int numberOfReplicants = 3;
    private Spawner spawner;

    private void Awake()
    {
        spectialBehaviourModOn = false;
        //myObjectPool = FindObjectOfType<ObjectPool_Simple>();
        spawner = FindObjectOfType<Spawner>();
    }


    private void Update()
    {
        BehaviourChanger();
    }

    private void ClickToDeath()
    {
        gameData.selectedObject.SetActive(false);
    }
    private void SlipperyMod()
    {
        StartCoroutine(LerpToNewPosition());
          
    }

    public void ReplicationMod()
    {
        for (int i = 0; i < numberOfReplicants; i++)
        {
            spawner.SpawnFromThisPoint();
           
            

        }
    }

    // ÑÅÉ×ÀÑ ÂÐÎÄÅ ÐÀÁÎÒÀÅÒ, ÍÎ ÂÈÇÓÀËÜÍ ÎÎÍÅÏÎÍßÒÍÎ, ×ÒÎ È ÏÎ×ÅÌÓ ÏÐÎÈÑÕÎÄÈÒ. ÂÈÄÈÌÎ, ÏÎÐÀ ÄÎÁÀÂÈÒÜ ÍÅÌÍÎÃÎ ÀÍÈÌÀÖÈÈ
    private void BehaviourChanger()
    {
        if (this.gameObject == gameData.selectedObject) { 
            if (spectialBehaviourModOn && gameData.firstStageOn) 
            {
                SlipperyMod();
                Debug.Log("slippery mod done");
                spectialBehaviourModOn = false;
            }
            else if (spectialBehaviourModOn && gameData.secondStageOn)
            {
                ReplicationMod();
                Debug.Log("spawner mod done");
                spectialBehaviourModOn = false;
            }
            else if (spectialBehaviourModOn && gameData.thirdStageOn)
            {
                ReplicationMod();
                SlipperyMod();
                Debug.Log("mega mod done");
                spectialBehaviourModOn = false;
            }
            else
            {
                ClickToDeath();
                Debug.Log("basic mod done");
                spectialBehaviourModOn = true;
            }
            Debug.Log(spectialBehaviourModOn);
        }
    }

    #region To New Position Setup
    private static Vector3 GetRandomDir2d()    // i use it only in this script so it's private. but in another project i might put it in a sep script and use it as a library
    {
        return new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)).normalized;   //left unityEngine in case i'll put it in a lib some day
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

