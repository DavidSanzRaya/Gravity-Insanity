using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void DelayedLoadMenu(float delay)
    {
        Invoke("LoadMenu", delay);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
