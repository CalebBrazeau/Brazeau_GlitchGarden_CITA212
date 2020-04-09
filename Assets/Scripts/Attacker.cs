using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)]
    // Speed variable for attacker
    float fltcurrentSpeed = 1f;
    // finds the sprite renderer of the object
    private SpriteRenderer mySpriteRenderer;
    // Sets value for attacker health
    [SerializeField] float fltmyHealth = 10f;

    // Start is called before the first frame update
    void Start()
    {
        // Gets sprite renderer component from object script is attached to
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        // Flips sprite dirrection because the sprite I have is reversed
        mySpriteRenderer.flipX = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Sets attacker speed
        transform.Translate(Vector2.left * fltcurrentSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        fltcurrentSpeed = speed;

    }
}
