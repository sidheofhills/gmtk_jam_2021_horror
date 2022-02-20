using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MonsterSlipperyBehaviour : MonsterParentClass
{
    // it should've been very slippery and run from mouse cursor but it was made with dynamic rigid body and took a lot of resources so i kill it
    [SerializeField] private GameData gameData;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        animator.Play(0);
    }

    
    private void OnMouseDown()
    {
        
        ClickToDeath();
        

    }


}
