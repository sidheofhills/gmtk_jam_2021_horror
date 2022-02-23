using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBasicBehaviour : MonsterParentClass
{
    public override void ClickToDeath()
    {
        base.ClickToDeath();
    }

    private void OnMouseDown()
    {
        
        ClickToDeath();        

    }
}
