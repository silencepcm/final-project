using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1
{
    public int hp { get; set; }
    public int damage { get; set; }
    public int damageShoot { get; set; }
    public int speed { get; set; }
    public Enemy1()
    {
        hp = 80;
        damage = 10;
        damageShoot = 20;
        speed = 7;
    }
}