using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MonsterSlipperyBehaviour : MonsterParentClass
{

    [SerializeField] private GameData gameData;

    private bool spectialBehaviourModOn;
    [SerializeField] private float localTimer = 0.1f;
    // to new position variables
    private float timeElapsed;
    //[SerializeField] private float lerpDuration = 0.5f;

    private Rigidbody2D _rigidbody;
    private BoxCollider2D boxCollider2D;
    private Vector2 initialColliderSize;
   
    private void Awake()
    {
        spectialBehaviourModOn = false;
        _rigidbody = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        initialColliderSize = boxCollider2D.bounds.size;
       
    }

    private void FixedUpdate()
    {
        if (spectialBehaviourModOn && localTimer > 0) 
        {
            MoveByRandomVector();
            boxCollider2D.size = initialColliderSize * gameData.boxColliderExpandValue;
            //Debug.Log("slippery mod done");                
        }
        else
        {
            
            boxCollider2D.size = initialColliderSize;
        }

    }

    private void OnMouseEnter()
    {
        Debug.Log("onPointEnter");
        spectialBehaviourModOn = true;
        localTimer -= Time.deltaTime;
    }
    private void OnMouseDown()
    {
        
        ClickToDeath();
        //Debug.Log("basic mod done");

    }


    #region To New Position Setup. Note:
    private static Vector2 GetRandomDir2d()    
    {
        return new Vector2(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)).normalized;   //left unityEngine in case i'll put it in a lib some day
    }

    private void MoveByRandomVector()
    {
        Vector2 newPos = GetRandomDir2d() * gameData.speed;
        
        _rigidbody.AddForceAtPosition(newPos, this.transform.position, ForceMode2D.Impulse);
    }
    /*private IEnumerator LerpToNewPosition()
    {        
        Vector2 newPos = GetRandomDir2d();
        
        if (timeElapsed < lerpDuration)
        {
            this.transform.position = Vector2.Lerp(this.transform.position, newPos, timeElapsed / lerpDuration);
            
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        else  //to get to 1 for sure
        {
            this.transform.position = newPos;
        }

    }*/
    #endregion
}
