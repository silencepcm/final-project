using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private SpriteRenderer sr;
    public float shootBulletspawn = 40f;
    public GameObject thePrefab;
    public Animator animator;
    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRadius;
    public int damage;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    public void shoot()
    {
        var pos = transform.position;
        if (sr.flipX)
        {
            pos.x -= shootBulletspawn;
        }
        else
        {
            pos.x += shootBulletspawn;
        }
        var instance = Instantiate(thePrefab, pos, transform.rotation);
    }

    public void attack()
    {
        if (sr.flipX)
        {
            Vector3 temppos;
            temppos.x = -attackPos.position.x;
            temppos.y = attackPos.position.y;
            temppos.z = attackPos.position.z;
            attackPos.position = temppos;
        }
        Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRadius, whatIsEnemies);
        for(int i=0; i< enemiesToDamage.Length; i++)
        {
            Debug.Log("I");
            enemiesToDamage[i].GetComponent<HealthEnemy>().takeDamage(damage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRadius);
    }
}
