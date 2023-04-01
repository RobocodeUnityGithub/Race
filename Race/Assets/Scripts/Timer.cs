using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text timerText;
    [SerializeField] private float startTimeValue;
    private float currentTimeValue;
    private bool isGo;

    private void Start()
    {
        currentTimeValue = startTimeValue;
        DisplayTime();
        isGo= true;
    }

    private void Update()
    {
        if (isGo) 
        {
            if (currentTimeValue > 0)
            {
                currentTimeValue -= Time.deltaTime;
            }
            else
            {
                currentTimeValue= 0;
                isGo = false;
                FindObjectOfType<GameStateUI>().SetLoseUI();
            }

            DisplayTime();
        }
    }

    public void AddTime(float addTime)
    {
        currentTimeValue += addTime;
    }

    private void DisplayTime()
    {
        float minutes = Mathf.FloorToInt(currentTimeValue / 60);
        float seconds = Mathf.FloorToInt(currentTimeValue % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
