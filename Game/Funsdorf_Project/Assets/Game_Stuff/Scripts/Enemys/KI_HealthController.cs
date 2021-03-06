﻿using UnityEngine;
using System.Collections;

public class KI_HealthController : MonoBehaviour
{
    public float health = 2;
    private bool dead = false;

    public void Damage(float dmg)
    {
        health -= dmg;

        if (health <= 0)
        {
            dead = true;
            Invoke(MyConst.Cooldown, 5);
        }
    }

    public void KI_Damage(float dmg)
    {
        health -= dmg;

        if (health <= 0)
        {
            dead = true;
            Invoke(MyConst.Cooldown, 5);
        }
    }
    void Cooldown()
    {
        Destroy(gameObject);
    }

    public bool Dying()
    {
        return dead;
    }
}
