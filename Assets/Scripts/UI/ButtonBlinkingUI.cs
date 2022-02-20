using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent (typeof (CanvasGroup))]
public class ButtonBlinkingUI : MonoBehaviour
{
    #region Blinking Variables
    private CanvasGroup blinkingText; //welcomeText;
    [SerializeField] float blinkingSpeedFrame = 5.0f;
    
    
    private bool toBlink = false;
    #endregion

    private void Awake()
    {
        blinkingText = GetComponent<CanvasGroup>();
    }

    private void Update()
    {
        BlinkingSetup();
        
        
    }


    #region Blinking Functions

    private IEnumerator BlinkingSetup()
    {
        
        while (toBlink)
            {
            if (Time.frameCount % blinkingSpeedFrame == 0)
            {
                float noise = Random.Range(0f,1f);
                blinkingText.alpha = noise;
                //Debug.Log(noise + " " + blinkingText.alpha);
            }
                yield return null;
            }
           
            
            
           
        

    }
    public void Blinking()   // for welcomeText;
    {
        toBlink = true;
        
        StartCoroutine(BlinkingSetup());
        
    }

    public void StopBlinking()   // for welcomeText;
    {
        toBlink = false;
        StopCoroutine(BlinkingSetup());
        blinkingText.alpha = 1;
        
    }

    #endregion
}
