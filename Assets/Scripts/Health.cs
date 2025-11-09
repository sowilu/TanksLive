using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public Transform healthBar;
    public int maxHealth;
    
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void Damage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            print("TODO: die");
        }
        
        healthBar.localScale = new Vector3(
            (float)currentHealth / maxHealth, 
            healthBar.localScale.y, 
            healthBar.localScale.z);
    }
    
}
