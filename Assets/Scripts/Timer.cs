using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameObject endScreen;
    public TextMeshProUGUI timer;
    public float timeLimit;
    public float time = 0;

    void Update()
    {
        if (time < timeLimit)
        {
            time += Time.deltaTime;
            DisplayTime(time);
        }
        else
        {
            timer.text = "Round Over!";
            endScreen.SetActive(true);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        //float seconds = Mathf.FloorToInt(timeToDisplay % 6);
        float seconds = timeToDisplay;
        timer.text = string.Format("{0:0}", seconds);
    }
}