using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBulletPls : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Destroy(gameObject);
        }
    }
}
