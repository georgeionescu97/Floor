using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Timer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;
    public TextMeshProUGUI TimerTxt;
    public Canvas loseGame;
   
    void Start()
    {
        TimerOn = true;
        loseGame.enabled = false;
    }

    
    void FixedUpdate()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                UpdateTimer(TimeLeft);
            }

            else
            {
                TimeLeft = 0;
                TimerOn = false;
                loseGame.enabled = true;
                Time.timeScale = 0;
            }
        }
    }

    void UpdateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
