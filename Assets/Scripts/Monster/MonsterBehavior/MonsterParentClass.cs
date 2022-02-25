using UnityEngine;

public abstract class MonsterParentClass : MonoBehaviour
{
    protected WeaponSpawner weaponSpawner;
    private void Awake()
    {
        weaponSpawner = FindObjectOfType<WeaponSpawner>();  
    }


    // the behavior that shared among all of the monsters
    public virtual void ClickToDeath()
    {        
        weaponSpawner.SpawnFromThisPoint(this.gameObject.transform.position, this.gameObject.transform.localScale);        
        // play death animation

        this.gameObject.SetActive(false);
        

    }
}
