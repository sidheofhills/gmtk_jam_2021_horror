using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBasicBehaviour : MonsterParentClass
{

    private void OnMouseDown()
    {
        
        ClickToDeath();
        Debug.Log("basic mod done");

    }
}
