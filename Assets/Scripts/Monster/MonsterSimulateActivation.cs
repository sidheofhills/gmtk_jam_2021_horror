using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSimulateActivation : MonoBehaviour
{
    // trying to ease it up a bit when there're lots of monsters in the scene and they're constantly switching on and off
    // it is said that turning simulation off can be beneficial

#pragma warning disable CS0108 // 'MonsterSimulateActivation.rigidbody2D' hides inherited member 'Component.rigidbody2D'. Use the new keyword if hiding was intended.
    private Rigidbody2D rigidbody2D;
#pragma warning restore CS0108 // 'MonsterSimulateActivation.rigidbody2D' hides inherited member 'Component.rigidbody2D'. Use the new keyword if hiding was intended.
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        rigidbody2D.simulated = true;
        
    }
    private void OnDisable()
    {
        rigidbody2D.simulated = false;
        
    }
}
