using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class End_Game : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        // Destroy the kirby and reload the scene 
        Destroy(collisionInfo.gameObject);
        SceneManager.LoadScene("_scene_6_level2");
    }
}
