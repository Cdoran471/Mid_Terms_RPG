using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
        //Health
    public int maxHealth = 3;
    public int currentHealth;
        //Mana

    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);


    }

    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
    }
    void TakeDamage(int damage)
   {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    
}
