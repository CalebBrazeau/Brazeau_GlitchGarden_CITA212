using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    // base lives
    [SerializeField] float fltBaseLives = 3;
    // amount of damage to take from each attacker
    [SerializeField] int intDamage = 1;
    // Lives
    float fltLives;
    // Text for lives
    Text txtLives;

    void Start()
    {
        // sets the currents lives to the base amount of lives to the difficulty subracted from the base amount of lives
        fltLives = fltBaseLives - PlayerPrefsController.GetDifficulty();
        // to access the text component within the text field
        txtLives = GetComponent<Text>();
        UpdateDisplay();

    } // Start()

    private void UpdateDisplay()
    {
        // convert the integer star field to a string
        txtLives.text = fltLives.ToString();

    } // UpdateDisplay()

    public void TakeLife()
    {
        // decrease our lives by one
        fltLives -= intDamage;
        UpdateDisplay();
        if (fltLives <= 0)
        {
            // no lives remaining, go to LoseScreen
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }

    } // SpendStars()

} // class Lives
