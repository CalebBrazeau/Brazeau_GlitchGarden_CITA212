using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // amount of health the attacker has
    [SerializeField] float flthealth = 100f;

    public void DamageMeOwO(float damage)
    {
        // subtracts the amount of health defined by the float at start of script
        flthealth -= damage;
        // if the health is below zero attacker is destroyed
        if (flthealth <= 0)
        {
            // if the if statement is true this destroys the game object
            Destroy(gameObject);
        }
    }
}
