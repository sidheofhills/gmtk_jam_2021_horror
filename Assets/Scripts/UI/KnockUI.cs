using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class KnockUI : MonoBehaviour  //не обязаьеьный скрипт  с исчезающей кнопкой
{
    [SerializeField] private float animTime;
    [SerializeField] private GameObject container;
    [SerializeField] GameData gameData;

    private void Awake()
    {
        
        container.gameObject.SetActive(true);
        
        
    }
    
   
     public void OnClick()  //name of the func that will be called when buttom is clicked. must be publuc to be seen
    {
        StartCoroutine(KnockEvent());        
    }
    private IEnumerator KnockEvent()
    {
        //cutScene On
        
        yield return new WaitForSeconds(animTime);
        
        container.gameObject.SetActive(false);

    }
    private void OnSkip()
    {
        container.gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        EventManager.StartListening(gameData.Skip, OnSkip);
    }

    private void OnDisable()
    {
        EventManager.StopListening(gameData.Skip, OnSkip);
    }
}
