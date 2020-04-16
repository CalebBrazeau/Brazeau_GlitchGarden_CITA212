using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    // Sets gameobject for projectile and gun
    [SerializeField] GameObject Projectile;
    [SerializeField] GameObject TheStrap;
    AttackerSpawner myLaneSpawner;
    //Animator myAnimator;

    void Start()
    {
        //myAnimator = GetComponent<Animator>();

        SetLaneSpawner();

    }
    void Update()
    {
        // IF there is an attacker in lane
        if(IsAttackerInLane())
        {
            print("Shoot Pew Pew");

        }
        // If there isnt an attacker in lane
        else
        {
            print("Just Chill Dude");

        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        // for each attacker in spawner
        foreach(AttackerSpawner spawner in spawners)
        {
            // if the spawner position and the defender postition = 0ish 
            bool boolIsCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            // if the bool is true
            if (boolIsCloseEnough)
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
        // Clones projectile to make extra bullets
        Instantiate(Projectile, TheStrap.transform.position, transform.rotation);
    }


}
