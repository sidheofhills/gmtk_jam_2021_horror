using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonSetHighlighted : MonoBehaviour
{
    [SerializeField] GameObject nameContainer;
    private Button[] buttonList;
    
    private void Awake()
    {
        buttonList = nameContainer.GetComponentsInChildren<Button>();
    }
    
    private void Update()
    {
        StartCoroutine(SetHighlighted());
    }
    IEnumerator SetHighlighted()
    {
        foreach (Button button in buttonList)
        {
            button.Select();
            button.OnSelect(null);

            yield return new WaitForSeconds(0.5f);
        }

        EventSystem.current.SetSelectedGameObject(null);
    }
}
