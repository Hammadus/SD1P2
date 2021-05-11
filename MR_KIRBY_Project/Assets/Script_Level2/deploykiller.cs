using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class deploykiller : MonoBehaviour
{
    public GameObject killerPrefab;
    private float respawnTime = 12.0f;
    public TextMeshProUGUI number;

    // Use this for initialization
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("killerWave");
        }

        int scoreValue;
        int.TryParse(number.text, out scoreValue);

        if (scoreValue >= 8)
        {
            StopCoroutine("killerWave");
        }
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(killerPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-86,86), 105);
    }

    IEnumerator killerWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
