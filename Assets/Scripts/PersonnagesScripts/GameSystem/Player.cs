using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player
{
    public int hp { get; set; }
    public int damage { get; set; }
    public int damageShoot { get; set; }

    public int speed { get; set; }
// constructeur
public Player()
    {
        hp = 100;
        damage = 30;
        damageShoot = 40;
        speed = 10;
    }

}

