using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    Transform enemypos;
    Rigidbody2D rb2d;
    GameObject enemy;
    SpriteRenderer sr;
    public Animator animator;
    public GameObject thePrefab;
    float nextAttack = 0.0f;
    public float attackRate = 2f;
    PlayerAttack scriptAtt;


    void Start()
    {
        if(enemy == null)
             enemy = GameObject.FindGameObjectWithTag("Player");
        enemypos = enemy.GetComponent<Transform>();
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        scriptAtt = GetComponent<PlayerAttack>();
    }

    void Update()
    {
        if (transform.position.x > enemypos.position.x) {
            rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
            sr.flipX = true;
        }
        if (transform.position.x < enemypos.position.x)
        {
            rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
            sr.flipX = false;
        }
        if (Time.time > nextAttack)
        {
            nextAttack = Time.time + attackRate;
            randomAttack();
        }
    }


    public void randomAttack()
    {
        bool a = (Random.value > 0.5f);
        if (a)
        {
            shoot();
        } 
        else
        {
            attackSup();
        }

    }

    public void shoot()
    {
        var pos = transform.position;
        pos.x += 10f;
        var instance = Instantiate(thePrefab, pos, transform.rotation);
    }

    public void attackSup()
    {
        animator.SetBool("attack", true);
        scriptAtt.attack();
    }
    public void stopAttack()
    {
        animator.SetBool("attack", false);
    }
}
