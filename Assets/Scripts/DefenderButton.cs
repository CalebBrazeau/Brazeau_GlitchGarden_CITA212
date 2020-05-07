using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;

    void Start()
    {
        LabelButtonWithCost();
    }

    private void LabelButtonWithCost()
    {
        // gets text component on children
        Text costText = GetComponentInChildren<Text>();
        // if there is no costText
        if (!costText)
        {
            // prints the error to the console
            print(name + "Has no cost text... add some");
        }
        else
        {
            // sets the costText to whatever is set in the defender prefab as their cost
            costText.text = defenderPrefab.GetStarCost().ToString();
        }
    }
    private void OnMouseDown()
    {
        // create a temporary variable to store our DefenderButtons
        var buttons = FindObjectsOfType<DefenderButton>();
        // Iterate through the collection of DefenderButtons
        foreach (DefenderButton button in buttons)
        {
            // Change the color of a button in the collection
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
        }
        // change the color of the defenders in the background
        GetComponent<SpriteRenderer>().color = Color.white;
        // when called, we will know what to pass in when a defender is spawned
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);

    } // OnMouseDown

} // class DefenderButton
