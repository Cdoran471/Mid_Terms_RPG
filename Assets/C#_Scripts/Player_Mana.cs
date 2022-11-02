using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player_Mana : MonoBehaviour
{
    //Mana
    public static int maxMana = 5;
    public static int currentMana;
    public string endScene;
    public ManaBar manaBar;
    void Start()
    {
        currentMana = maxMana;
        manaBar.SetMaxMana(maxMana);
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            CastSpell(1);
        }
        if (currentMana <= 0)
        {
            SceneManager.LoadScene(endScene);
        }
    }
    void CastSpell(int ManaUse)
    {
        currentMana -= ManaUse;
        manaBar.SetMana(currentMana);
    }
}
