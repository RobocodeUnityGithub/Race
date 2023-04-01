using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestTimeScore : MonoBehaviour
{
    [SerializeField] protected int levelIndx;
    protected string levelName;

    private void Awake()
    {
        levelName = $"ScoreLevel{levelIndx}";
    }

    public void SetNewScore(float score)
    {
        float scoreTimeValue = PlayerPrefs.GetFloat(levelName);

        if (scoreTimeValue > score || scoreTimeValue == 0)
        {
            PlayerPrefs.SetFloat(levelName, score);
        }

    }
}
