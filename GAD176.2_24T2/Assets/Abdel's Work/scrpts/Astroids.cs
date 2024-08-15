using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace astroids
{
    public class Astroids : MonoBehaviour
    {
        public Movment Move;
        public GameObject Rock;
        [SerializeField] protected float RockTimer;
        public float Rockspeed;
        public Transform spawnpoint;
        public Transform player;

        // Start is called before the first frame update
        void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        // Update is called once per frame
        void Update()
        {
            RockGo();
        }
        protected virtual void RockGo()
        {
            RockTimer -= Time.deltaTime; //timer for bullets
            //Rockspeed = 1000;
            //Move.speed = Rockspeed;
            if (RockTimer > 0)
                return;
            RockTimer = Random.Range(5, 10);
            GameObject RockObject = Instantiate(Rock, spawnpoint.transform.position, spawnpoint.transform.rotation) as GameObject;// spawn astroid to send at the player 
            Rigidbody2D RockRig = RockObject.GetComponent<Rigidbody2D>();
            RockRig.AddForce((Vector3.left) * Move.speed);
            Destroy(RockObject, 2f);// destroy the astroid after 2 seconds
            Debug.Log("wee");
        }
    }
}

