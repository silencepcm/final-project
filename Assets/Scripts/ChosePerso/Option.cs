using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.Animations;

public class Option : MonoBehaviour
{
    public Animator animtemp;
    public Sprite srtemp;
    private void Start()
    {
        srtemp = GetComponent<Sprite>();
        animtemp = GetComponent<Animator>();
    }
    public void choseButton()
    {
        SceneManager.LoadScene("LD_Level");
    }
}
