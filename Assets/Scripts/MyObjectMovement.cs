using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MyObjectMovement : MonoBehaviour
{
   

    private Vector3 objectPosition;
    
    private ObjectPool_Simple myObjectPool;
    public GameData gameData;
    

   

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Spawner>().spawnEvent += StartMoving;
     
    }

    private void OnEnable()
    {
        transform.localScale = new Vector3(gameData.startingScale, gameData.startingScale, gameData.startingScale);
    }
 
    // Update is called once per frame
    void Update()
    {
        StartMoving();
    }

    private void StartMoving()
    {
        Movement();
    }
    private void Movement()
    {
        Vector3 camDir = Camera.main.transform.forward;
        
        this.transform.position += camDir * gameData.speed * Time.deltaTime;

        float newScaleComponents = 1 / Vector3.Distance(camDir, transform.position);
        transform.localScale += new Vector3(newScaleComponents, newScaleComponents, newScaleComponents) * gameData.scaleMult;


        FindObjectOfType<Spawner>().spawnEvent -= Movement;
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("i've entered a border" + other.tag+ other.CompareTag("border"));

        if (other.CompareTag("border"))
        {
            this.gameObject.SetActive(false);

        }
    }




}

