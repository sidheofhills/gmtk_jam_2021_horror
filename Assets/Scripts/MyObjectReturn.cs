using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MyObjectReturn : MonoBehaviour
{
    

    // Start is called before the first frame update
    
    private ObjectPool_Advanced objectPool;
    public GameData gameData;


    void Start()
    {
        objectPool = FindObjectOfType<ObjectPool_Advanced>();
        

    }



    private void OnDisable()  //������� ������ ��� ��� �������. � ���� ������ �� ����������� ��� �����, � ����� ������������ � ���
    {

       
        if (objectPool != null)
        {
            objectPool.ReturnGameObject(this.gameObject);
            gameData.enemyNum -= 1;

            Debug.Log("onEvwmyDisabled" + gameData.enemyNum + gameData.selectedObject.name);
        }
        
    }


}
