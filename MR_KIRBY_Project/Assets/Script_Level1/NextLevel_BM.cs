using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel_BM : MonoBehaviour
{
   // load the second level
    public void NextLevel()
    {
        SceneManager.LoadScene("_scene_6_Level2");
    }
}
