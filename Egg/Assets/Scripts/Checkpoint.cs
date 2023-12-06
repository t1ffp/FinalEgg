using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject player;
    public Vector3 vectorPoint;
    public bool hasCheckpoint = false;
    public GameObject checkpointText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            vectorPoint = player.transform.position;
            Destroy(other.gameObject);
            hasCheckpoint = true;
            checkpointText.SetActive(true);
        }
    }
}
