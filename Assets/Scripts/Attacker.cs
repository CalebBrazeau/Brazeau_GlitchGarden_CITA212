using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)]
    [SerializeField] float walkSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * walkSpeed *Time.deltaTime);
    }
}
