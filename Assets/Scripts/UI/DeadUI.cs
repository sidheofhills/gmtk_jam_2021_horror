using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeadUI : MonoBehaviour
{
    [SerializeField] private CanvasGroup gameOverText;
    [SerializeField] private CanvasGroup newGameHelper;

    [SerializeField] private float startValue = 0.0f;
    [SerializeField] private float endValue = 1.0f;
    [SerializeField] private float lerpTime;
    // Start is called before the first frame update

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            FadeIn();
            
            Glitch(newGameHelper);
        }
    }
    private void OnEnable()
    {
        Debug.Log("i'm enabled");
        FadeIn();
        
        Glitch(newGameHelper);
    }

    public void FadeIn()
    {
        StartCoroutine(FadeText(gameOverText, startValue,endValue,lerpTime));
    }

    public void FadeOut()
    {
        StartCoroutine(FadeText(gameOverText, gameOverText.alpha, startValue,lerpTime));
    }
    public IEnumerator FadeText(CanvasGroup text, float startValue, float endValue, float lerpTime)
    {
        Debug.Log("starting to fade");
        float _timeStartedLerping = Time.time;
        float timeSinceStarted = Time.time - _timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;
        while (true)
        {
            timeSinceStarted = Time.time - _timeStartedLerping;
            percentageComplete = timeSinceStarted / lerpTime;

            float currentValue = Mathf.Lerp(startValue, endValue, percentageComplete);

            text.alpha = currentValue;

            if (percentageComplete >= 1) break;
            yield return new WaitForEndOfFrame();
        }
        Debug.Log("done");
    }

    private IEnumerator Glitch(CanvasGroup text)  //YET TO BE DONE BUT NOT NOW, SEE LINK https://www.youtube.com/watch?v=FgWVW2PL1bQ
    {
        text.alpha = 0; ;
        yield return new WaitForSeconds(lerpTime);
        text.alpha = 1* Random.Range(startValue, endValue);
    }

}
