using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour
{
    public LayerMask player;

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.left,5,player);
       if (hit==true)
        Debug.Log("watch out");
    }
}
