using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    // sets number of attackers variable to 0
    int intNumberOfAttackers = 0;
    // Sets bool to false
    bool boolLevelTimerFinished = false;

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
            // prints this to console
            print("End Level Now");
        }
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

    void Start()
    {
        
    }

}
