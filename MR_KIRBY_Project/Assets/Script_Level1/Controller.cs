using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Controller : MonoBehaviour
{

    private Rigidbody2D rb;
    private float moveInput;
    private float speed = 10f;
    public Text scoreText;
    private float topScore = 0.0f;
    private bool isStart = false;
    public Text startText;
    public static bool isWin = false;
    public Text instructionsText;
    public float winningScore; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // to make the player not to fall at the beginning of the game 
        rb.gravityScale = 0;
        rb.velocity = Vector3.zero;
    }

    void Update()
    {
        // check if the player hit space to start the game
        if(Input.GetKeyDown(KeyCode.Space) && isStart == false)
        {
            isStart = true;
            startText.gameObject.SetActive(false);
            instructionsText.gameObject.SetActive(false);
            rb.gravityScale = 5.0f;  // set the gravity scale back when the game start
        }

        // is the game started 
        if (isStart == true)
        {

            // change our player sprit to face left or right
            if (moveInput < 0)
            {
                this.GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().flipX = false;
            }

            // if we are higher than our current score, then we need to update it to to the current y position.
            if (rb.velocity.y > 0 && transform.position.y > topScore)
            {
                topScore = transform.position.y;   // now top score is our new score
            }
            // update the score text
            scoreText.text = "Score: " + Mathf.Round(topScore).ToString();

            // if the player's score is more than 100, he won, go to the game over scene
            if(topScore > winningScore)
            {
                isWin = true;
                SceneManager.LoadScene("_scene_ToNextLevel");
            }

            // if the player fall  down. he lose and go to game over scene
            if(rb.velocity.y < -50)
            {
                isWin = false;
                SceneManager.LoadScene("_scene_ToNextLevel");
            }

        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // if the game was started
        if (isStart == true)
        {
            moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        }
    }
}
