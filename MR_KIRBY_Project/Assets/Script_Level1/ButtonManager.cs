using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("_scene_2_Level1");
    }

    public void SetSettings()
    {
        SceneManager.LoadScene("_scene_1_Settings");
    }

    public void moveBack()
    {
        SceneManager.LoadScene("_scene_0_Start_Menu");
    }

    public void AboutPage()
    {
        SceneManager.LoadScene("_scene_7_About");
    }
}
