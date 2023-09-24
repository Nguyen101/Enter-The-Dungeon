using UnityEngine;
using UnityEngine.UI; // You'll need this for UI elements

public class Timer : MonoBehaviour
{
    public float timeLimit = 60.0f; // Set the time limit in seconds
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
            // Timer has reached zero, handle the end of the countdown here
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = timeString; // Update the UI element with the current time
    }
}
