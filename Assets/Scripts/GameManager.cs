using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour
{
    public bool recording = true;

    private bool isPaused = false;
    private float fixedDeltaTime;

    void Start()
    {
        fixedDeltaTime = Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButton("Fire1"))
        {
            recording = false;
        }
        else
        {
            recording = true;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            PauseGame();
        }
    }

    void PauseGame()
    {
        if (!isPaused)
        {
            Time.timeScale = 0f;
            Time.fixedDeltaTime = 0f;
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1f;
            Time.fixedDeltaTime = fixedDeltaTime;
            isPaused = false;
        }
    }
}
