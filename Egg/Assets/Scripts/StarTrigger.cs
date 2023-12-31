using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTrigger : MonoBehaviour
{
    public GameObject winScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
