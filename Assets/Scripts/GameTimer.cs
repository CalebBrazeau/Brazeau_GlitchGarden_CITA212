using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    // ToolTip
    [Tooltip("Amount of Level Time in Seconds")]
    // Amount of level Time
    [SerializeField] float fltLevelTime = 10f;
    bool boolTriggeredLevelFinished = false;

    // Update is called once per frame
    void Update()
    {
        if (boolTriggeredLevelFinished)
        {
            return;
        }

        // sets slider value to the amount of time the level has been loaded divided by amount of level time
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / fltLevelTime;

        // bool for if the timer is finished or not
        bool boolTimerFinished = (Time.timeSinceLevelLoad >= fltLevelTime);
        // if the bool is true
        if (boolTimerFinished)
        {
            // Finds LevelController scripts and accesses the LevelTimerFinished method
            FindObjectOfType<LevelController>().LevelTimerFinished();
            // sets level finished to true
            boolTriggeredLevelFinished = true;
        }
    }
}
