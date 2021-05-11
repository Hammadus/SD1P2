using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{

    private Rigidbody2D rb;
    private float moveInput;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jumpForce = 10f;
    public static bool isStart = false;           // to start the game
    public Text startText;
    public Text instructionsText;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        // to make the player not to fall at the beginning of the game 
        rb.gravityScale = 0;
        rb.velocity = Vector3.zero;
    }

    // make our player jump
    void Update()
    {
        // check if the player hit space to start the game
        if (Input.GetKeyDown(KeyCode.Space) && isStart == false)
        {
            isStart = true;
            startText.gameObject.SetActive(false);
            instructionsText.gameObject.SetActive(false);
            rb.gravityScale = 1.0f;  // set the gravity scale back when the game start
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



            if (Input.GetKeyDown(KeyCode.Space))
            {
                JumpUp();
            }
        }
    }


    // to make the Player Jump
    private void JumpUp()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }


    // make the player move left/right
    private void FixedUpdate()
    {
        // if the game was started
        if (isStart == true)
        {
            // make the player move left/right.
            moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        }
    }

}
