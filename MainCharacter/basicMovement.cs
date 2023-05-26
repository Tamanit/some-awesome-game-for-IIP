using UnityEngine;

public class basicMovement : MonoBehaviour
{
    private float movementSpeed = 60f;
    private Rigidbody2D body;
    private SpriteRenderer sprite;
    private Animator animator;

    void Awake()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        sprite = gameObject.GetComponent<SpriteRenderer>();
        animator = gameObject.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, 0);
        animator.SetBool("XMove", !Mathf.Approximately(0f, body.velocity.x));
        
        switch (body.velocity.x)
        {
            case > 0:
                sprite.flipX = true;
                break;
            case < 0:
                sprite.flipX = false;
                break;
        }
    }
}