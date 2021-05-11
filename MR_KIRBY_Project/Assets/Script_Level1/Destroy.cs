using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{

    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPrefab;
//    public GameObject myPlat;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if a platform went down and hit the destroyer
        if (collision.gameObject.name.StartsWith("Platform"))
        {
            if(Random.Range(1, 7) == 1)     // small chance to spawn a spring
            {
                // we'll destroy the platform and we'll instantiate a spring instead of it
                Destroy(collision.gameObject);
                Instantiate(springPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)) ), Quaternion.identity);
            }else{
                // we'll relocate the platform to the top of the game
                collision.gameObject.transform.position = new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)));
            }
        }else if (collision.gameObject.name.StartsWith("Spring"))    // if a spring went down and hit the destroyer
        {
            if (Random.Range(1, 7) == 1)    // small chance to spawn a nother spring
            {
                // just relocate the spring 
                collision.gameObject.transform.position = new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)));
            }
            else
            {
                // destroy the spring and instead we'll spwan a platform in its place
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f))), Quaternion.identity);
            }
        }
    }
}
