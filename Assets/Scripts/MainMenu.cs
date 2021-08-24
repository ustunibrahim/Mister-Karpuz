using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("FirstScene");
    }
    public void QuitGame()
    {
        
        Application.Quit();
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void aboutthegame()
    {
        SceneManager.LoadScene("aboutthegame");
    }
}
