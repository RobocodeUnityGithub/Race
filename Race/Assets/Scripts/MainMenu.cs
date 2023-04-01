using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private int[] gameSceneIndxs;
   
    public void ExitGame()
    {
       Application.Quit();
    }

    public void LoadScene(int indxScene)
    {        
        FindObjectOfType<SceneLoad>().StartLoad(gameSceneIndxs[indxScene]);
    }
}
