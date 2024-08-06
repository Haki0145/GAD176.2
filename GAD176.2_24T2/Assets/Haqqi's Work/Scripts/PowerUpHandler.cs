using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpHandler : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<IPowerUp>()!= null)
        {
            collision.gameObject.GetComponent<IPowerUp>().ExecutePowerUp(gameObject);
        }
    }
}
