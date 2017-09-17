using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Text menu;
    void Start()
    {
        menu.text = "Press 1 to play the rolling game. Press 2 to play my game.";
        if (Input.GetKey("1"))
        {
            SceneManager.LoadScene(1);
        }
        else if (Input.GetKey("2"))
           {
            SceneManager.LoadScene(2);
            }

    }
}
