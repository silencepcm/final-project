using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    //Pour l'intialisation du jeu
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    //Indique à la barre de vie, combien de vie elle doit afficher
    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
