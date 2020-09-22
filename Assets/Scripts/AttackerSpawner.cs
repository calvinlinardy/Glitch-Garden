using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] Attacker attackerPrefab = null;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;


    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Attacker newAttacker = Instantiate
            (attackerPrefab, transform.position, transform.rotation) 
            as Attacker;
        // instantiate as chile
        newAttacker.transform.parent = transform;
    }

    void Update()
    {
        
    }
}
