using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class SelectionManager : MonoBehaviour
{   
        public GameData gameData;
    public new Camera camera;

    int layerMask;
    Rigidbody2D _rigidbody2D;
    
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        layerMask = 1 << LayerMask.NameToLayer("Nightmares");        
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
            RaycastHit2D hit;
            // Does the ray intersect any objects in nightmares layer
            hit = Physics2D.Raycast(camera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, layerMask);  //ScreenToWorldPoint returns coords, ScreenPointToRay returns a ray

            

            if (hit.collider != null &&!EventSystem.current.IsPointerOverGameObject())  //second bit is for UI black part
            {
                gameData.selectedObject = hit.transform.gameObject;
                
                Debug.Log("sel obj " + gameData.selectedObject);
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
