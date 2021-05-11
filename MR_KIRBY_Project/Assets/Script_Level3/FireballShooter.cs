using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballShooter : MonoBehaviour
{
    public GameObject FireballPrefab;

    // Instantiate fireball when we jump
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var projectile = GameObject.Instantiate(FireballPrefab, transform.position, FireballPrefab.transform.rotation);
        }
    }
}
