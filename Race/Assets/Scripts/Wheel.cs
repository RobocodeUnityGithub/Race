using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    [SerializeField] private bool isFront;
    [SerializeField] private Transform wheelTransofrm;
    private WheelCollider wheelCollider;

    private void Start()
    {
        wheelCollider = GetComponent<WheelCollider>();  
    }

    void Update()
    {
        wheelCollider.GetWorldPose(out Vector3 pos, out Quaternion rotate);
        wheelTransofrm.position = pos;
        wheelTransofrm.rotation = rotate * Quaternion.Euler(0, 90, 0);
    }

    public void SetMove(float motor, float steerAngle)
    {
        wheelCollider.motorTorque = motor;
        if(isFront)
        wheelCollider.steerAngle = steerAngle;
    }
}
