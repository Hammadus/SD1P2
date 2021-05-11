using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevelButton : MonoBehaviour
{
    public void NextLevel()
    {
        //next level 
        SceneManager.LoadScene("_scene_4_level3");
    }
}
