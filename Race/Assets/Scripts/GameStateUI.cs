using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStateUI : MonoBehaviour
{
    [SerializeField] private Text stateText;
    [SerializeField] private Canvas stateCanvas;
    [SerializeField] private Image stateImage;
    [SerializeField] private Color winImageColor;
    [SerializeField] private Color loseImageColor;

    private bool isGameEnd;

    private void Start()
    {
        stateCanvas.enabled = false;
    }

    public bool IsGameEnd()
    {
        return isGameEnd;
    }

    public void SetLoseUI()
    {
        Time.timeScale = 0f;
        isGameEnd=true;

        stateImage.color = loseImageColor;
        stateText.text = "Lose";
        stateCanvas.enabled = true;
    }

    public void SetWinUI()
    {
        Time.timeScale = 0f;
        isGameEnd = true;

        BestTimeScore bestTimeScore = FindObjectOfType<BestTimeScore>();
        float currentScore = FindObjectOfType<TimeScoreCounter>().GetElapsedtime();

        bestTimeScore.SetNewScore(currentScore);
        stateImage.color = winImageColor;
        stateText.text = "Win";
        stateCanvas.enabled = true;
    }
}
