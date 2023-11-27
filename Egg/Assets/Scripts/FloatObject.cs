using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatObject : MonoBehaviour
{
    public Rigidbody rb;
    public float depthBeforeSubmerged = 1f;
    public float displacementAmount = 3f;

  

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }
    private void FixedUpdate()
    {
        if (transform.position.y < 8.4925f)
        {
            float displacementMultiplier = Mathf.Clamp01(transform.position.y / depthBeforeSubmerged) * displacementAmount;
            rb.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), ForceMode.Acceleration);
        }
    }
}
