using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TImer : MonoBehaviour
{
    [Header("Component")] 
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")] 
    public float currentTime;
    public bool countUp;

    [Header("Format Settings")] 
    public bool hasFormat;
    public TimerFormats format;

    private Dictionary<TimerFormats, string> timeFormats = new Dictionary<TimerFormats, string>();
    // Start is called before the first frame update
    void Start()
    {
        timeFormats.Add(TimerFormats.Cele,"0");
        timeFormats.Add(TimerFormats.Desetiny,"0.0");
        timeFormats.Add(TimerFormats.Setiny,"0.00");
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = countUp ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        timerText.text = hasFormat ? currentTime.ToString(timeFormats[format]) : currentTime.ToString();
    }
}

public enum TimerFormats
{
    Cele,
    Desetiny,
    Setiny
}
