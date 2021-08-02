using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClockUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText;

    private void Start()
    {
        SetInitialTime();
    }
    private void OnEnable()
    {
        EventManager.StartListening("onMinuteEvent", UpdateTime);
        Debug.Log(TimeManager.Minute + "Minute");
        EventManager.StartListening("onHourEvent", UpdateTime);
        Debug.Log(TimeManager.Hour + "Hour");
    }
    private void OnDisable()
    {
        EventManager.StopListening("onMinuteEvent", UpdateTime);
        Debug.Log(TimeManager.Minute + "MinuteUnsubsc");
        EventManager.StopListening("onHourEvent", UpdateTime);
        Debug.Log(TimeManager.Hour + "HourUnsubsc");
    }


    private void SetInitialTime()
    {
        timeText.text = $"{TimeManager.Hour:00}:{TimeManager.Minute:00}";
    }
        private void UpdateTime()
    {
        timeText.text = $"{TimeManager.Hour:00}:{TimeManager.Minute:00}";  //:00 ıòî ìàñêà íà òî, ÷òîáû ğåìÿ áûëî â ïğåäåëàõ äâóõ íóëåé, äàæå åñëè 1 öèôğà


        // ÑÄÅËÀÒÜ ÌÈÃÀŞÙÅÅ ÄÂÎÅÒÎ×ÈÅ ÏÎ ÒÎÌÓ ÆÅ ÒÓÒÎĞÓ ×ÒÎ È Â ÄİÄ.ŞÀÉ - ÏĞÎÑÒÎ ÑÈÍÓÑ Â ÒĞÅÒÈÉ ÊÎÌÏÎÍÅÍÒ
    }
}
