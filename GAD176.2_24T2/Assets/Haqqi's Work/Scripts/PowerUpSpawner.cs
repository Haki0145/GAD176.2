using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] powerUps;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] Vector2 spawnRate;
    private void Start()
    {
        StartCoroutine(SpawnPowerUps());
    }
    IEnumerator SpawnPowerUps()
    {
        while (true)
        {


        float spawnTime = Random.Range(spawnRate.x, spawnRate.y);
        yield return new WaitForSeconds(spawnTime);
        int randomePowerUp = Random.Range(0, powerUps.Length);
        int randomePosition = Random.Range(0, spawnPoints.Length);
        Instantiate(powerUps[randomePowerUp], spawnPoints[randomePosition].position , Quaternion.identity);
        }
    }
}
