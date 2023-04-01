using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButton : MonoBehaviour
{
    [SerializeField] private int menuSceneIndx;

    public void ToMainMenu()
    {
        Time.timeScale = 1f;
        FindObjectOfType<SceneLoad>().StartLoad(menuSceneIndx);
    }
}
