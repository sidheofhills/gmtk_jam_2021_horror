using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandlesGrp : MonoBehaviour
{
    [SerializeField] GameData gameData;
    private Animator[] candlesAnimators;


   public void CandlesLit()
    {
        candlesAnimators = this.gameObject.GetComponentsInChildren<Animator>();
        foreach(Animator animator in candlesAnimators)
        {
            animator.SetBool("Unlit", false);
            EventManager.TriggerEvent(gameData.OnEachCandleLit);
        }
    }
}
