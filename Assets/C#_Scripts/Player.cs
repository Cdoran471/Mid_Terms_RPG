using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
        //Health
    public static int maxHealth = 3;
    static int currentHealth = 5;

    public HealthBar healthBar;

    public string endScene;
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
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(endScene);
        }
    }
    void TakeDamage(int damage)
   {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        
    }
}
