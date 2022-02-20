using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PentaWhiteAnimation : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    
    [SerializeField] GameData gameData;
    [SerializeField] bool on;  //pulsing
    
    private bool calledIt; //for single call in update
    private float lerpedValue;  
    public float LerpedValue  // is needed in pentaWhiteAudioManager
    {
        get   { return lerpedValue; }
        private set { lerpedValue = value; }
    }
    float time = 0.0f;

    [SerializeField] AnimationCurve appearingCurve;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }
    private void Update()
    {
        if (on) //pulsing
        {
            HighFrequecyPulsing();            
            if((!calledIt) && TryGetComponent<PentaWhiteAudioManager>( out PentaWhiteAudioManager pentaWhiteAudioManager))
            {                
                EventManager.TriggerEvent(gameData.OnWhitePentaDissapearing);
                calledIt = true;
            }
        }
    }

    private void HighFrequecyPulsing()
    {
        // sine function with decreasing amplitude and frequency
        // https://www.desmos.com/calculator/7zuxe7ynxc

        time += Time.deltaTime*0.99f;  // ось х
        float b = 5f;  //  функция сводится в 0, когда time=x
        float linearFunc = Mathf.Max( 1f / b * (-time - b * 4f) + 5f, 0);
        float expFunc = Mathf.Exp(time);
        float sineFunc = (0.5f * Mathf.Sin(0.5f * expFunc - 5f) + 0.5f) * linearFunc;

        lerpedValue = Mathf.Lerp(0, 1, sineFunc);  // типа клампа на случай если значения бы выпадали за границы 
        
        spriteRenderer.color = new Vector4(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, lerpedValue);
                                                              
        
    }
    public void OnPentaAppearing()
    {
        
        StartCoroutine(WhitePentaAppearing());
    }
    private IEnumerator WhitePentaAppearing()
    {
        gameData.startSpawn = false;
        float alpha = 0;
        float time = 0;
        MonsterMovement [] monsters = GameObject.FindObjectsOfType<MonsterMovement>();
        foreach(MonsterMovement monster in monsters)
        {
            monster.gameObject.SetActive(false);
        }
        while (alpha < 1)
        {
            time += Time.deltaTime;
            alpha = Mathf.Lerp(0f, 1f, appearingCurve.Evaluate(time));            
            spriteRenderer.color = new Vector4(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, alpha);
            yield return null;
        }

        EventManager.TriggerEvent(gameData.GameWin);

        
    }


    private void OnDisable()
    {        
    }

                                                              
}
