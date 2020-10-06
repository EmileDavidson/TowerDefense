
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float health = 100;
    public void RemoveHealth(float amount)
    {
        this.health -= amount;
    }
    
    public void AddHealth(float amount)
    {
        this.health += amount;
    }
    
    public float GetHealth()
    {
        return this.health;
    }
}
