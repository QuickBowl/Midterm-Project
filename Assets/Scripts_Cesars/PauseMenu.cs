using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenu;
    private bool isPaused = false;
    // Start is called before the first frame update
    void Start() {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (isPaused) {
                Resume();
            } else {
                Paused();
            }
        }
    }

    public void Paused() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    } 

    public void Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Exit() {
        Application.Quit();
    }
}
