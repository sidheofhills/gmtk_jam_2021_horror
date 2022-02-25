using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PentaDarkAnimation : MonoBehaviour
{
    // this one has different in and out animations
    [SerializeField] private GameData gameData;    
    private FadeInFadeOut fadeInFadeOut;
    private SpriteRenderer spriteRenderer;
    
    [SerializeField] private float lerpTime;
    [SerializeField] private bool addOffset;


    [SerializeField] AnimationCurve dissapearingCurve;

    private void Awake()
    {        
        fadeInFadeOut = FindObjectOfType<FadeInFadeOut>();
        spriteRenderer = GetComponent<SpriteRenderer>();  
    }
    private void DarkPentaAppearing()
    {        
        spriteRenderer.color = new Vector4(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 0.0f);
        fadeInFadeOut.FadeIn(this.gameObject, lerpTime);
    }

    private void OnSkip()
    {
        spriteRenderer.color = new Vector4(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1.0f);
    }

    private void OnPentaDisappearing()
    {
        StartCoroutine(DarkPentaDisappearing());
    }

    private IEnumerator DarkPentaDisappearing()
    {
        float alpha = 1;
        float time = 0;
        while (alpha > 0)
        {
            time += Time.deltaTime;
            alpha = Mathf.Lerp(0f,1f, dissapearingCurve.Evaluate(time));            
            spriteRenderer.color = new Vector4(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, alpha);
            yield return null;
        }
        
            EventManager.TriggerEvent(gameData.OnWhitePentaAppearing);
            this.gameObject.SetActive(false);
    }

    private void OnBlinkingPenta()
    {        
        StartCoroutine(DarkPentaBlinking());        
    }

    private IEnumerator DarkPentaBlinking()
    {
        gameData.startSpawn = false;
        float alpha = 1;
        float time = 0;
        while (alpha > 0)
        {
            time += Time.deltaTime*1.5f;
            alpha = Mathf.Lerp(0f, 1f, dissapearingCurve.Evaluate(time));            
            spriteRenderer.color = new Vector4(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, alpha);
            yield return null;
        }

        spriteRenderer.color = new Vector4(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1f);
        gameData.startSpawn = true;


    }

    private void OnEnable()
    {        
        EventManager.StartListening(gameData.OnDarkPentaAppearing, DarkPentaAppearing);
        EventManager.StartListening(gameData.Skip, OnSkip);
        EventManager.StartListening(gameData.FirstPhaseEnds, OnBlinkingPenta);
        EventManager.StartListening(gameData.SecondPhaseEnds, OnBlinkingPenta);
        EventManager.StartListening(gameData.ThirdPhaseEnds, OnBlinkingPenta);
        EventManager.StartListening(gameData.OnDarkPentaDisappearing, OnPentaDisappearing);
    }

    private void OnDisable()
    {
        EventManager.StopListening(gameData.OnDarkPentaAppearing, DarkPentaAppearing);
        EventManager.StopListening(gameData.Skip, OnSkip);
        EventManager.StopListening(gameData.FirstPhaseEnds, OnBlinkingPenta);
        EventManager.StopListening(gameData.SecondPhaseEnds, OnBlinkingPenta);
        EventManager.StopListening(gameData.ThirdPhaseEnds, OnBlinkingPenta);
        EventManager.StopListening(gameData.OnDarkPentaDisappearing, OnPentaDisappearing);
    }


}
