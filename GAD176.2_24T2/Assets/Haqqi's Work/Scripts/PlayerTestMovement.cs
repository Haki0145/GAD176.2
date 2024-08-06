using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the player
    private Rigidbody2D rb; // Reference to the Rigidbody2D component
    private Vector2 movement; // Variable to store the movement input
    private float initSpeed ;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component attached to the player
        initSpeed = moveSpeed;
    }

    void Update()
    {
        // Get the horizontal and vertical input (WASD or arrow keys)
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Store the movement input in the movement variable
        movement = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        // Move the player using the Rigidbody2D component
        rb.velocity = movement * moveSpeed;
    }
    public IEnumerator BoostSpeed(float speedBoost, float duration) 
    {
        moveSpeed += speedBoost;
        yield return new WaitForSeconds(duration);
        moveSpeed = initSpeed;
    }
}
