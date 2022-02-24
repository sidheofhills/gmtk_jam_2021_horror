using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PentaActivation : MonoBehaviour
{
    // this one is switching dark penta and white penta at the right time
    [SerializeField] GameData gameData;
    private SpriteRenderer[] pentaContainer;
    
    private void Awake()
    {
        pentaContainer = GetComponentsInChildren<SpriteRenderer>(true);  //does not guarantee a specific return order        
    }
    
    private void SwitchToWhite(bool yes)
    {
        pentaContainer[1].gameObject.SetActive(!yes);
        pentaContainer[2].gameObject.SetActive(yes);
    }
    private void Start()
    {
        SwitchToWhite(true);
    }

    private void OnSkip()
    {
        SwitchToWhite(false);
    }

    private void OnWhitePentaReappearing()
    {
        SwitchToWhite(true);
        GetComponentInChildren<PentaWhiteAnimation>().OnPentaAppearing();
    }
    private void OnEnable()
    {
        
        EventManager.StartListening(gameData.Skip, OnSkip);
        EventManager.StartListening(gameData.OnWhitePentaAppearing, OnWhitePentaReappearing);
    }

    private void OnDisable()
    {
        
        EventManager.StopListening(gameData.Skip, OnSkip);
        EventManager.StopListening(gameData.OnWhitePentaAppearing, OnWhitePentaReappearing);
    }


}
