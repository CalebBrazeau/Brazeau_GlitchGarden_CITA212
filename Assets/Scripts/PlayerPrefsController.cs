using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "Master Volume";
    const string DIFFICULTY_KEY = "Difficulty";


    const float FLT_MIN_VOLUME = 0f;
    const float FLT_MAX_VOLUME = 1f;

    public static void SetMasterVolume(float fltVolume)
    {
        if (fltVolume >= FLT_MIN_VOLUME && fltVolume <= FLT_MAX_VOLUME)
        {
            print("Master volume set to " + fltVolume);
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, fltVolume);
        }
        else
        {
            print("Master Volume is out of range");
        }
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
}
