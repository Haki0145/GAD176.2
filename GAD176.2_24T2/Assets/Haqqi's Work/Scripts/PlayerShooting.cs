using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Reference to the bullet prefab
    public Transform bulletSpawn; // The spawn point of the bullet
    public float bulletSpeed = 10f; // Speed of the bullet
    bool up, Down, Left, Right;
    string bulletDirection;
    Vector3 direction;

    void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

        BulletDirection();
    }

    void Shoot()
    {
        // Create a bullet instance at the bulletSpawn position and rotation
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        // Get the Rigidbody2D component of the bullet and add force to it
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = direction * bulletSpeed;
    }

    void BulletDirection()
    {
        if (Input.anyKeyDown)
        {
            switch (Input.inputString)
            {
                case "w":
                    direction = Vector3.up;
                    break;
                case "s":
                    direction = Vector3.down;
                    break;
                case "d":
                    direction = Vector3.right;
                    break;
                case "a":
                    direction = Vector3.left;
                    break;
            }
            
        }

    }
}
