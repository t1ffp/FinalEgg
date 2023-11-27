using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class MenuScreen : MonoBehaviour
{
    public GameObject pauseScreen;
    public GameObject pauseButton;
    public bool isPaused;
    public GameObject startText;
    public GameObject titleText;

    public GameObject mainCam;
    public GameObject secondCam;

    private bool canPause = false;

    // Update is called once per frame

    private void Start()
    {
        isPaused = false;
        startText.SetActive(true);
        Time.timeScale = 0f;
        mainCam.SetActive(false);
        secondCam.SetActive(true);
        canPause = false;

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) &&canPause)
        {
            if(isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            startText.SetActive(false);
            titleText.SetActive(false);    
            mainCam.SetActive(true);
            secondCam.SetActive(false);
            Time.timeScale = 1f;
            canPause = true;
        }
    }

    public void Resume()
    {
        pauseButton.SetActive(true);
        pauseScreen.SetActive(false);
        Time.timeScale = 1.0f;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Pause()
    {
        pauseButton.SetActive(false);
        pauseScreen.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
