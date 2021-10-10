using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LampLight : MonoBehaviour
{
    
    [FormerlySerializedAs("isLeftLamp")] [SerializeField] private bool leftLamp;      
    public bool LeftLamp => leftLamp;
    public bool LightOn { get; set; }
    public float TimeDuration { get; set; }

    [SerializeField] private Shader[] shadersToChooseFrom;
    public Shader[] ShadersToChooseFrom => shadersToChooseFrom;
    public Shader CurrentShader { get; set; }
    
    private LightManager lightManager;

    private void Start()
    {
        lightManager = FindObjectOfType<LightManager>();
        this.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        StartCoroutine(WhenLightIsOn()); 
    }

    private IEnumerator WhenLightIsOn()
    {
        yield return new WaitForSeconds(TimeDuration);
        LightOn = false;  // maybe i don't even need this and could use only setActive instead
        lightManager.LampEnqueue(this);
        this.gameObject.SetActive(false);
    }
        
}
