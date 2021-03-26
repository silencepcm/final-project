using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSpot : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //si le joueur entre en contact avec le game object, le game object et son parent sont détruits
        if(collision.CompareTag("Player"))
        {
            Destroy(transform.parent.gameObject);
        }
    }
}