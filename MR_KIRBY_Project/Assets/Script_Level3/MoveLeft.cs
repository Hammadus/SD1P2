using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float leftSpeed = 1.0f;
    private Enemy enemy;
    private Jump jump_class_instance;       // instance of jump class to access isStart variable

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
        jump_class_instance = GetComponent<Jump>();
    }

    // Update is called once per frame
    void Update()
    {
        // if the game was started
        if (Jump.isStart == true)
        {
            // make the object move to the left
            transform.Translate(Vector3.left * Time.deltaTime * leftSpeed, Space.World);

            // if it reach the end of the screen, re-position it back to the right
            if (transform.position.x < -10)
            {
                transform.position += Vector3.right * 20;
                ShowRandomSprite();
                enemy?.Respawn();
            }
        }
    }


    // to spawn a random sprite from all the sprites that we have
    private void ShowRandomSprite()
    {
        int childCount = transform.childCount;
        int index = UnityEngine.Random.Range(0, childCount-1);

        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.gameObject.SetActive(index == i);
        }
    }

    // spawn a random sprite at the beginning
    private void OnEnable()
    {
        // if the game was started
//        if (Jump.isStart == true)
//       {
            ShowRandomSprite();
//        }
    }
}
