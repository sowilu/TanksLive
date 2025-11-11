using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

            var player = GetComponent<Player>();
            if (player.isPlayer1)
            {
                //Score.instance.SetScore(0, 1);
                Score.instance.SetScore(p2:1);
            }
            else
            {
                Score.instance.SetScore(p1:1);
            }
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        healthBar.localScale = new Vector3(
            (float)currentHealth / maxHealth, 
            healthBar.localScale.y, 
            healthBar.localScale.z);
    }
    
}
