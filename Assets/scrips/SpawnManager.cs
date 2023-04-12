using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemiesToSpawn;

    public Transform[] spawnPositions = new Transform[5];

    // Start is called before the first frame update
    public Transform [spawnPositions];


    void Start()
    {
        InvokeRepeating("SpawnEnemy" , 2f, 1.5f);
    }

    // Update is called once per frame
    void Start()
    {
        if(enemiesToSpawn ==0)
        {
            CancelInvoke();
        }
    
    }
    void Update()
    {
        //Hace un spawn de un enemigo en punto aleatorio
        //Transform selectedSpawn = spawnPositions[Random.Range(0, spawnPosition.Length)]
        
        //Instantiate (enemyPrefab, selecttedSpawn.position, selectedSpawn.rotation);

        foreach (Transform spawn in spawnPositions)
       {
        Instantiate (enemyPrefab, spawn.position, spawn.rotation);
       }    
       
       for (int i = 0, i < spawnPositions.Length, i++)
       {
        Instantiate(enemyPrefab, spawnPositions[i].position,spawnPositions[i].rotation);

       }
       int i = 0;
       while (i < spawnPositions.Length)
       {
           Instantate(enemyPrefab, spawnPositions[i].position, spawnpositions[i].rotation);
           i++;
       }

       int i = 2;
       do
       {
           Instantate(enemyPrefab, spawnPositions[i].position, spawnpositions[i].rotation);
           i++;
       } while (i < spawnPositions.Length);


      
        enemiesToSpawn--;
    }
}
