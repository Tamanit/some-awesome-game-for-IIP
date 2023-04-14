using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicActions : MonoBehaviour
{
    public float movementSpeed = 3.5f;
    public CharacterController body;
    //public Rigidbody2D body;
    public SpriteRenderer sprite;
    public Animator animator;

    private Vector3 _movingVector;
    void Start()
    {
        body.GetComponent<CharacterController>();
        sprite.GetComponent<SpriteRenderer>();
        animator.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        //if (body.isGrounded){}

        _movingVector = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        _movingVector = transform.TransformDirection(_movingVector);
        _movingVector *= movementSpeed;

        body.Move(_movingVector * Time.deltaTime);


        /*body.velocity = Input.GetKey(KeyCode.W) ? Vector2.up * movementSpeed
                  : Input.GetKey(KeyCode.A) ? Vector2.left * movementSpeed
                  : Input.GetKey(KeyCode.S) ? Vector2.down * movementSpeed
                  : Input.GetKey(KeyCode.D) ? Vector2.right * movementSpeed
        : Vector2.zero;
*/
        /*
        _movingVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        _movingVector *= movementSpeed;
        body.velocity = _movingVector;
       */
        switch (body.velocity.x)
        {
            case > 0:
                sprite.flipX = true;
                break;
            case < 0:
                sprite.flipX = false;
                break;
        }

        //var isUpDownMoving = Input.GetButtonDown(KeyCode.)
        //var ismoving = body.velocity.x != 0

        //animator.SetFloat("UpDownAxis", Input.GetAxis("Vertical"));
        animator.SetBool("XMove", Math.Abs(body.velocity.x) > 0);
        animator.SetFloat("YMove", Input.GetAxis("Vertical"));

        //if (body.velocity.x > 0) sprite.flipX = true;
        //if (body.velocity.x < 0) sprite.flipX = false;


    }
}