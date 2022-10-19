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
    public void LoadLevel(string Main_Scene)
    {
        SceneManager.LoadScene(Main_Scene);
    }
}
