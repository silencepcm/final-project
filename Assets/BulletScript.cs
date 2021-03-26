using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 600f;
    public int damage = 40;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameObject play = GameObject.FindGameObjectWithTag("Player");


        SpriteRenderer sr = play.GetComponent<SpriteRenderer>();
        if (sr.flipX)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(+speed, rb.velocity.y);
        }
    }



    private void OnTriggerEnter2D(Collider2D collider)
    {

        HealthEnemy enemypatrol = collider.GetComponent<HealthEnemy>();
        if (enemypatrol != null)
        {
            enemypatrol.takeDamage(damage);
        }
        Destroy(gameObject);
    }
}
