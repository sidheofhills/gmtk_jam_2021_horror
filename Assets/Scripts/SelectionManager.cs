using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class SelectionManager : MonoBehaviour
{   

    public GameData gameData;
    public Camera camera;


    

    int layerMask;
    Rigidbody _rigidbody;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        layerMask = 1 << LayerMask.NameToLayer("Nightmares");

        //gameData = FindObjectOfType<GameData>();
        //enemyNum = GameData.enemyNum;
       


    }


    // Update is called once per frame
    void Update()
    {
        SelectObject();
    }


    private void LateUpdate()
    {
        DeselectObject();
    }

    private void SelectObject()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            // Does the ray intersect any objects in nightmares layer
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask) &&!EventSystem.current.IsPointerOverGameObject())  //second bit is for UI black part
            {
                gameData.selectedObject = hit.transform.gameObject;
                Debug.Log(gameData.selectedObject);

            }
            else
            {
                
                Debug.Log("Did not Hit" + Input.mousePosition);
            }
        }      
    }


    private void DeselectObject()
    {
        if (Input.GetMouseButtonUp(0))
        {
            gameData.selectedObject = null;
            Debug.Log("Deselecd"  + gameData.selectedObject);
        }
    }

}
