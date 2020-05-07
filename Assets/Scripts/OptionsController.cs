using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    // Volume slider
    [SerializeField] Slider volumeSlider;
    // Default value for volume
    [SerializeField] float fltDefaultVolume = 0.8f;

    // Difficulty slider
    [SerializeField] Slider difficultySlider;
    // Default value for difficulty
    [SerializeField] float fltDefaultDifficulty = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // sets the slider value to whatever is stored in the master volume method
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
        // sets the slider value to whatever is stored in the difficulty method
        difficultySlider.value = PlayerPrefsController.GetDifficulty();
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
        // Sets whatever is the current value in the slider to the value stored in "SetMasterVolume"
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        // Sets whatever is the current value in the slider to the value stored in "SetDifficuly"
        PlayerPrefsController.SetDifficulty(difficultySlider.value);
        FindObjectOfType<LevelLoader>().LoadMainMenu();
    }

    public void SetDefaults()
    {
        // Sets the slider to the default value
        volumeSlider.value = fltDefaultVolume;
        difficultySlider.value = fltDefaultDifficulty;
    }
}
