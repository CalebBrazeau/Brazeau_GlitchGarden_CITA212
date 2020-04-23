using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{

    Defender1 defender;

    private void OnMouseDown()
    {
        // Calls to spawn defender and gets square clicked
        AttemptToPlaceDefenderAt(GetSquareClicked());
    }

    public void SetSelectedDefender(Defender1 defenderToSelect)
    {
        defender = defenderToSelect;
    }

    private void AttemptToPlaceDefenderAt(Vector2 gridPos)
    {
        // Finds an object with the "StarDisplay" script
        var StarDisplay = FindObjectOfType<StarDisplay>();
        // Gets the cost of whatever is set on the defender
        var defenderCost = defender.GetStarCost();
        // If there is enough stars the cover the cost of the defender
        if (StarDisplay.HaveEnoughStars(defenderCost))
        {
            // calls to spawn defender method
            SpawnDefender(gridPos);
            // Spends stars
            StarDisplay.SpendStars(defenderCost);

        }
    }

    private Vector2 GetSquareClicked()
    {
        // Gets position of mouse on click
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        // Converts clicked position to a point on the camera, somethin like that
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        // Passes worldpos to SnapToGrid so it can convert it to an integer
        Vector2 gridPos = SnapToGrid(worldPos);
        // Returns the world position of the mouse click
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        // Converts worldPos to an integer so defenders can spawn on a grid type thing
        float fltnewX = Mathf.RoundToInt(rawWorldPos.x);
        float fltnewY = Mathf.RoundToInt(rawWorldPos.y);
        // returns the rounded numbers
        return new Vector2(fltnewX, fltnewY);
    }

    private void SpawnDefender(Vector2 roundedPos)
    {
        Defender1 newDefender = Instantiate(defender, roundedPos, Quaternion.identity) as Defender1;
    }

}
