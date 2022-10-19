using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Player has quitted!");
        Application.Quit();
        
    }
    public void StartLevel(string Main_Menu)
    {
        SceneManager.LoadScene(Main_Menu);
    }
}
