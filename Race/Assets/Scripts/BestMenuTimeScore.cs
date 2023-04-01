using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestMenuTimeScore : BestTimeScore
{
    [SerializeField] private Text scoreText;

    private void Awake()
    {
        levelName = $"ScoreLevel{levelIndx}";
        float scoreTimeValue  = PlayerPrefs.GetFloat(levelName);

        float minutes = Mathf.FloorToInt(scoreTimeValue / 60);
        float seconds = Mathf.FloorToInt(scoreTimeValue % 60);

        scoreText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
