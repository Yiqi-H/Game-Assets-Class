using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;

    public int currentHealth;

    public HealthBar healthBar;

    public int maxWisdom = 100;

    public int currentWisdom;

    public WisdomBar wisdomBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        currentWisdom = maxWisdom;
        wisdomBar.SetMaxWisdom(maxWisdom);
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            TakeDamage(1);
        }
        
        else if (Input.GetMouseButtonDown(1))
        {
            TakeWisdom(1);
        }
        
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void TakeWisdom(int wisdom)
    {
        currentWisdom -= wisdom;
        wisdomBar.SetWisdom(currentWisdom);
    }
}
