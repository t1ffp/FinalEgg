using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CamFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void Update()
    {
        transform.position = new Vector3(target.position.x + offset.x, target.position.y + offset.y, target.position.z + offset.z);
    }
}
