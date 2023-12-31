using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogActive : MonoBehaviour
{
    public GameObject dog;
    public GameObject dogText;

    public GameObject barkingAudio;

    private void Start()
    {
        dog.GetComponent<EnemyController>().enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dog.GetComponent<EnemyController>().enabled = true;
            dogText.SetActive(true);
            barkingAudio.SetActive(true);
            Destroy(gameObject);
        }
    }
}
