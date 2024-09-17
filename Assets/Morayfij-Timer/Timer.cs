using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText; // Reference to the   

    public float countdownTime = 60f; // Initial countdown time in seconds

    private float timeLeft;

    void Start()
    {
        timeLeft = countdownTime;
        UpdateTimerText();
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            // Countdown has finished
            Debug.Log("Countdown finished!");
            // You can add your desired actions here, such as triggering an event or disabling the script
            enabled = false;
        }

        UpdateTimerText();
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timeLeft / 60);
        int seconds = Mathf.FloorToInt(timeLeft % 60);

        string
 timerTextFormatted = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = timerTextFormatted;
    }
}
