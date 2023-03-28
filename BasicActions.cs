using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicActions : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D body;
    public SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = Input.GetKey(KeyCode.W) ? Vector2.up * movementSpeed
                      : Input.GetKey(KeyCode.A) ? Vector2.left * movementSpeed
                      : Input.GetKey(KeyCode.S) ? Vector2.down * movementSpeed
                      : Input.GetKey(KeyCode.D) ? Vector2.right * movementSpeed
            : Vector2.zero;

        sprite.flipX = body.velocity.x > 0;
    }
}
