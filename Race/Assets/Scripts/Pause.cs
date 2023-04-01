using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField] private Canvas canvasPause;
    private bool isPaused = false;
    private GameStateUI gameStateUI;

    private void Start()
    {
        canvasPause.enabled = false;
        gameStateUI =FindObjectOfType<GameStateUI>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && gameStateUI.IsGameEnd() == false)
        {
            if (!isPaused)
            {
                Time.timeScale = 0f;
                isPaused = true;
            }
            else
            {
                Time.timeScale = 1f;
                isPaused = false;
            }

            canvasPause.enabled = isPaused;
        }
    }
}

