using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    public int hp = 100;

    public void takeDamage(int damage)
    {
        hp -= damage;

        if (hp <= 0)
        {

            Destroy(gameObject);
        }
    }
}
