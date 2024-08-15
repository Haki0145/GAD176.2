using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace astroids
{
    public class FasterAstroid : Astroids
    {
        // Update is called once per frame
        void Update()
        {
            RockGo();
        }
        protected override void RockGo()
        {
            RockTimer -= Time.deltaTime; //timer for bullets
            Rockspeed = Random.Range(1300, 1900);
            if (RockTimer > 0)
                return;
            RockTimer = Random.Range(5, 10);
            GameObject RockObject = Instantiate(Rock, spawnpoint.transform.position, spawnpoint.transform.rotation) as GameObject;// spawn astroid to send at the player 
            Rigidbody2D RockRig = RockObject.GetComponent<Rigidbody2D>();
            RockRig.AddForce((Vector3.left) * Rockspeed);
            Destroy(RockObject, 2f);// destroy the astroid after 2 seconds
            Debug.Log("zoom");
        }
    }
}
