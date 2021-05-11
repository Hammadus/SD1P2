using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusController : MonoBehaviour
{
    public Text msg;
    private Controller Controller_class_Instance;          // create instance of the class Controller to access IsWin variable.
    private bool win = false;
    public GameObject NextLevel_Button;        // to activate the next level button


    void Start()
    {
        NextLevel_Button = GameObject.FindWithTag("NextLevel_Button");
    }

    void Update()
    {
        Controller_class_Instance = GetComponent<Controller>();

        win = Controller.isWin;


        if (win == true)
        {
            msg.text = "CONGRATULATION LEVEL 1 COMPLETED";
            NextLevel_Button.SetActive(true);       // activate the next level button
        }
        else
        {
            msg.text = "SORRY YOU LOSE!";
            NextLevel_Button.SetActive(false);      // deactivate the next level button
        }
    }



}
