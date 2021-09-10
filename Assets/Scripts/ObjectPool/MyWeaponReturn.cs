using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWeaponReturn : MonoBehaviour
{

    private ObjectPool_Advanced objectPool;
    public GameData gameData;
    [SerializeField] private float secondsBeforeReturn = 1.5f;


    void Start()
    {
        objectPool = FindObjectOfType<ObjectPool_Advanced>();
    }

    private void OnEnable()
    {
        StartCoroutine(WaitingBeforeReturn());
    }

    private IEnumerator WaitingBeforeReturn()
    {
        yield return new WaitForSeconds(secondsBeforeReturn);
    }    
}
