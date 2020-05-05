﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    // Volume slider
    [SerializeField] Slider volumeSlider;
    // Default value for volume
    [SerializeField] float fltDefaultVolume = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
    }

    // Update is called once per frame
    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer)
        {
            // volume to set music player to
            musicPlayer.SetVolume(volumeSlider.value);
        }
        else
        {
            print("No Music player found.... did you start from splash screen?");
        }
    }

    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        FindObjectOfType<LevelLoader>().LoadMainMenu();
    }

    public void SetDefaults()
    {
        volumeSlider.value = fltDefaultVolume;
    }
}