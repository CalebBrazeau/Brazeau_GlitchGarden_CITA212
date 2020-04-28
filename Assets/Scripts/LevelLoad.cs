using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour {
    // amount of time to wait before changing scenes
    [SerializeField] int inttimeToWait = 4;
    // variable to store current scene number
    int intcurrentSceneIndex;

	// Use this for initialization
	void Start () {
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
        yield return new WaitForSeconds(inttimeToWait);
        // calls to load scene method
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        // Adds 1 to the current scene index loading it to next scene
        SceneManager.LoadScene(intcurrentSceneIndex + 1);
    }

    public void LoadYouLoseScene()
    {
        // Loads Specified scene
        SceneManager.LoadScene("Lose Screen");
    }

	// Update is called once per frame
	void Update () {

	}
}