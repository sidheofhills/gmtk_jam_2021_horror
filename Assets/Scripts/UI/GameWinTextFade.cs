using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GameWinTextFade : MonoBehaviour
{
    [SerializeField] GameData gameData;
    [SerializeField] TextMeshProUGUI num;
    private FadeInFadeOut fadeInFadeOut;
    private void Awake()
    {
        fadeInFadeOut = FindObjectOfType<FadeInFadeOut>();
        num.SetText(GameData.enemyNumKilled.ToString());
    }
    private void TurnOff()
    {
        fadeInFadeOut.FadeOut(this.gameObject, 1.5f);
    }
    private void OnEnable()
    {
        EventManager.StartListening(gameData.CreditsTime, TurnOff);
    }
    private void OnDisable()
    {
        EventManager.StopListening(gameData.CreditsTime, TurnOff);
    }
}
