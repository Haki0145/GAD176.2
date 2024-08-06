using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpeed : MonoBehaviour, IPowerUp
{
    [SerializeField] float additionalSpeed = 5;
    [SerializeField] float speedDuration = 5;

    public void ExecutePowerUp(GameObject player)
    {
        PlayerTestMovement playerTestMovement = player.GetComponent<PlayerTestMovement>();
        StartCoroutine(playerTestMovement.BoostSpeed(additionalSpeed, speedDuration));
    }
}
