using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] GameObject Projectile;
    [SerializeField] GameObject TheStrap;
    AttackerSpawner myLaneSpawner;

    void Start()
    {
        SetLaneSpawner();
    }

    void Update()
    {
        if (IsAttackerInLane())
        {
            //Debug.Log("Shoot Pew Pew");
        }
        else
        {
            //Debug.Log("Wait");
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in spawners)
        {
            bool IsCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);

            if (IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void Fire()
    {
        Instantiate(Projectile, TheStrap.transform.position, transform.rotation);
    }

}
