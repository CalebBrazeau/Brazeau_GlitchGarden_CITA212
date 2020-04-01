using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] int WaitBeforeDestroy = 2;

    Animator myAnimator;
    CapsuleCollider2D myBodyCollider;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
        myBodyCollider = GetComponent<CapsuleCollider2D>();
    }

    public void DamageMeOwO(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            StartCoroutine(WaitForDeath());
            myAnimator.SetBool("Dying", true);
            myBodyCollider.enabled = !myBodyCollider.enabled;
        }
    }

    IEnumerator WaitForDeath()
    {
        yield return new WaitForSecondsRealtime(WaitBeforeDestroy);
        Destroy(gameObject);
    }
}
