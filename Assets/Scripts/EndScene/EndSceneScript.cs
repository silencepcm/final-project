using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneScript : MonoBehaviour
{
    public void exitButton()
    {
        Application.Quit();
    }
    public void restartButton()
    {
        SceneManager.LoadScene("chosePerso");
    }
    public void mainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}