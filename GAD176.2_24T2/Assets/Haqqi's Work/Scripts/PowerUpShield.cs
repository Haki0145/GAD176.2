using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpShield : MonoBehaviour, IPowerUp
{
    public GameObject shieldPrefab; // The shield prefab to be activated
    [SerializeField] float shieldDuration = 5f; // Duration of the shield

    public void ExecutePowerUp(GameObject player)
    {
        // Check if the player already has a shield
        if (player.transform.Find(shieldPrefab.name) == null)
        {
            // Activate the shield
            GameObject shieldInstance = Instantiate(shieldPrefab, player.transform);
            shieldInstance.name = shieldPrefab.name; // Set the name to avoid duplicates

            // Position the shield at the player's position
            shieldInstance.transform.localPosition = Vector3.zero;
            player.GetComponent<PlayerStatus>().sheildSActivated = true;
            // Start the coroutine to deactivate the shield after the duration
            player.GetComponent<MonoBehaviour>().StartCoroutine(DeactivateShieldAfterTime(shieldInstance, shieldDuration, player));
        }

        // Optionally destroy the power-up object after it's used
        Destroy(gameObject);
    }

    private IEnumerator DeactivateShieldAfterTime(GameObject shield, float duration, GameObject player)
    {
        yield return new WaitForSeconds(duration);
        player.GetComponent<PlayerStatus>().sheildSActivated = false;
        Destroy(shield); // Destroy the shield after the duration
    }
}
