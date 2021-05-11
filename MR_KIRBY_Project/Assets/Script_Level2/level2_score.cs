using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class level2_score : MonoBehaviour
{
    //score 
    public int score = 0;
    public int winningScore = 8;

    //once you win buttons / text 
    public TextMeshProUGUI number;
    public TextMeshProUGUI youwon;
    public Button next;


    void AddScore()
    {
        score = score + 1;
    }

    private void Start()
    {
        number = GetComponent<TextMeshProUGUI>();
        number.text = "0";
    }

    void FixedUpdate()
    {
        number = GetComponent<TextMeshProUGUI>();
        number.text = score.ToString();

        if (score >= winningScore) {
            youwon.enabled = true;
            youwon.gameObject.SetActive(true);
            next.enabled = true;
            next.gameObject.SetActive(true);

            GameObject[] player = GameObject.FindGameObjectsWithTag("kirby");
            foreach (GameObject k in player)
            {
                GameObject.Destroy(k);
            }

            GameObject[] enemy = GameObject.FindGameObjectsWithTag("Respawn");
            foreach (GameObject k in enemy)
            {
                GameObject.Destroy(k);
            }



        }

    }

}
