using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    public void OnTriggerEnter2D()
    {
        // finds livesdisplay component and accesses TakeLife method
        FindObjectOfType<LivesDisplay>().TakeLife();
    }
}
