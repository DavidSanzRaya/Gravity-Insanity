using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class Player : MonoBehaviour
{
    private NewControlls controlls;
    private MovementBehaviour mvb;
    private Animator anim;
    private SpriteRenderer spr;
    private Rigidbody2D rb;
    private HealthBehaviour hb;
    private bool godMode;
    [SerializeField] private GameObject blood;
    [SerializeField] private Transform iniRay1;
    [SerializeField] private Transform iniRay2;

    void Start()
    {
        controlls = GetComponent<NewControlls>();
        mvb = GetComponent<MovementBehaviour>();
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        godMode = false;
        TryGetComponent<HealthBehaviour>(out hb);
    }

    
    void Update()
    {

        RaycastHit2D hit1 = Physics2D.Raycast(iniRay1.position, -transform.up, 0.5f);
        RaycastHit2D hit2 = Physics2D.Raycast(iniRay2.position, -transform.up, 0.5f);

        if (hit1 || hit2)
        {
            if((hit1 && hit1.collider.gameObject.CompareTag("Ground")) || (hit2 && hit2.collider.gameObject.CompareTag("Ground")))
            {
                anim.SetBool("onGround", true);
            }
        }
        else
        {
            anim.SetBool("onGround", false);
        }


        if (controlls.moveValue != 0)
        {
            anim.SetBool("run", true);
            mvb.MoveRB2D(new Vector2(controlls.moveValue, 0));

            
            if(controlls.moveValue < 0)
            {
                spr.flipX = true;
            } else if(controlls.moveValue > 0)
            {
                spr.flipX = false;
            }
        }
        else
        {
            anim.SetBool("run", false);
            mvb.MoveRB2D(new Vector2(0, rb.velocity.y));
        }
    }

    public void GodMode()
    {

        godMode = !godMode;

        switch (godMode)
        {
            case true:
                //hb.enabled = false;
                spr.color = Color.green;
                this.gameObject.layer = LayerMask.NameToLayer("GodMode");
                break;
            case false:
                //hb.enabled = true;
                spr.color = Color.white;
                this.gameObject.layer = LayerMask.NameToLayer("Player");
                break;
        }
    }
}
