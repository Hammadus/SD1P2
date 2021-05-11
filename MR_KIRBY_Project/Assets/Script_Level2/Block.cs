using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Block : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "kirby_ball") {
            // Destroy the whole Block
            GameObject.Find("Number").SendMessage("AddScore");
            Destroy(gameObject);
        }
    }

}
