using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] protected bool isNext;
    [SerializeField] protected MeshRenderer meshRenderer;
    protected CheckPointsManager checkPointsManager;

    private void Start()
    {
        checkPointsManager = FindObjectOfType<CheckPointsManager>();
        meshRenderer = GetComponentInChildren<MeshRenderer>();
    }


    public void SetIsNext(bool setIsNext)
    {
        isNext = setIsNext;
        meshRenderer.enabled = setIsNext;
    }

    public bool IsNext()
    {
        return isNext;
    }


}
