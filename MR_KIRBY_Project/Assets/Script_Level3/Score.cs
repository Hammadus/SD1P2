using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Score : MonoBehaviour
{

    private float currentScore = 0f;
    public float winScore;
    public Text scoreText;
    private Jump jump_class_instance;       // instance of jump class to access isStart variable


    private void Awake()
    {
        jump_class_instance = GetComponent<Jump>();
    }


    // add score each time the blue fireball hit a dragon
    void AddScore()
    {
        currentScore += 1;
    }

    private void Update()
    {
        scoreText.text = "Score: " + Mathf.Round(currentScore).ToString();

        if ( currentScore == winScore)
        {
            SceneManager.LoadScene("_scene_5_GameOver");
            Jump.isStart = false;           // when the player die and we restart the scene, set isStart to false.
        }
    }
}
