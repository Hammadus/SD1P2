using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveUpDown : MonoBehaviour
{

    [SerializeField] private float heightVariance = 1.0f;
    private Jump jump_class_instance;       // access isStart to see if the game started or not

    private void Awake()
    {
        jump_class_instance = GetComponent<Jump>();
    }

    // move the enemy up and down
    void Update()
    {
        // if the game was started
        if (Jump.isStart == true)
        {
            transform.position += Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * heightVariance;
        }
    }
}
