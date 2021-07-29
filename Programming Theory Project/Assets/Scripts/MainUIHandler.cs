using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{

    public void QuitGame()
    {
        //EditorApplication.ExitPlaymode();
        Application.Quit();
    }

     public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
