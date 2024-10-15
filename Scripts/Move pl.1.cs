using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;


    private Rigidbody2D rb;


    private Vector2 moveDirection;


    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        ProcessInputs();
    }


    void FixedUpdate()
    {

        Move();
    }


    void ProcessInputs()
    {

        moveDirection = Vector2.zero;


        if (Input.GetKey(KeyCode.W)) 
        {
            moveDirection.y = 1;
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            moveDirection.y = -1;
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            moveDirection.x = -1;
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            moveDirection.x = 1;
        }

 
        moveDirection = moveDirection.normalized;
    }


    void Move()
    {

        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
