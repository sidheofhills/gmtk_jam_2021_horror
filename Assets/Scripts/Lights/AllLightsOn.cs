using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllLightsOn : MonoBehaviour
{
    [SerializeField] private GameObject mainLampsContainer;

    private void Start()
    {
        LampLight[] lampStorage = mainLampsContainer.GetComponentsInChildren<LampLight>();

        foreach(LampLight lamp in lampStorage)
        {
            lamp.LightOn = 1;
        }
    }


}
