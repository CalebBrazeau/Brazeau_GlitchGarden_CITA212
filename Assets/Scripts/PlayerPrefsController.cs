using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    // Names for the constants
    const string MASTER_VOLUME_KEY = "Master Volume";
    const string DIFFICULTY_KEY = "Difficulty";

    // minimum and maximum volume levels
    const float FLT_MIN_VOLUME = 0f;
    const float FLT_MAX_VOLUME = 1f;

    // min and max values for difficulty constant
    const float FLT_MIN_DIFFICULTY = 0f;
    const float FLT_MAX_DIFFICULTY = 2f;

    public static void SetMasterVolume(float fltVolume)
    {
        // if the volume is in the range set
        if (fltVolume >= FLT_MIN_VOLUME && fltVolume <= FLT_MAX_VOLUME)
        {
            // prints and sets what the user set the volume to
            print("Master volume set to " + fltVolume);
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, fltVolume);
        }
        else
        {
            // preints and error message if the volume set is out of range
            print("Master Volume is out of range");
        }
    }

    public static float GetMasterVolume()
    {
        // returns the volume value set in "MASTER_VOLUME_KEY"
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void SetDifficulty(float fltDifficulty)
    {
        // if the difficulty is in the range set
        if (fltDifficulty >= FLT_MIN_DIFFICULTY && fltDifficulty <= FLT_MAX_DIFFICULTY)
        {
            // sets "DIFFICULTY_KEY" to whatever is passed onto the method
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, fltDifficulty);
        }
        else
        {
            // prints an error message if difficulty set is too high
            print(" Difficulty Setting not it range");

        }
    }

    public static float GetDifficulty()
    {
        // returns whatever is set in "DIFFICULTY_KEY"
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
}
