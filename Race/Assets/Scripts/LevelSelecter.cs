using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelSelecter : MonoBehaviour
{
    [SerializeField] private Canvas levelSelecterCanvas;

    private void Start()
    {
        SetActiveCanvas(false);
    }

    public void SetActiveCanvas(bool isActive)
    {
        levelSelecterCanvas.enabled = isActive;
    }

}
