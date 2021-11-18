using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterParentClass : MonoBehaviour
{
    public GameData gameData;
    protected void ClickToDeath()
    {
        gameData.weaponSpawnTransform = this.gameObject.transform.position;
        EventManager.TriggerEvent(gameData.Attack);
        
        this.gameObject.SetActive(false);
        
    }
}
