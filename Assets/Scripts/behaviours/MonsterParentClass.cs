using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterParentClass : MonoBehaviour
{
    public GameData gameData;
    protected void ClickToDeath()
    {
        EventManager.TriggerEvent(gameData.MonsterDeath);
        this.gameObject.SetActive(false);
    }
}
