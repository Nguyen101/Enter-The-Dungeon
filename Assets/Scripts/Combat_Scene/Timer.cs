using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLimit; // Set the time limit in seconds
    private float currentTime;

    public Text timerText; // Reference to a Text UI element to display the timer

    void Start()
    {
        currentTime = timeLimit;
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
            currentTime = 0; // Ensure currentTime doesn't go negative
            UpdateTimerDisplay();

            // Timer has reached zero, handle the end of the countdown here
        }
    }

    void UpdateTimerDisplay()
    {
        int seconds = Mathf.CeilToInt(currentTime); // Round up to nearest second
        timerText.text = "Timer: " + seconds.ToString() + "s"; // Display in seconds
    }
}
