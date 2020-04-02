using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] GameObject Projectile;
    [SerializeField] GameObject TheStrap;

    public void Fire()
    {
        Instantiate(Projectile, TheStrap.transform.position, transform.rotation);
    }

}
