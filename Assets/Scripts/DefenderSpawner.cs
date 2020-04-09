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
        // Returns the world position of the mouse click
        return worldPos;
    }

    private void SpawnDefender(Vector2 worldPos)
    {
        // Object to spawn and where to spawn it
        GameObject newDefender = Instantiate(defender, worldPos, Quaternion.identity) as GameObject;
    }

}