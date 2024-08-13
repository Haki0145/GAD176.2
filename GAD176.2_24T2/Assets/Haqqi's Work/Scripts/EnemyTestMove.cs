using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTestMove : MonoBehaviour
{
    Transform playerPosition;
    [SerializeField] float enemySpeed = 5;
    bool movementDisable;

    private void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        MoveToPlayer();
    }

    void MoveToPlayer()
    {
        if ( movementDisable == false)
        {
            transform.position = Vector3.MoveTowards(transform.position,playerPosition.position,enemySpeed * Time.deltaTime);
        }
    }

    public void DisableMovement(float durration)
    {
        movementDisable = true;
        Debug.Log(movementDisable);
        StartCoroutine(DisableMovementTime(durration));
    }

    IEnumerator DisableMovementTime(float durration)
    {
        yield return new WaitForSeconds(durration);
        movementDisable = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerStatus>().RecieveDmg(1);
        }
    }
}
