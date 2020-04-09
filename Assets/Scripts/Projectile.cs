using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Sets the speed and damage of the projectile
    [SerializeField] float fltspeed = 1f;
    [SerializeField] float fltdamage = 20f;

    void Update()
    {
        // Sets direction and speed of projectile
        transform.Translate(Vector2.right * fltspeed * Time.deltaTime);
    }

    // when it enters another collider it triggers the event
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        // Gets health component of collidee
        var health = otherCollider.GetComponent<Health>();
        // Gets attacker collider
        var attacker = otherCollider.GetComponent<Attacker>();
        // When colliding with something it checks if it has both attacker and health component
        if (attacker && health)
        {
            // Damages object hit by variable defined at start of script
            health.DamageMeOwO(fltdamage);
            //Destroys projectile so it doesnt pass through and damage multiple attackers
            Destroy(gameObject);
        }
    }
}
