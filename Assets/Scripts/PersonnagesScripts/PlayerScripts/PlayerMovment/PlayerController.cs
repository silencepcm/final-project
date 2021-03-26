using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEditor.Animations;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private LayerMask platformsLM;
    [SerializeField] private LayerMask plafondLM;
    public SpriteRenderer sr;
    private Rigidbody2D rb2d;
    private CapsuleCollider2D capcol2D;
    private Animator animator;
    public float jumpVelocity = 15f;
    public bool doubleJump = true;
    public float speed = 10;
    public bool died = false;
    PlayerAttack scriptAtt;
    private Option script;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = Option.FindObjectOfType<Sprite>();
        rb2d = GetComponent<Rigidbody2D>();
        capcol2D = GetComponent<CapsuleCollider2D>();
        scriptAtt = GetComponent<PlayerAttack>();
        animator = Option.FindObjectOfType<Animator>();
    }



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            scriptAtt.shoot();
        }
        else 
        if (Input.GetMouseButtonDown(1))
        {
            scriptAtt.attack();
            animator.SetTrigger("attack");
        }
        if (PlafondCollision())
        {
            died = true;
            animator.SetTrigger("Death");
        }
        else
        {
            HandleMouvement();
        }

    }

    private bool IsGrounded()
    {
        RaycastHit2D rch2D = Physics2D.BoxCast(capcol2D.bounds.center, capcol2D.bounds.size, 0f, Vector2.down, 1 / 10f, platformsLM);
        return rch2D.collider != null;
    }
    private bool PlafondCollision()
    {
        RaycastHit2D rch2D = Physics2D.BoxCast(capcol2D.bounds.center, capcol2D.bounds.size, 0f, Vector2.down, 1 / 10f, plafondLM);
        return rch2D.collider != null;
    }

    private void HandleMouvement()
    {
        bool tempGrounded = IsGrounded();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isGrounded", tempGrounded);
            if ((doubleJump)||(tempGrounded))
            {
                jump();
            }
            doubleJump = tempGrounded;
        } else
        if (tempGrounded)
        {
            animator.SetBool("isGrounded", true);
            if (Input.GetKey(KeyCode.A))
            {
                rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
                animator.SetFloat("speed", Mathf.Abs(rb2d.velocity.x));
                sr.flipX = true;
            }
            else
            if (Input.GetKey(KeyCode.D))
            {
                rb2d.velocity = new Vector2(+speed, rb2d.velocity.y);
                animator.SetFloat("speed", Mathf.Abs(rb2d.velocity.x));
                sr.flipX = false;
            }
            else
            {
                rb2d.velocity = new Vector2(0, rb2d.velocity.y);
                animator.SetFloat("speed", 0);
            }
        }
    }
    private void jump()
    {
        Vector2 dir = rb2d.velocity;
        dir.y = Vector2.up.y * jumpVelocity;
        rb2d.velocity = dir;
    }

    public void stopAnimAtt()
    {
        animator.SetTrigger("run");
    }
}