using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{
    public Rigidbody rb;
    public float depthBeforeSubmerged = 1f;
    public float displacementAmount = 3f;

    CheckFall checkWater;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        checkWater = GetComponent<CheckFall>();
    }
    private void FixedUpdate()
    {
        if(transform.position.y < 8.4925f && checkWater.inWater)
        {
            float displacementMultiplier = Mathf.Clamp01(transform.position.y / depthBeforeSubmerged) * displacementAmount;
            rb.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), ForceMode.Acceleration);
        }
    }
}
