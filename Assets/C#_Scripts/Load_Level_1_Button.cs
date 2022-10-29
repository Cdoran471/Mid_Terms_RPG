using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Load_Level_1_Button : MonoBehaviour
{
    public void LoadLevel(string Level_1)
    {
        SceneManager.LoadScene(Level_1);
    }
}
