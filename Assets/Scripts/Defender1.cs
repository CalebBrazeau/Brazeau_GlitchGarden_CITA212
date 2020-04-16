using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender1 : MonoBehaviour
{
    // Amount of stars the selected defender costs
    [SerializeField] int intstarCost = 100;
/*
    public int GetStarCost()
    {
        return intstarCost;
    }
    */
    // Method to add set amount of stars to score
    public void AddStars(int intamount)
    {
        // Finds an object with the StarDisplay script and passes through the amount
        FindObjectOfType<StarDisplay>().AddStars(intamount);
    }
    
}