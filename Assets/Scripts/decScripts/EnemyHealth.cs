using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 1;
    public int health;
    void Start()
    {
        health = maxHealth;
    }


    public void TakeDamage(int amount) //amount is where you pass damage through
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
} 
