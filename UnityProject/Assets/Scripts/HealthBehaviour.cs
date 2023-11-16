using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthBehaviour : MonoBehaviour
{
    private int currentHealth;
    [SerializeField]
    private int maxHealth;

    public UnityEvent OnDie;

    private void Start()
    {
        ResetHealth();
    }

    public void Heal(int quantity)
    {
        currentHealth += quantity;
    }

    public void Damage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            OnDie.Invoke();
        }
    }

    public void ResetHealth()
    {
        currentHealth = maxHealth;
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }

    public int GetMaxHealth()
    {
        return maxHealth;
    }
}
