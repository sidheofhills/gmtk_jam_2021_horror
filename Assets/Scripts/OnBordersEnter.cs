using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBordersEnter : MonoBehaviour
{

    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("i've entered a border"+other.tag);

        if (other.tag == "enemy")
        {

            EventManager.TriggerEvent("borderEntranceEvent");
            


        }
    }
}
