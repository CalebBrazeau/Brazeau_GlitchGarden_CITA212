using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
    // amount of time to wait before changing scenes
    [SerializeField] float fltTimeToWait = 4;
    // variable to store current scene number
    int intcurrentSceneIndex;
    // Controls menu 
    [SerializeField] GameObject ControlsMenu;
    // Audio Source to play
    AudioSource m_LevelLoaded;

    // Use this for initialization
    void Start()
    {
        // Gets audio source component
        m_LevelLoaded = GetComponent<AudioSource>();
        // Deactivates the control menu
        ControlsMenu.SetActive(false);
        // sets variable to whatever the current scene is
        intcurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // if the scene number is equal to 0 it starts the timer before chaning scenes
        if (intcurrentSceneIndex == 0)
        {
            
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        // waits for time set at start of script
        yield return new WaitForSeconds(fltTimeToWait);
        LoadNextScene();
    }

    public void RestartScene()
    {
        // Adds 1 to the current scene index loading it to next scene
        SceneManager.LoadScene(intcurrentSceneIndex);
        // Sets Time Scale
        Time.timeScale = 1;
    }

    public void LoadMainMenu()
    {
        // Adds 1 to the current scene index loading it to next scene
        SceneManager.LoadScene("StartScreen");
        // Sets timescale
        Time.timeScale = 1;
    }

    public void LoadNextScene()
    {
        // Adds 1 to the current scene index loading it to next scene
        SceneManager.LoadScene(intcurrentSceneIndex + 1);
    }

    public void LoadYouLoseScene()
    {
        // Loads Specified scene
        SceneManager.LoadScene("LoseScreen");
    }

    public void QuitGame()
    {
        // Closes game application
        Application.Quit();
    }

    public void OpenControlsMenu()
    {
        // Opens Control Menu
        ControlsMenu.SetActive(true);
    }

    public void CloseControlsMenu()
    {
        // Closes Control Menu
        ControlsMenu.SetActive(false);
    }
} // class LevelLoader
