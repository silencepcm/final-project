using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void exitButton()
    {
        Application.Quit();
    }
    public void startButton()
    {
        SceneManager.LoadScene("LD_Level");
    }
}
