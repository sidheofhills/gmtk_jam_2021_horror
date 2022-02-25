using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningCrackedGlass : MonoBehaviour
{
    [SerializeField] private GameObject leftSide;
    [SerializeField] private GameObject rightSide;
    [SerializeField] GameData gameData;

    private void Awake()
    {
        leftSide.SetActive(false);
        rightSide.SetActive(false);
    }

    private void LeftSide()
    {
        leftSide.SetActive(true);
    }
    private void RightSide()
    {
        rightSide.SetActive(true);
    }

    private void OnEnable()
    {
        EventManager.StartListening(gameData.LeftGlassCracked, LeftSide);
        EventManager.StartListening(gameData.RightGlassCracked, RightSide);
    }

    private void OnDisable()
    {
        EventManager.StopListening(gameData.LeftGlassCracked, LeftSide);
        EventManager.StopListening(gameData.RightGlassCracked, RightSide);
    }
}
