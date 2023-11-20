using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCam : MonoBehaviour
{
    public float rotateSpeed = 1f;

    private void Update()
    {
        transform.eulerAngles += rotateSpeed * new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
    }
}
