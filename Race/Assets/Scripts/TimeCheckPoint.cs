using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCheckPoint : CheckPoint
{
    [SerializeField] private float addTime;

    private void Awake()
    {
        meshRenderer = GetComponentInChildren<MeshRenderer>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponentInParent<CarMovement>() && isNext)
        {
            FindObjectOfType<Timer>().AddTime(addTime);
            FindObjectOfType<CheckPointsManager>().NextCheckPoint();
        }
    }
}
