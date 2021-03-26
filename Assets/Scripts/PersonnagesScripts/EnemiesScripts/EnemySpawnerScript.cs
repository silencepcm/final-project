using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    Vector2 WhereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    void Update()
    {
        if (Time.time> nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(transform.position.x-8.4f, transform.position.x+8.4f);
            WhereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, WhereToSpawn, Quaternion.identity);
        }
    }
}
