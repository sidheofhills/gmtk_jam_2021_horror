using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class KnockUI : MonoBehaviour
{
    [SerializeField] private float animTime;
    [SerializeField] private GameObject container;
    public static bool HeKnocked { get; private set; }

    private void Awake()
    {
        container.gameObject.SetActive(true);
        HeKnocked = false;
        
    }
    
   
     public void OnClick()  //name of the func that will be called when buttom is clicked. must be publuc to be seen
    {
        StartCoroutine(KnockEvent());
        Debug.Log("clicked");
    }
    private IEnumerator KnockEvent()
    {
        Debug.Log("start waiting");
        yield return new WaitForSeconds(animTime);
        Debug.Log("end waitung");
        HeKnocked = true;
    Debug.Log("sent trigger");
        container.gameObject.SetActive(false);

    }
}
