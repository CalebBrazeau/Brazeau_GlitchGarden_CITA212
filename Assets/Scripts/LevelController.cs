using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    // Level Complete canvas
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;
    // sets number of attackers variable to 0
    int intNumberOfAttackers = 0;
    // Time to wait
    [SerializeField] float fltWaitToLoad = 5f;
    // Sets bool to false
    bool boolLevelTimerFinished = false;

    void Start()
    {
        // Turns the winLabel off
        winLabel.SetActive(false);
        loseLabel.SetActive(false);
    }

    public void AttackerSpawned()
    {
        // Adds one to number of attackers variable
        intNumberOfAttackers++;
    }

    public void AttackerKilled()
    {
        // subtracts 1 from the number of attackers variable
        intNumberOfAttackers--;
        // if the number of attackers is less than or equal to 0 and the level timer is finished
        if (intNumberOfAttackers <= 0 && boolLevelTimerFinished)
        {

            StartCoroutine(HandleWinCondition());
        }
    }

    IEnumerator HandleWinCondition()
    {
        // Turns the winLabel on 
        winLabel.SetActive(true);
        // Gets audio source component and plays audio source
        GetComponent<AudioSource>().Play();
        // Waits set time
        yield return new WaitForSeconds(fltWaitToLoad);
        // Loads next scene 
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }

    public void HandleLoseCondition()
    {
        loseLabel.SetActive(true);
        Time.timeScale = 0;
    }

    public void LevelTimerFinished()
    {
        boolLevelTimerFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {

        // makes an array for each spawner in the scene
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        // for every spawner in the array
        foreach (AttackerSpawner spawner in spawnerArray)
        {
            // calls to stop spawning in the spawners
            spawner.StopSpawning();
        }

    }

} // class LevelController
