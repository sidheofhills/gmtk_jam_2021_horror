using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherUI : MonoBehaviour
{

    [SerializeField] private GameObject leftSide;
    [SerializeField] private GameObject rightSide;
    [SerializeField] private GameObject container;
    private bool valueLeft;
    private bool valueRight;
    // Start is called before the first frame update
    void Start()
    {
        valueLeft = true;
        valueRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            valueLeft = !valueLeft;
            valueRight = !valueRight;
            leftSide.SetActive(valueLeft);
            rightSide.SetActive(valueRight);

        }
    }
}
