using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private Vector3 respawnPosition;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetRespawnPosition(Vector3 position)
    {
        respawnPosition = position;
        Debug.Log("Respawn position set to: " + respawnPosition);
    }


    public void RespawnPlayer(GameObject player)
    {
        player.transform.position = respawnPosition;
    }
}
