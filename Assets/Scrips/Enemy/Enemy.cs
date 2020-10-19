using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _health = 100;
    [SerializeField] private float _startHealth = 100;
    public Image healthBar;

    public void RemoveHealth(float value)
    {
        _health -= value;
        updateHealthBar();
        if (_health <= 0)
        {
            EnemyDie();
        }
    }
    public void AddHealth(float value)
    {
        _health += value;
        updateHealthBar();
    }
    public float GetHealth()
    {
        return _health;
    }
    private void Start()
    {
        _health = _startHealth;
    }

    public void updateHealthBar()
    {
        //change enemy health bar.
        healthBar.fillAmount = _health / _startHealth;
    }

    public void EnemyDie()
    {
        //what happens when the enemy has less then 0 hp
        Destroy(this.gameObject);
    }
}
