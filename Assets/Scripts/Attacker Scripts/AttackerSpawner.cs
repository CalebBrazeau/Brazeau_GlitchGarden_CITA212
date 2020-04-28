
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    //spawn delays for attacker spawner
    [SerializeField] float fltminSpawnDelay = 1f;
    [SerializeField] float fltmaxSpawnDelay = 5f;
    // Sets attacker for spawner to spawn
    [SerializeField] Attacker[] attackerPrefabArray;

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
        // sets range for attacker prefab array
        var attackerIndex = Random.Range(0, attackerPrefabArray.Length);
        // tells "Spawn" method what attacker pref
        Spawn(attackerPrefabArray[attackerIndex]);
    }

    private void Spawn(Attacker myAttacker)
    {
        // when called, spawns attacker on spawner
        Attacker newAttacker = Instantiate(myAttacker, transform.position, transform.rotation) as Attacker;
        // Instantiates on parent
        newAttacker.transform.parent = transform;
    }
}
