using UnityEngine;

public  class MonsterParentClass : MonoBehaviour //colud be an abstract class as well
{
    // the behavior that shared among all of the monsters
    protected WeaponSpawner weaponSpawner;
    private void Awake()
    {
        weaponSpawner = FindObjectOfType<WeaponSpawner>();  
    }
    protected void ClickToDeath()
    {        
        weaponSpawner.SpawnFromThisPoint(this.gameObject.transform.position, this.gameObject.transform.localScale);        
        // play death animation

        this.gameObject.SetActive(false);
        

    }
}
