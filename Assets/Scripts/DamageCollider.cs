using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        // decrease our lives because an attacker has hit
        // our DamageCollider
        FindObjectOfType<LivesDisplay>().TakeLife();

        // Destroys enemies that hit damage collider
        Destory(otherCollider.gameObject);
    }

} // class DamageCollider
