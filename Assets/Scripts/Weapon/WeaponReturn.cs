using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponReturn : MonoBehaviour
{

    private WeaponObjectPool_Simple objectPool;
    public GameData gameData;
    [SerializeField] private float secondsToFadeOut = 1.0f;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        objectPool = FindObjectOfType<WeaponObjectPool_Simple>();
    }

    private void OnEnable()
    {
        StartCoroutine(WaitingBeforeReturn());
    }

    private IEnumerator WaitingBeforeReturn()
    {

        // play dissolve animation
        float time = 0;
        Color startValue = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1);
        Color endValue = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 0);
        while (time<secondsToFadeOut)
        {
            spriteRenderer.color = Color.Lerp(startValue, endValue, time / secondsToFadeOut);
            time += Time.deltaTime;
            yield return null;
        }
        

        objectPool.ReturnGameObject(this.gameObject);  

    }    
}
