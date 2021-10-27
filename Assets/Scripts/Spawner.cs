using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _enemyPreFab = null;
    private GameObject enemyPreFab { get { return _enemyPreFab; } }

    public float _spawnDelay = 0.05f;
    private float spawnDelay { get { return _spawnDelay; } }

    void Start()
    {
        InvokeRepeating("Spawn", 0, spawnDelay);
    }

    private void Spawn()
    {
        Vector3 spawnPosition = transform.position;
        spawnPosition.z += Random.Range(-3.0f, 3.0f);
        Instantiate(enemyPreFab, spawnPosition, transform.rotation);
    }    
}
