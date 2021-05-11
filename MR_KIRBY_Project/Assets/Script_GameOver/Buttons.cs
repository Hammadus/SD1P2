using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // to start a new game 
    public void NewGame()
    {
        SceneManager.LoadScene("_scene_0_Start_Menu");
    }

    // to quit the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
