using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckFall : MonoBehaviour
{
    PlayerController egg;
    private float distanceFallen;

    private Vector3 startPosition;

    public GameObject endScreen;

    public bool inWater;

    public AudioSource crackSound;
    public GameObject crackAudio;

    Checkpoint playerCheckpoint;
    public GameObject respawnButton;

    void Start()
    {
        startPosition = transform.position;
        egg = GetComponent<PlayerController>();
        playerCheckpoint = GetComponent<Checkpoint>();
    }

    void Update()
    {

        if (egg.grounded || inWater)
        {
            startPosition = transform.position;
        }
        else
        {
            distanceFallen = startPosition.y - transform.position.y;
        }

        if (distanceFallen >= 3 && !inWater)
        {
            StartCoroutine(GameOver());
        }

    }

    private IEnumerator GameOver()
    {
        yield return new WaitForSeconds(0.5f);
        endScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        egg.speed = 0f;

        if (egg.grounded && !crackSound.isPlaying)
        {
            crackSound.Play();
            Destroy(crackSound, 0.1f);
        }
     
        if (!playerCheckpoint.hasCheckpoint)
        {
            respawnButton.SetActive(false);
        }
 
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            inWater = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Water"))
        {

            inWater = false;
        }
    }

    
    public void RespawnAtCheckpoint()
    {
        endScreen.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        transform.position = playerCheckpoint.vectorPoint;
        egg.speed = 4f;

    }

}









    // Start is called before the first frame update
    /* 
     void Start()
     {
         rb = GetComponent<Rigidbody>();
         egg = GetComponent<PlayerController>();

     }

     // Update is called once per frame
     void Update()
     {
         CheckIfFalling();

     }

     void CheckIfFalling()
     {
         if (!egg.grounded)
         {
             Debug.Log("not grounded");
             fallTimer -= Time.deltaTime;
         }
         else
         {
             fallTimer = 1f;
         }

         if (fallTimer <= 0f)
         {
             Debug.Log("timer ended");
             TimerEnded();
         }

     }

     void TimerEnded()
     {
         if (egg.grounded == true)
         {
             Debug.Log("hit");
         }
     }

     */

