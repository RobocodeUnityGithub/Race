using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    [SerializeField] private Slider loadSlider;
    [SerializeField] private Canvas loadCanvas;

    private void Start()
    {
        loadCanvas.enabled = false;
    }

    public void StartLoad(int indxScene)
    {
        StartCoroutine(LoadLevel(indxScene));
    }

    private IEnumerator LoadLevel(int indxScene)
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(indxScene);

        float progresValue =0;
        loadCanvas.enabled = true;
        loadSlider.value = progresValue;

        while (!loadOperation.isDone)
        {
            progresValue = Mathf.Clamp01(loadOperation.progress / 0.9f);
            loadSlider.value = progresValue;
            
            yield return null;
        }
    }
}
