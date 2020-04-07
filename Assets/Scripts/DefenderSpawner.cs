using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender1 defender;

    private void OnMouseDown()
    {
        AttepmtToPlaceDefender(GetSquareClicked());
    }

    public void SetSelectedDefender(Defender1 defenderToSelect)
    {
        defender = defenderToSelect;
    }

    private void AttepmtToPlaceDefender(Vector2 gridPos)
    {
        var starDispaly = FindObjectOfType<StarDisplay>();
        int defenderCost = defender.GetStarCost();
        //If there is enough stars
        if (starDispaly.HaveEnoughStars(defenderCost))
        {
            SpawnDefender(gridPos);
            starDispaly.SpendStars(defenderCost);
        }
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 roundedPos)
    {
        Defender1 newDefender = Instantiate(defender, roundedPos, Quaternion.identity) as Defender1;
    }
}
