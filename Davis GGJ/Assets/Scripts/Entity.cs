using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Entity : MonoBehaviour
{
    public UnityEvent<float> DamagedEvent;
    public UnityEvent KilledEvent;

    public int MaxHealth;
    protected int health;

    protected void Awake()
    {
        health = MaxHealth;
    }

    public void TakeDamage(int val)
    {
        health -= val;
        if (health < 0)
        {
            health = 0;
            OnDeath();
            KilledEvent.Invoke();
        }
        DamagedEvent.Invoke((float)health/MaxHealth);
    }

    protected abstract void OnDeath();
}
