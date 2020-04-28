using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    // Sets amount of player lives
    [SerializeField] int intLives = 3;
    [SerializeField] int intDamage = 1;
    Text txtLivesText;

    void Start()
    {
        // Gets Lives Text Component
        txtLivesText = GetComponent<Text>();
        // Calls to update display
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        // Converts lives integer variable to ToString
        txtLivesText.text = intLives.ToString();
    }

    public void TakeLife()
    {
        // amount of lives to take away
        intLives -= intDamage;
        UpdateDisplay();

        if (intLives <= 0)
        {
            FindObjectOfType<LevelLoad>().LoadYouLoseScene();
        }
    }

}
