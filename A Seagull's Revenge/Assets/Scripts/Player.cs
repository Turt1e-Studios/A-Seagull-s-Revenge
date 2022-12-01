using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public HealthBar healthBar;
    public GameOverScreen GameOverScreen;
    public Score scoreScript;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Q))
        {
            TakeDamage(1);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameOver();
        }
        */

    }

    public void TakeDamage(int damage)
    {
        // prevent overhealing when eating food
        if (damage > 0 || currentHealth < maxHealth)
        {
            currentHealth -= damage;
        }
        healthBar.SetHealth(currentHealth);

        if (currentHealth == 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        GameOverScreen.Setup(scoreScript.score);
        
    }
}
