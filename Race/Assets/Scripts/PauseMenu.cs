using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   [SerializeField] private int menuSceneIndx;

    public void ToMain()
    {
        Time.timeScale = 1f;
        FindObjectOfType<SceneLoad>().StartLoad(menuSceneIndx);
    }
}
