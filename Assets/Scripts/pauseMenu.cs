using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public int playerNum;

    public GameObject pauseMenuUI;
    public GameObject gameUI;


    void Update () {
        if (Input.GetButtonDown("Start_" + playerNum))
        {
            if (GameIsPaused)
            {
                Resume();

            } else
            {
                Pause();
            }
        }
	}

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        gameUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        gameUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
