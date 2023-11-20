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

    void Start()
    {
        startPosition = transform.position;
        egg = GetComponent<PlayerController>();
    }

    void Update()
    {
        
        if (egg.grounded)
        {
            startPosition = transform.position;
        }
        else
        {
            distanceFallen = startPosition.y - transform.position.y;
        }

       if (distanceFallen >= 3)
        {
            StartCoroutine(GameOver());
        }

    }

    private IEnumerator GameOver()
    {
        yield return new WaitForSeconds(0.5f);
        endScreen.SetActive(true);
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
}
