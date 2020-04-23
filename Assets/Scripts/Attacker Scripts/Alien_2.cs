using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien_2 : MonoBehaviour
{
    //when the object enters the collider of something else
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        // gameobject of whaterver the objetc bumped into
        GameObject otherObject = otherCollider.gameObject;

        if (otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject);
        }
    }
}
