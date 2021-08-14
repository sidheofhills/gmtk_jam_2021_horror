using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slippery : MonsterParentClass
{
    //private ObjectPool_Simple myObjectPool;
    public GameData gameData;

    private bool spectialBehaviourModOn;
    [SerializeField] private float localTimer = 0.2f;
    // to new position variables
    private float timeElapsed;
    [SerializeField] private float lerpDuration = 0.5f;

    private Rigidbody2D _rigidbody;
    private BoxCollider2D boxCollider2D;
    private Vector2 initialColliderSize;
   
    private void Awake()
    {
        spectialBehaviourModOn = false;
       
    }
        private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        initialColliderSize = boxCollider2D.bounds.size;

    }
    private void FixedUpdate()
    {
        if (spectialBehaviourModOn && localTimer > 0) 
        {
            SlipperyMod();
            boxCollider2D.size = initialColliderSize * gameData.boxColliderExpandValue;
            //Debug.Log("slippery mod done");                
        }
        else
        {

            boxCollider2D.size = initialColliderSize;
        }

    }

   
    private void SlipperyMod()
    {
        //StartCoroutine(LerpToNewPosition());
        MoveByRandomVector();

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




    /*private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("i've entered a border" + other.tag + other.CompareTag("border"));

        if (other.CompareTag("border"))
        {
            
            //this.gameObject.SetActive(false);
            Debug.Log("i've touched a wall and kinda bounced");


        }
    }*/

    #region To New Position Setup. Note: *0.3
    private static Vector2 GetRandomDir2d()    // i use it only in this script so it's private. but in another project i might put it in a sep script and use it as a library
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
