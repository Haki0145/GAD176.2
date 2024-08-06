using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpHealth : MonoBehaviour, IPowerUp
{
    [SerializeField] int additionalHealth = 3;
    public void ExecutePowerUp(GameObject player)
    {
        player.GetComponent<PlayerStatus>().AddHealth(additionalHealth);
        Destroy(gameObject);
    }
}
