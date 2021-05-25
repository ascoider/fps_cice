using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTestSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] enemyPrefab;
    [SerializeField] float enemySpawnDelay = 5f;
    int enemyChance, enemyCounter;
    //bool canSpawn, isSpawning;
    

    void Start()
    {
        //canSpawn = true;
        enemyChance = 1;
        InvokeRepeating("EnemySpawn", 3f, enemySpawnDelay);
    }

    
    void Update()
    {
        /*if (Input.GetKeyDown("y"))
        {
            if (!isSpawning)
            {
                isSpawning = true;
                InvokeRepeating("EnemySpawn", 0, enemySpawnDelay);
                //canSpawn = false;
            }
            else
            {
                CancelInvoke("EnemySpawn");
                isSpawning = false;
            }
        }*/
    }

    void EnemySpawn()
    {
        //if (isSpawning)
        //{
            if (enemyChance % 5 == 0)
                Instantiate(enemyPrefab[1], transform.position, Quaternion.Euler(transform.rotation.x, Random.Range(0, 360), transform.rotation.z));
            else
                Instantiate(enemyPrefab[0], transform.position, Quaternion.Euler(transform.rotation.x, Random.Range(0, 360), transform.rotation.z));

            enemyChance++;
        //}
    }
}
