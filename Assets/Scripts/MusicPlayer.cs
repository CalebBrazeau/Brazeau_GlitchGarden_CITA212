using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        // Tells script to not destroy itself in the next load sequence
        DontDestroyOnLoad(this);
        // gets the audio source component
        audioSource = GetComponent<AudioSource>();
        // Sets audio sources volume to whatever the master volume value is
        audioSource.volume = PlayerPrefsController.GetMasterVolume();
    }

    public void SetVolume(float fltVolume)
    {
        audioSource.volume = fltVolume;
    }
}
