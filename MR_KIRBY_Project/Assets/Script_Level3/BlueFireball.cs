using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BlueFireball : MonoBehaviour
{
    public Vector2 startingVelocity;



    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = startingVelocity;
        Destroy(gameObject, 5);
    }


    // on collision kill the enemy
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<Enemy>();
        enemy?.Die();
        Destroy(gameObject);        // destroy the fireball after hitting the enemy

        // send a message to the score object to add score 
        GameObject.Find("Score_control ").SendMessage("AddScore");


    }
}



