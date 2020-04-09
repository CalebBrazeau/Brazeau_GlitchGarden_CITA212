using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    //[SerializeField] Defender1 defenderPrefab;

    private void OnMouseDown()
    {
        // Finds the object clicked
        var buttons = FindObjectsOfType<DefenderButton>();
        // for each button on button it decides which one you clicked
        foreach (DefenderButton button in buttons)
        {
            // Sets the color to white so you can see it is selected
            button.GetComponent<SpriteRenderer>().color = new Color32(63, 63, 63, 255);
        }
        // Gets the component for the spriterenderer so it can change its color
        GetComponent<SpriteRenderer>().color = Color.white;
        //FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }
}
