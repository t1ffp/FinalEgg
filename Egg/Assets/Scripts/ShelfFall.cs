using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfFall : MonoBehaviour
{
    public GameObject stopper;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            stopper.SetActive(false);
        }
    }
}
