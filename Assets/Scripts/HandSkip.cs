using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSkip : MonoBehaviour
{
    [SerializeField] private GameObject hand;
    [SerializeField] private GameData gameData;
    void Awake()
    {
        hand.SetActive(true);
    }

    private void OnSkip()
    {
        hand.SetActive(false);
    }
    private void OnEnable()
    {
        
        EventManager.StartListening(gameData.Skip, OnSkip);
    }

    private void OnDisable()
    {
        
        EventManager.StopListening(gameData.Skip, OnSkip);
    }
}
