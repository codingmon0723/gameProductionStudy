using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;

    float spawnDelay = 5f;

    void Start()
    {
        StartCoroutine("SpawnEnemy");
    }

    void Update()
    {
        
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            float x = Random.Range(-50, 50);
            float y = Random.Range(-50, 50);

            Vector3 enemyPos = transform.position + new Vector3(x, y);

            GameObject cpy_Enemy = Instantiate(enemy, enemyPos, Quaternion.identity);

            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
