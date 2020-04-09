using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{

    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        // Calls to spawn defender and gets square clicked
        SpawnDefender(GetSquareClicked());
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
        // Object to spawn and where to spawn it
        GameObject newDefender = Instantiate(defender, roundedPos, Quaternion.identity) as GameObject;
    }

}