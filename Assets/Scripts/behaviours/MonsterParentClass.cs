using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterParentClass : MonoBehaviour
{
    protected void ClickToDeath()
    {

        this.gameObject.SetActive(false);
    }
}
