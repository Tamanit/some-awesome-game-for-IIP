using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BasicActions : MonoBehaviour
{
    public float movementSpeed = 1000f;
    public Rigidbody2D body;
    public SpriteRenderer sprite;
    public Animator animator;
    private Vector3 _movingVector;
    
    void Start()
    {
        body.GetComponent<Rigidbody2D>();
        sprite.GetComponent<SpriteRenderer>();
        animator.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        
        _movingVector = new Vector2(Input.GetAxis("Horizontal")*movementSpeed,0);
        body.velocity = _movingVector;

        switch (body.velocity.x)
        {
            case > 0:
                sprite.flipX = true;
                break;
            case < 0:
                sprite.flipX = false;
                break;
        }

        animator.SetBool("XMove", Math.Abs(body.velocity.x) > 0);
        animator.SetFloat("YMove", Input.GetAxis("Vertical"));
    }
}