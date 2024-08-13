using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] int playerHealth = 3;
    public bool sheildSActivated;

    public void AddHealth(int additionalHealth)
    {
        playerHealth += additionalHealth;
    }

    public void RecieveDmg(int dmg)
    {
        if (sheildSActivated == false)
        {
            playerHealth -= dmg;
        }
        
    }
}
