using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MyObjectReturn : MonoBehaviour
{
    

    // Start is called before the first frame update
    
    private ObjectPool_Simple myObjectPool;
    public GameData gameData;


    void Start()
    {
        myObjectPool = FindObjectOfType<ObjectPool_Simple>();
        
    }

    private void Update()
    {

    }


    private void OnDisable()  //������� ������ ��� ��� �������. � ���� ������ �� ����������� ��� �����, � ����� ������������ � ���
    {

       
        if (myObjectPool != null)
        {
            myObjectPool.ReturnMyObject(this.gameObject);
            gameData.enemyNum -= 1;

            Debug.Log("onEvwmyDisabled" + gameData.enemyNum + gameData.selectedObject);
        }
        
    }


}
