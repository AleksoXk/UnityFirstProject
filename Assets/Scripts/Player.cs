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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
        
        }
        if(Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        }
        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        }
    }
}
