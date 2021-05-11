using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killer : MonoBehaviour
{
    public float speed = 15.0f;
    private Rigidbody2D rb;


    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(1, speed), Random.Range(1, speed));
    }


    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.tag == "border")
        {
            Destroy(gameObject);
        }
        else if (co.name == "kirby_ball")
        {
            Destroy(co.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene("_scene_6_level2");
        }
    }
}
