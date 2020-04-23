using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)]
    // Speed variable for attacker
    float fltcurrentSpeed = 1f;
    // finds the sprite renderer of the object
    private SpriteRenderer mySpriteRenderer;
    // Current target
    GameObject currentTarget;

    // Start is called before the first frame update
    void Start()
    {
        // Gets sprite renderer component from object script is attached to
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        // Flips sprite dirrection because the sprite I have is reversed
        //mySpriteRenderer.flipX = true;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAnimationState();
        // Sets attacker speed
        transform.Translate(Vector2.left * fltcurrentSpeed * Time.deltaTime);
    }

    private void UpdateAnimationState()
    {
        // if there isnt a current target
        if (!currentTarget)
        {
            // sets attacking animation condition to false
            GetComponent<Animator>().SetBool("Attacking", false);
        }
    }


    public void SetMovementSpeed(float speed)
    {
        fltcurrentSpeed = speed;
    }



    public void Attack(GameObject target)
    {
        //Gets animator component
        GetComponent<Animator>().SetBool("Attacking", true);
        // sets current target to target
        currentTarget = target;
    }

    public void StrikeCurrentTarget(float damage)
    {
        // if there is no current target
        if (!currentTarget)
        {
            // returns
            return;
        }
        // Sets a handle to the health script
        Health health = currentTarget.GetComponent<Health>();
        // if the object has a health script
        if (health)
        {
            // passes the amount of damage to DealDamage
            health.DamageMeOwO(damage);
        }
    }
}
