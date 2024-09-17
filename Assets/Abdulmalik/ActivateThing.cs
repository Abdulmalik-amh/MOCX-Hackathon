using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateThing : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    public GameObject objectToActivate;

    private bool button1Pressed = false;
    private bool button2Pressed = false;
    private bool button3Pressed = false;

    private bool sequenceCompleted = false;

    void Start()
    {
        button1.onClick.AddListener(Button1Pressed);
        button2.onClick.AddListener(Button2Pressed);
        button3.onClick.AddListener(Button3Pressed);
    }

    void Update()
    {
        // Check for correct sequence
        if (button1Pressed && button2Pressed && button3Pressed && !sequenceCompleted)
        {
            sequenceCompleted = true;
            ActivateObject();
        }
    }

    void Button1Pressed()
    {
        button1Pressed = true;
        button2Pressed = false;
        button3Pressed = false;
    }

    void Button2Pressed()
    {
        if (button1Pressed)
        {
            button2Pressed = true;
        }
    }

    void Button3Pressed()
    {
        if (button1Pressed && button2Pressed)
        {
            button3Pressed = true;
        }
    }

    void ActivateObject()
    {
        objectToActivate.SetActive(true);
    }
}