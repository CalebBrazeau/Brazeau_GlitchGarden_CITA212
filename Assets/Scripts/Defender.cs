using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    // Sets gameobject for projectile and gun
    [SerializeField] GameObject Projectile;
    [SerializeField] GameObject TheStrap;

    public void Fire()
    {
        // Clones projectile to make extra bullets
        Instantiate(Projectile, TheStrap.transform.position, transform.rotation);
    }


}
