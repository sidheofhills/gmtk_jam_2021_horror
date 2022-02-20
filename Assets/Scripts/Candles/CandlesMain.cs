using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandlesMain : MonoBehaviour
{
    [SerializeField] GameData gameData;
    private string currentTagName;
    private int littedCandles = 0;
    public int LittedCandles => littedCandles;
     
    // the catalysis for game win
    private void CandleCounter()
    {
        littedCandles += 1;        
        if(littedCandles==10)
        {
            EventManager.TriggerEvent(gameData.OnDarkPentaDisappearing);        
            // first dark penta dissapearing, then white penta reappearing and the order is restored, game win
        }
    }

    #region Methods that change the field currentTagName depending of game's phase
    /// <summary>
    /// i have 3 groups of candles on each side of the screen and i need them to lit one by one as the game goes on
    /// so i tagged these groups with phase's names so that i wouldn't mess with string's misspelling 
    /// it's a questionable move but will do for this project
    /// </summary>
    private void OnFirstPhaseEnds()  // delegates?
    {
        currentTagName = gameData.FirstPhaseEnds;
        CandlesGprLit();
    }

    private void OnSecondPhaseEnds()
    {
        currentTagName = gameData.SecondPhaseEnds;
        CandlesGprLit();
    }

    private void OnThirdPhaseEnds()
    {
        currentTagName = gameData.ThirdPhaseEnds;
        CandlesGprLit();
    }

    #endregion

    // general method for lighting up candles per grp
    private void CandlesGprLit() 
    {        
        GameObject[] grp = GameObject.FindGameObjectsWithTag(currentTagName);
        for(int i = 0; i< grp.Length; i++)
        {
           grp[i].GetComponent<CandlesGrp>().CandlesLit();
        }
    }  
   
    // when dark penta is on, monsters're spawning  and there's no lited candles to keep monsters from our world 
    private void CandlesUnlit()
    {
        Animator[] candlesAnimators = GetComponentsInChildren<Animator>();
        foreach(Animator animator in candlesAnimators)
        {
            animator.SetBool("Unlit", true);
        }        
    }


    private void OnEnable()
    {
        EventManager.StartListening(gameData.MonstersSpawn, CandlesUnlit);        
        EventManager.StartListening(gameData.OnEachCandleLit, CandleCounter);

        EventManager.StartListening(gameData.FirstPhaseEnds, OnFirstPhaseEnds);
        EventManager.StartListening(gameData.SecondPhaseEnds, OnSecondPhaseEnds);
        EventManager.StartListening(gameData.ThirdPhaseEnds, OnThirdPhaseEnds);


    }
    private void OnDisable()
    {
        EventManager.StopListening(gameData.MonstersSpawn, CandlesUnlit);        
        EventManager.StopListening(gameData.OnEachCandleLit, CandleCounter);

        EventManager.StopListening(gameData.FirstPhaseEnds, OnFirstPhaseEnds);
        EventManager.StopListening(gameData.SecondPhaseEnds, OnSecondPhaseEnds);
        EventManager.StopListening(gameData.ThirdPhaseEnds, OnThirdPhaseEnds);

    }
}
