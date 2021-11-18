using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponReturn : MonoBehaviour
{

    private MonsterObjectPool_Advanced objectPool;
    public GameData gameData;
    [SerializeField] private float secondsBeforeReturn = 1.5f;


    void Start()
    {
        objectPool = FindObjectOfType<MonsterObjectPool_Advanced>();
    }

    private void OnEnable()
    {
        StartCoroutine(WaitingBeforeReturn());
    }

    private IEnumerator WaitingBeforeReturn()
    {
        yield return new WaitForSeconds(secondsBeforeReturn);
        objectPool.ReturnGameObject(this.gameObject);  

        //should use lerp for d=fade in fade out
    }    
}
