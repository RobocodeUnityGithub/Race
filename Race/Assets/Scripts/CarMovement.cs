using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] Transform centerMass;
    [SerializeField] private float motorTorque;
    [SerializeField] private Wheel[] wheels;
    [SerializeField] private float maxSteer;
    private float horizontal;
    private float vertical;
    private Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass -= rb.centerOfMass - new Vector3( 0,0.2f ,0);
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Vertical");
        vertical = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        foreach (var wheel in wheels)
        {
            wheel.SetMove(motorTorque * horizontal , vertical * maxSteer);
        }

    }
}
