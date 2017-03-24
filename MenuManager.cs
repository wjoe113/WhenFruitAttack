/* ---------------------------------------------------
 * When Fruit Attack - By Angelica Garcia and Joe Wileman
 * CAP6121 Spring 2017 Homework 2
 * -------------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public void startLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
