using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpEMP : MonoBehaviour, IPowerUp
{
    [SerializeField] EnemyTestMove[] enemyMovemment;
    [SerializeField] float timeDuration = 5;

    public void ExecutePowerUp(GameObject player)
    {
        if (enemyMovemment.Length>0)
        {
            for (int i = 0; i < enemyMovemment.Length; i++)
            {
                enemyMovemment[i].DisableMovement(timeDuration);
            }
            Destroy(gameObject);
        }
    }

    void DisableEnemyMovement()
    {
        enemyMovemment = FindObjectsOfType<EnemyTestMove>();
    }

    void Update()
    {
        DisableEnemyMovement();
    }


}
