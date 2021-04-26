using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : SceneLoader
{
    public float scaleOfTime = 1f;

    public GameObject mainMenu;
    
    public void OnPause()
    {
        Time.timeScale = scaleOfTime - 1;
        mainMenu.SetActive(true);
    }

    public void EndPause()
    {

        Time.timeScale = scaleOfTime;
        mainMenu.SetActive(false);
    }

    public void Index()
    {
        Time.timeScale = scaleOfTime;

        StartCoroutine(LoadScene(5, previusAnimation));
    }
}
