using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    private float MaxWidth = 2.5f,MinWidth=-2.5f;
    public GameObject EnemyPrefabDown;
    float EnemySpawnTime = 0.2f;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var SpawnPosiotion=new Vector2(Random.Range(MinWidth,MaxWidth),4.83f);
        if (timer > EnemySpawnTime)
        {
            timer = 0;
            Instantiate(EnemyPrefabDown, SpawnPosiotion, Quaternion.identity);
        }
            
        timer += Time.deltaTime;
    }
}





























 //if (Random.Range(0, 2) == 1)
 //               Instantiate(EnemyPrefabDown, spawnPointsDown[Random.Range(0, spawnPointsDown.Count)].position, Quaternion.identity);
 //           else
 //               Instantiate(EnemyPrefabRight, spawnPointsRight[Random.Range(0, spawnPointsRight.Count)].position, Quaternion.identity);


 //           if (Random.Range(0, 2) == 1)
 //               Instantiate(EnemyPrefabDown, spawnPointsDown[Random.Range(0, spawnPointsDown.Count)].position, Quaternion.identity);
 //           else
 //               Instantiate(EnemyPrefabRight, spawnPointsRight[Random.Range(0, spawnPointsRight.Count)].position, Quaternion.identity);