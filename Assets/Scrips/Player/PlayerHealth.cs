
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float health = 100;

    public float Health
    {
        get => health;
        set => health += value;
    }

    public void TakeDamage(float value)
    {
        health -= value;
    }
}
