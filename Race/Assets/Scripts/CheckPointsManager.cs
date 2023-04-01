using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPointsManager : MonoBehaviour
{
    [SerializeField] private Text lapText;
    [SerializeField] private int maxLap;
    [SerializeField] private CheckPoint[] _checkPoints;
    private int _currentIndx = 0;

    private int currentlap;

    private void Start()
    {
        currentlap = 1;
        UpdateUI();
        ResetAllCheckPoint();
    }

    private void ResetAllCheckPoint()
    {
        _currentIndx = 0;
        for(int i = 1; i < _checkPoints.Length; i++)
        {
            _checkPoints[i].SetIsNext(false);
        }
        _checkPoints[_currentIndx].SetIsNext(true);

    }

    public void NextCheckPoint()
    {
        _checkPoints[_currentIndx].SetIsNext(false);
        _currentIndx++;

        if(_checkPoints.Length > _currentIndx)
        {
            _checkPoints[_currentIndx].SetIsNext(true);
        }
        else
        {
            ResetAllCheckPoint();
            currentlap++;

            if (currentlap > maxLap)
            {
                FindObjectOfType<GameStateUI>().SetWinUI();
            }
            else
            UpdateUI();
        }
    }

    private void UpdateUI()
    {
        lapText.text = $"Lap: {currentlap} / {maxLap}";
    }
}
