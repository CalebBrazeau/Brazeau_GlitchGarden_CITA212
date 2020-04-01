using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject Defender;
    private void OnMouseDown()
    {
        SpawnDefender();
    }
    private void SpawnDefender()
    {
        GameObject newDefender = Instantiate(Defender, transform.position, Quaternion.identity);
    }
}
