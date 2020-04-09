using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // amount of health the attacker has
    [SerializeField] float flthealth = 100f;
    // Amount of time before attacker is destroyed
    [SerializeField] int intTimeToWait = 4;
    // Sets Animator to myAnimator
    Animator myAnimator;


    void Start()
    {
        // Gets gameobjects Animator
        myAnimator = GetComponent<Animator>();
    }
    public void DamageMeOwO(float damage)
    {
        // subtracts the amount of health defined by the float at start of script
        flthealth -= damage;
        // if the health is below zero attacker is destroyed
        if (flthealth <= 0)
        {
            // Disables attacker collider so projectiles can pass through it
            GetComponent<BoxCollider2D>().enabled = false;
            // Sets attacker animation to dying animation
            myAnimator.SetBool("Dying", true);
            // Starts timer so death animation can run completely
            StartCoroutine(WaitForAttackerDeath());
        }
    }

    IEnumerator WaitForAttackerDeath()
    {
        // Waits for time set at start of script
        yield return new WaitForSeconds(intTimeToWait);
        // if the if statement is true this destroys the game object
        Destroy(gameObject);
    }
}
