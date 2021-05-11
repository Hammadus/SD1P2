using UnityEngine;
using System.Collections;
using TMPro;


public class BallMove : MonoBehaviour
{
    // Movement Speed
    private float speed = 110.0f;
    public TextMeshProUGUI presstostart;


    void Start()
    {
        //speed 
        GetComponent<Rigidbody2D>().velocity = Vector2.up * 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
            presstostart.enabled = false;
            presstostart.gameObject.SetActive(false);
        }
    }

    float disperse(Vector2 ballPos, Vector2 racketPos,float racketWidth)
    {
        // ascii art:
        //
        // 1  -0.5  0  0.5   1  <- x value
        // ===================  <- racket
        //
        return (ballPos.x - racketPos.x) / racketWidth;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // Hits the racker 
        if (col.gameObject.name == "racket")
        {
            // disperse factor 
            float x = disperse(transform.position, col.transform.position,col.collider.bounds.size.x);

            // Calculate direction and set length 
            Vector2 dir = new Vector2(x, 1).normalized;

            // Set Velocity 
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }


}