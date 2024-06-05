using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float input;
    public float speed;
    public SpriteRenderer rbSprite;
    

    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
        if (input < 0)
        {
            rbSprite.flipX = true;
        }
        else if (input > 0)
        {
            rbSprite.flipX = false;
        }

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(input * speed, rb.velocity.y);

    }
}
