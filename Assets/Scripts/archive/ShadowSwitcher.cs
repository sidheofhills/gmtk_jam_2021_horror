using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowSwitcher : MonoBehaviour
{
     private Transform[] allChildren;

    private void Awake()
    {
        allChildren = GetComponentsInChildren<Transform>();
        if(allChildren[1].TryGetComponent<LampLight>(out LampLight lampLight))
        {
            //Debug.Log("this is light " + allChildren[1].name);
        }
        else
        {
            //Debug.Log("wrong order. this is " + allChildren[1].name + "in "+ allChildren[0].name + ", not light");
        }
            
    }

    public void ShadowSwitch()
    {
        
            allChildren[2].gameObject.SetActive(!allChildren[1].gameObject.activeInHierarchy);
        
    }
}
  