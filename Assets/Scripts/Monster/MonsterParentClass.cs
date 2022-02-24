using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterParentClass : MonoBehaviour //colud be an abstract class as well
{

    protected WeaponSpawner weaponSpawner;
    private void Awake()
    {
    }
    protected void ClickToDeath()
    {
        weaponSpawner = FindObjectOfType<WeaponSpawner>();  //насколько это замедляет систему?

        weaponSpawner.SpawnFromThisPoint(this.gameObject.transform.position, this.gameObject.transform.localScale);
        Debug.Log("death scale " + this.gameObject.transform.localScale);
        // play death animation

        this.gameObject.SetActive(false);
        
    }
}
