using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeadUI : MonoBehaviour
{
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private GameObject newGameHelper;
    private FadeInFadeOut fadeInFadeOut;

    [SerializeField] private float lerpTime;
    // Start is called before the first frame update
    private void Awake()
    {
        newGameHelper.GetComponent<CanvasGroup>().alpha = 0.0f;
        fadeInFadeOut = FindObjectOfType<FadeInFadeOut>();


        fadeInFadeOut.FadeIn(gameOverText, lerpTime);
        fadeInFadeOut.FadeIn(newGameHelper, lerpTime,true);

    }


}
