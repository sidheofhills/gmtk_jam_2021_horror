using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClockUI : MonoBehaviour
{
    public GameData gameData;
    [SerializeField] TextMeshProUGUI timeText;

    private void Start()
    {
        SetInitialTime();
    }
    private void OnEnable()
    {
        EventManager.StartListening(gameData.OnMinute, UpdateTime);
        Debug.Log(TimeManager.Minute + "Minute");
        EventManager.StartListening(gameData.OnHour, UpdateTime);
        Debug.Log(TimeManager.Hour + "Hour");
    }
    private void OnDisable()
    {
        EventManager.StopListening(gameData.OnMinute, UpdateTime);
        Debug.Log(TimeManager.Minute + "MinuteUnsubsc");
        EventManager.StopListening(gameData.OnHour, UpdateTime);
        Debug.Log(TimeManager.Hour + "HourUnsubsc");
    }


    private void SetInitialTime()
    {
        timeText.text = $"{TimeManager.Hour:00}:{TimeManager.Minute:00}";
    }
        private void UpdateTime()
    {
        timeText.text = $"{TimeManager.Hour:00}:{TimeManager.Minute:00}";  //:00 ��� ����� �� ��, ����� ���� ���� � �������� ���� �����, ���� ���� 1 �����


        // ������� �������� ��������� �� ���� �� ������ ��� � � ���.��� - ������ ����� � ������ ���������
    }
}
