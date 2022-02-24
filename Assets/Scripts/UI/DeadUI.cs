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
    private void Awake()
    {
        newGameHelper.alpha = 0.0f;
        FadeIn(gameOverText);
        FadeIn(newGameHelper, true);



    }

    private void Update()
    {

        //tmp !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        if(Input.GetKeyDown(KeyCode.R))
        {
            FadeIn(gameOverText);
            FadeIn(newGameHelper, true);


        }
    }

    public void FadeIn(CanvasGroup text, bool offset = false)
    {
        
        StartCoroutine(FadeText(text, startValue,endValue,lerpTime, offset));
    }

    public void FadeOut(CanvasGroup text, bool offset = false)
    {
        StartCoroutine(FadeText( text, gameOverText.alpha, startValue,lerpTime, offset));
    }
    public IEnumerator FadeText(CanvasGroup text, float startValue, float endValue, float lerpTime, bool offset)
    {
        if(offset)
        {
            yield return new WaitForSeconds(0.5f);
        }
        
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
        
    }

}
