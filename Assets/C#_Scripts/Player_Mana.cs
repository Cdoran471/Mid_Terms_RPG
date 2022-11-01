using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Mana : MonoBehaviour
{
    //Mana
    public int maxMana = 5;
    public int currentMana;

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
    }
    void CastSpell(int ManaUse)
    {
        currentMana -= ManaUse;
        manaBar.SetMana(currentMana);
    }
}
