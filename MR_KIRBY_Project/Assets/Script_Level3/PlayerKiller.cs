using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKiller : MonoBehaviour
{
    private Jump jump_class_instance;       // instance of jump class to access isStart variable

    private void Awake()
    {
        jump_class_instance = GetComponent<Jump>();
    }

    // Update is called once per frame
    void Update()
    {
        // kill the player if jumped too high Or fill down
        if(transform.position.y > 5.5 || transform.position.y < -5.4 || transform.position.x < -6.7 || transform.position.x >  8.4)
        {
            SceneManager.LoadScene("_scene_4_Level3");
            Jump.isStart = false;           // when the player die and we restart the scene, set isStart to false.
        }
    }

    // kill the player if hit one of the stumps
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("_scene_4_Level3");
        Jump.isStart = false;               // when the player die and we restart the scene, set isStart to false.
    }
}
