using UnityEngine;
using System;
using TMPro;

public class DisplayTime : MonoBehaviour
{
    private TextMeshProUGUI timeDisplay;
    private DateTime currentTime;

    private void Start()
    {
        timeDisplay = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        currentTime = DateTime.Now;
        timeDisplay.text = currentTime.ToString("T");
    }
}
