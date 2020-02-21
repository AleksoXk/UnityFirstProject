using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float jumpHeight;
    public float moveSpeed;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask WhatIsGround;
    private bool grounded;
    private bool doubleJump;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, WhatIsGround);
    }

    // Update is called once per frame
    void Update()
    {
        if (grounded)
            doubleJump = false;

        if(Input.GetKeyDown(KeyCode.W)&& grounded)
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.W)&& !grounded && !doubleJump)
        {
            Jump();
            doubleJump = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        }
        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        }




    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
    }

}
