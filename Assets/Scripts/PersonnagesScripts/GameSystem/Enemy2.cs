using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2
{
    public int hp { get; set; }
    public int damage { get; set; }
    public int damageShoot { get; set; }
    public int speed { get; set; }
    public Enemy2()
    {
        hp = 90;
        damage = 15;
        damageShoot = 15;
        speed = 7;
    }
}

