using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] int playerHealth = 3;

    public void AddHealth(int additionalHealth)
    {
        playerHealth += additionalHealth;
    }
}
