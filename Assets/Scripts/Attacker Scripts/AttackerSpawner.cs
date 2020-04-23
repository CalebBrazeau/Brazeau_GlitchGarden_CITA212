using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    //spawn delays for attacker spawner
    [SerializeField] float fltminSpawnDelay = 1f;
    [SerializeField] float fltmaxSpawnDelay = 5f;
    // Sets attacker for spawner to spawn
    [SerializeField] Attacker attackerPrefab;

    bool boolspawn = true;

    IEnumerator Start()
    {
        while (boolspawn)
        {
            yield return new WaitForSeconds(Random.Range(fltminSpawnDelay, fltmaxSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        // when called, spawns attacker on spawner
        Attacker newAttacker = Instantiate(attackerPrefab, transform.position, transform.rotation) as Attacker;
        // Instantiates on parent
        newAttacker.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
}