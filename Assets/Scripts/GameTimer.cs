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

    // Update is called once per frame
    void Update()
    {
        // sets slider value to the amount of time the level has been loaded divided by amount of level time
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / fltLevelTime;

        // bool for if the timer is finished or not
        bool boolTimerFinished = (Time.timeSinceLevelLoad >= fltLevelTime);
        // if the bool is true
        if (boolTimerFinished)
        {
            // (temp) prints this to see if timer ever finishes
            print("Level Timer Expired");
        }
    }
}
