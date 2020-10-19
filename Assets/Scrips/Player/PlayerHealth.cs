using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _health = 100;
    [SerializeField] private float _startHealth = 100;
    public Image healthBar;

    public float Health {
        get => _health;
        set
        {
            _health += value; 
            updateUI();
        }
    }
    public void TakeDamage(float value)
    {
        _health -= value;
        updateUI();
    }

    public void updateUI()
    {
        healthBar.fillAmount = _health / _startHealth;
    }
}
