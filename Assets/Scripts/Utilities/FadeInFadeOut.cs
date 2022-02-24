using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

                                                             
public class FadeInFadeOut : MonoBehaviour
{
    [SerializeField] private float startValue = 0.0f;
    [SerializeField] private float endValue = 1.0f;
    
    public void FadeIn(GameObject fadeObject, float lerpTime, bool offset = false)  // could be done with generics
    {

        StartCoroutine(FadeText(fadeObject, startValue, endValue, lerpTime,  offset));
    }

    public void FadeOut(GameObject fadeObject, float lerpTime, bool offset = false)
    {
        StartCoroutine(FadeText(fadeObject, endValue, startValue, lerpTime, offset));  //watch transparent alpha
    }
    private IEnumerator FadeText(GameObject fadeObject, float startValue, float endValue, float lerpTime, bool offset)
    {
        if (offset)
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

            if (fadeObject.TryGetComponent<CanvasGroup>(out CanvasGroup fadeObjectCanvas))
            {
                fadeObjectCanvas.alpha = currentValue;
            }
            else
            {
                SpriteRenderer fadeObjectSprite = fadeObject.GetComponent<SpriteRenderer>();
                fadeObjectSprite.color = new Vector4(fadeObjectSprite.color.r, fadeObjectSprite.color.g, fadeObjectSprite.color.b, currentValue);
            }


            if (percentageComplete >= 1) break;
            yield return new WaitForEndOfFrame();
        }

    }
}
