using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MyObjectReturn : MonoBehaviour
{
    

    
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
            
        }
        
    }


}
