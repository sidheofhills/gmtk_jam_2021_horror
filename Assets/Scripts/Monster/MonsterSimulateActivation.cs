using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSimulateActivation : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D { get; set; }

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        Rigidbody2D.simulated = true;
        
    }
    private void OnDisable()
    {
        Rigidbody2D.simulated = false;
         
    }
}
